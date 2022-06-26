namespace xmlCounter
{
    partial class frmContador
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
            this.ofdXML = new System.Windows.Forms.OpenFileDialog();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.edtTag = new System.Windows.Forms.TextBox();
            this.fbdXML = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // ofdXML
            // 
            this.ofdXML.FileName = "Selecione a fonte de dados";
            this.ofdXML.Filter = "Arquivos XML (*.xml)|*.xml";
            this.ofdXML.Multiselect = true;
            this.ofdXML.Title = "Selecione os arquivos XML";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(57, 78);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(89, 23);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Selecionar...";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // edtTag
            // 
            this.edtTag.Location = new System.Drawing.Point(45, 49);
            this.edtTag.Name = "edtTag";
            this.edtTag.Size = new System.Drawing.Size(110, 23);
            this.edtTag.TabIndex = 1;
            // 
            // fbdXML
            // 
            this.fbdXML.InitialDirectory = "C:\\";
            // 
            // frmContador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.edtTag);
            this.Controls.Add(this.btnSelecionar);
            this.Name = "frmContador";
            this.Text = "Contador de tags XML";
            this.Load += new System.EventHandler(this.frmContador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog ofdXML;
        private Button btnSelecionar;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox edtTag;
        private FolderBrowserDialog fbdXML;
    }
}