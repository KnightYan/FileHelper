using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tudo certo?", "Tudo certo?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pnlFormulario.Enabled = false;
                pnlProgresso.Visible = true;

                var progress = new Progress<string>(s => txtProgresso.Texts = (s));
                var progressList = new Progress<string>(s => txtProgressoLista.Texts += (Environment.NewLine +s));

                await new FileHandler(progress, progressList).RenameFilesAndCopy(txtCaminhoArquivos.Texts, tbCopiar.Checked, txtCaminhoArquivosResultado.Texts, txtTextoASerSubstituido.Texts, txtTextoNovo.Texts) ;
            }
            
        }

        private void tbCopiar_CheckedChanged(object sender, EventArgs e)
        {
            txtCaminhoArquivosResultado.Enabled = tbCopiar.Checked;
        }

        private void btnFormatos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arquivos que serão alterados:\n.cs .txt .resx .csproj .user .resx .xaml .json\nDemais arquivos serão apenas copiados quando marcado a opção de copiar.");
        }
    }
}
