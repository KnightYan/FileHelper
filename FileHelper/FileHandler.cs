using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace FileHelper
{
    public class FileHandler
    {
        private readonly Object lockHelper = new Object();
        private readonly List<string> supportedExtensions = new()
        {
            ".cs", ".txt", ".resx", ".csproj", ".user", ".resx", ".xaml", ".json"
        };
        private readonly IProgress<string> progress;
        private readonly IProgress<string> progressList;

        private readonly ParallelOptions parallelConfiguration = new()
        {
            MaxDegreeOfParallelism = Environment.ProcessorCount
        };

        public FileHandler(IProgress<string> progress, IProgress<string> progressList)
        {
            this.progress = progress;
            this.progressList = progressList;
        }

        public async Task RenameFilesAndCopy(string pathOrigin, bool copy, string pathDestiny, string oldName, string newName)
        {
            var t = Task.Factory.StartNew(() =>
            {
                var filesList = Directory.GetFiles(pathOrigin, "*.*", SearchOption.AllDirectories);

                var totalTasks = filesList.Length;
                var doneTasks = 0;
                progress.Report(doneTasks + "/" + totalTasks);

                Parallel.ForEach(filesList, parallelConfiguration, file =>
                {
                    try
                    {
                        var finalPath = copy ? CopyFile(pathOrigin, file, pathDestiny, oldName, newName) : file;

                        progressList.Report(String.Format("Alterando Arquivo: {0}", finalPath));

                        InternalContentRename(finalPath, oldName, newName);

                        lock (lockHelper)
                        {
                            doneTasks++;
                            progress.Report(doneTasks + "/" + totalTasks);
                        }
                    }
                    catch (Exception ex)
                    {
                        progressList.Report(String.Format("Falha ao manipular: {0}\nErro: {1}", file, ex.Message));
                    }
                });
            });
            await t;
        }

        private string CopyFile(string pathOrigin, string file, string copyPathDestiny, string oldName, string newName)
        {
            var fileName = Path.GetFileName(file);

            progressList.Report(String.Format("Iniciando a copia de: {0}", fileName));

            var filePath = Path.GetDirectoryName(file) ?? "";
            var destinyPath = PathCombine(copyPathDestiny, filePath.Remove(0, pathOrigin.Length));

            destinyPath = destinyPath.Contains(oldName) ? destinyPath.Replace(oldName, newName) : destinyPath;
            var fileCopyName = fileName.Contains(oldName) ? fileName.Replace(oldName, newName) : fileName;

            if (!Directory.Exists(destinyPath))
                Directory.CreateDirectory(destinyPath);

            var fileCopyPath = Path.Combine(destinyPath, fileCopyName);

            File.Copy(file, fileCopyPath);

            progressList.Report(String.Format("Arquivo copiado para: {0}", fileCopyPath));

            return fileCopyPath;
        }

        private string PathCombine(string copyPathDestiny, string estrucityPathDestiny)
        {
            if(copyPathDestiny.EndsWith("\\"))
                return copyPathDestiny + estrucityPathDestiny;

            return copyPathDestiny + "\\" + estrucityPathDestiny;
        }

        private void InternalContentRename(string filePath, string oldName, string newName)
        {
            if (FileNotSupported(filePath))
                return;

            List<string?> internalContent = new();

            using (StreamReader st = new StreamReader(filePath))
            {
                while (!st.EndOfStream)
                {
                    internalContent.Add(st.ReadLine());
                }
            }

            using (StreamWriter sw = File.CreateText(filePath))
            {
                foreach (var line in internalContent)
                    sw.WriteLine((line ?? "").Replace(oldName, newName));
            };

        }

        private bool FileNotSupported(string filePath)
        {
            FileAttributes attr = File.GetAttributes(filePath);

            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                return true;

            var extension = Path.GetExtension(filePath);

            if(!supportedExtensions.Contains(extension))
                return true;

            return false;
        }
    }
}
