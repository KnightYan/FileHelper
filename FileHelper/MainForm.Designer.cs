namespace FileHelper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.btnFormatos = new FileHelper.CustomComponents.CustomButton();
            this.btnIniciar = new FileHelper.CustomComponents.CustomButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtCaminhoArquivosResultado = new FileHelper.CustomComponents.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCopiar = new FileHelper.CustomComponents.CustomToggleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTextoASerSubstituido = new FileHelper.CustomComponents.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTextoNovo = new FileHelper.CustomComponents.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaminhoArquivos = new FileHelper.CustomComponents.CustomTextBox();
            this.pnlProgresso = new System.Windows.Forms.Panel();
            this.txtProgressoLista = new FileHelper.CustomComponents.CustomTextBox();
            this.txtProgresso = new FileHelper.CustomComponents.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlFormulario.SuspendLayout();
            this.pnlProgresso.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.btnFormatos);
            this.pnlFormulario.Controls.Add(this.btnIniciar);
            this.pnlFormulario.Controls.Add(this.label5);
            this.pnlFormulario.Controls.Add(this.txtCaminhoArquivosResultado);
            this.pnlFormulario.Controls.Add(this.label4);
            this.pnlFormulario.Controls.Add(this.tbCopiar);
            this.pnlFormulario.Controls.Add(this.label3);
            this.pnlFormulario.Controls.Add(this.txtTextoASerSubstituido);
            this.pnlFormulario.Controls.Add(this.label2);
            this.pnlFormulario.Controls.Add(this.txtTextoNovo);
            this.pnlFormulario.Controls.Add(this.label1);
            this.pnlFormulario.Controls.Add(this.txtCaminhoArquivos);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormulario.Location = new System.Drawing.Point(0, 0);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(746, 515);
            this.pnlFormulario.TabIndex = 0;
            // 
            // btnFormatos
            // 
            this.btnFormatos.BackColor = System.Drawing.Color.Gold;
            this.btnFormatos.BackgroundColor = System.Drawing.Color.Gold;
            this.btnFormatos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFormatos.BorderRadius = 0;
            this.btnFormatos.BorderSize = 0;
            this.btnFormatos.FlatAppearance.BorderSize = 0;
            this.btnFormatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFormatos.ForeColor = System.Drawing.Color.White;
            this.btnFormatos.Location = new System.Drawing.Point(13, 448);
            this.btnFormatos.Name = "btnFormatos";
            this.btnFormatos.Size = new System.Drawing.Size(367, 49);
            this.btnFormatos.TabIndex = 5;
            this.btnFormatos.Text = "Formatos de Arquivos Suportados";
            this.btnFormatos.TextColor = System.Drawing.Color.White;
            this.btnFormatos.UseVisualStyleBackColor = false;
            this.btnFormatos.Click += new System.EventHandler(this.btnFormatos_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Gold;
            this.btnIniciar.BackgroundColor = System.Drawing.Color.Gold;
            this.btnIniciar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnIniciar.BorderRadius = 0;
            this.btnIniciar.BorderSize = 0;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.ImageKey = "(nenhum)";
            this.btnIniciar.ImageList = this.imageList;
            this.btnIniciar.Location = new System.Drawing.Point(613, 448);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(116, 49);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.TextColor = System.Drawing.Color.White;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "superstar.gif");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Novo Caminho";
            // 
            // txtCaminhoArquivosResultado
            // 
            this.txtCaminhoArquivosResultado.BackColor = System.Drawing.SystemColors.Window;
            this.txtCaminhoArquivosResultado.BorderColor = System.Drawing.Color.Gold;
            this.txtCaminhoArquivosResultado.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCaminhoArquivosResultado.BorderSize = 2;
            this.txtCaminhoArquivosResultado.Enabled = false;
            this.txtCaminhoArquivosResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCaminhoArquivosResultado.ForeColor = System.Drawing.Color.DimGray;
            this.txtCaminhoArquivosResultado.Location = new System.Drawing.Point(13, 386);
            this.txtCaminhoArquivosResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCaminhoArquivosResultado.Multiline = false;
            this.txtCaminhoArquivosResultado.Name = "txtCaminhoArquivosResultado";
            this.txtCaminhoArquivosResultado.Padding = new System.Windows.Forms.Padding(8);
            this.txtCaminhoArquivosResultado.PasswordChar = false;
            this.txtCaminhoArquivosResultado.ReadOnly = false;
            this.txtCaminhoArquivosResultado.Size = new System.Drawing.Size(716, 37);
            this.txtCaminhoArquivosResultado.TabIndex = 4;
            this.txtCaminhoArquivosResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCaminhoArquivosResultado.Texts = "";
            this.txtCaminhoArquivosResultado.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(90, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(656, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Manter arquivos e copiar (Somente na copia as pastas e arquivos serão renomeados)" +
    "";
            // 
            // tbCopiar
            // 
            this.tbCopiar.Location = new System.Drawing.Point(13, 299);
            this.tbCopiar.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbCopiar.Name = "tbCopiar";
            this.tbCopiar.OffBackColor = System.Drawing.Color.Gray;
            this.tbCopiar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbCopiar.OnBackColor = System.Drawing.Color.Gold;
            this.tbCopiar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbCopiar.Size = new System.Drawing.Size(71, 34);
            this.tbCopiar.TabIndex = 3;
            this.tbCopiar.UseVisualStyleBackColor = true;
            this.tbCopiar.CheckedChanged += new System.EventHandler(this.tbCopiar_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Texto a ser Substituido";
            // 
            // txtTextoASerSubstituido
            // 
            this.txtTextoASerSubstituido.BackColor = System.Drawing.SystemColors.Window;
            this.txtTextoASerSubstituido.BorderColor = System.Drawing.Color.Gold;
            this.txtTextoASerSubstituido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTextoASerSubstituido.BorderSize = 2;
            this.txtTextoASerSubstituido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTextoASerSubstituido.ForeColor = System.Drawing.Color.DimGray;
            this.txtTextoASerSubstituido.Location = new System.Drawing.Point(13, 137);
            this.txtTextoASerSubstituido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTextoASerSubstituido.Multiline = false;
            this.txtTextoASerSubstituido.Name = "txtTextoASerSubstituido";
            this.txtTextoASerSubstituido.Padding = new System.Windows.Forms.Padding(8);
            this.txtTextoASerSubstituido.PasswordChar = false;
            this.txtTextoASerSubstituido.ReadOnly = false;
            this.txtTextoASerSubstituido.Size = new System.Drawing.Size(716, 37);
            this.txtTextoASerSubstituido.TabIndex = 1;
            this.txtTextoASerSubstituido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTextoASerSubstituido.Texts = "";
            this.txtTextoASerSubstituido.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Novo Texto";
            // 
            // txtTextoNovo
            // 
            this.txtTextoNovo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTextoNovo.BorderColor = System.Drawing.Color.Gold;
            this.txtTextoNovo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTextoNovo.BorderSize = 2;
            this.txtTextoNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTextoNovo.ForeColor = System.Drawing.Color.DimGray;
            this.txtTextoNovo.Location = new System.Drawing.Point(13, 234);
            this.txtTextoNovo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTextoNovo.Multiline = false;
            this.txtTextoNovo.Name = "txtTextoNovo";
            this.txtTextoNovo.Padding = new System.Windows.Forms.Padding(8);
            this.txtTextoNovo.PasswordChar = false;
            this.txtTextoNovo.ReadOnly = false;
            this.txtTextoNovo.Size = new System.Drawing.Size(716, 37);
            this.txtTextoNovo.TabIndex = 2;
            this.txtTextoNovo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTextoNovo.Texts = "";
            this.txtTextoNovo.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Local dos Arquivos";
            // 
            // txtCaminhoArquivos
            // 
            this.txtCaminhoArquivos.BackColor = System.Drawing.SystemColors.Window;
            this.txtCaminhoArquivos.BorderColor = System.Drawing.Color.Gold;
            this.txtCaminhoArquivos.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCaminhoArquivos.BorderSize = 2;
            this.txtCaminhoArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCaminhoArquivos.ForeColor = System.Drawing.Color.DimGray;
            this.txtCaminhoArquivos.Location = new System.Drawing.Point(13, 46);
            this.txtCaminhoArquivos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCaminhoArquivos.Multiline = false;
            this.txtCaminhoArquivos.Name = "txtCaminhoArquivos";
            this.txtCaminhoArquivos.Padding = new System.Windows.Forms.Padding(8);
            this.txtCaminhoArquivos.PasswordChar = false;
            this.txtCaminhoArquivos.ReadOnly = false;
            this.txtCaminhoArquivos.Size = new System.Drawing.Size(716, 37);
            this.txtCaminhoArquivos.TabIndex = 0;
            this.txtCaminhoArquivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCaminhoArquivos.Texts = "";
            this.txtCaminhoArquivos.UnderlinedStyle = true;
            // 
            // pnlProgresso
            // 
            this.pnlProgresso.Controls.Add(this.txtProgressoLista);
            this.pnlProgresso.Controls.Add(this.txtProgresso);
            this.pnlProgresso.Controls.Add(this.label6);
            this.pnlProgresso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProgresso.Location = new System.Drawing.Point(0, 515);
            this.pnlProgresso.Name = "pnlProgresso";
            this.pnlProgresso.Size = new System.Drawing.Size(746, 218);
            this.pnlProgresso.TabIndex = 1;
            this.pnlProgresso.Visible = false;
            // 
            // txtProgressoLista
            // 
            this.txtProgressoLista.BackColor = System.Drawing.SystemColors.Window;
            this.txtProgressoLista.BorderColor = System.Drawing.Color.Gold;
            this.txtProgressoLista.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtProgressoLista.BorderSize = 2;
            this.txtProgressoLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProgressoLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProgressoLista.ForeColor = System.Drawing.Color.DimGray;
            this.txtProgressoLista.Location = new System.Drawing.Point(0, 71);
            this.txtProgressoLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProgressoLista.Multiline = true;
            this.txtProgressoLista.Name = "txtProgressoLista";
            this.txtProgressoLista.Padding = new System.Windows.Forms.Padding(8);
            this.txtProgressoLista.PasswordChar = false;
            this.txtProgressoLista.ReadOnly = true;
            this.txtProgressoLista.Size = new System.Drawing.Size(746, 147);
            this.txtProgressoLista.TabIndex = 29;
            this.txtProgressoLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProgressoLista.Texts = "";
            this.txtProgressoLista.UnderlinedStyle = false;
            // 
            // txtProgresso
            // 
            this.txtProgresso.BackColor = System.Drawing.SystemColors.Window;
            this.txtProgresso.BorderColor = System.Drawing.Color.Gold;
            this.txtProgresso.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtProgresso.BorderSize = 2;
            this.txtProgresso.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProgresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProgresso.ForeColor = System.Drawing.Color.DimGray;
            this.txtProgresso.Location = new System.Drawing.Point(0, 34);
            this.txtProgresso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProgresso.Multiline = true;
            this.txtProgresso.Name = "txtProgresso";
            this.txtProgresso.Padding = new System.Windows.Forms.Padding(8);
            this.txtProgresso.PasswordChar = false;
            this.txtProgresso.ReadOnly = true;
            this.txtProgresso.Size = new System.Drawing.Size(746, 37);
            this.txtProgresso.TabIndex = 27;
            this.txtProgresso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProgresso.Texts = "";
            this.txtProgresso.UnderlinedStyle = true;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(746, 34);
            this.label6.TabIndex = 28;
            this.label6.Text = "Progresso";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 733);
            this.Controls.Add(this.pnlProgresso);
            this.Controls.Add(this.pnlFormulario);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(764, 780);
            this.MinimumSize = new System.Drawing.Size(764, 734);
            this.Name = "MainForm";
            this.Text = "File Helper";
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            this.pnlProgresso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormulario;
        private CustomComponents.CustomButton btnIniciar;
        private System.Windows.Forms.Label label5;
        private CustomComponents.CustomTextBox txtCaminhoArquivosResultado;
        private System.Windows.Forms.Label label4;
        private CustomComponents.CustomToggleButton tbCopiar;
        private System.Windows.Forms.Label label3;
        private CustomComponents.CustomTextBox txtTextoASerSubstituido;
        private System.Windows.Forms.Label label2;
        private CustomComponents.CustomTextBox txtTextoNovo;
        private System.Windows.Forms.Label label1;
        private CustomComponents.CustomTextBox txtCaminhoArquivos;
        private System.Windows.Forms.Panel pnlProgresso;
        private CustomComponents.CustomTextBox txtProgressoLista;
        private System.Windows.Forms.Label label6;
        private CustomComponents.CustomTextBox txtProgresso;
        private CustomComponents.CustomButton btnFormatos;
        private System.Windows.Forms.ImageList imageList;
    }
}
