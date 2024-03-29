﻿namespace xmlCounter
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
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.edtTag = new System.Windows.Forms.TextBox();
            this.dlgXML = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dlgXMLArq = new System.Windows.Forms.OpenFileDialog();
            this.txtArqs = new System.Windows.Forms.ListBox();
            this.txtDiv = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(44, 103);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(91, 46);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Selecionar diretório...";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // edtTag
            // 
            this.edtTag.Location = new System.Drawing.Point(44, 66);
            this.edtTag.Name = "edtTag";
            this.edtTag.Size = new System.Drawing.Size(91, 23);
            this.edtTag.TabIndex = 1;
            this.edtTag.Text = "nNF";
            this.edtTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dlgXML
            // 
            this.dlgXML.InitialDirectory = "C:\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe o nome da tag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "<";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = ">";
            // 
            // txtArqs
            // 
            this.txtArqs.Enabled = false;
            this.txtArqs.FormattingEnabled = true;
            this.txtArqs.ItemHeight = 15;
            this.txtArqs.Location = new System.Drawing.Point(191, 12);
            this.txtArqs.Name = "txtArqs";
            this.txtArqs.Size = new System.Drawing.Size(513, 394);
            this.txtArqs.TabIndex = 5;
            // 
            // txtDiv
            // 
            this.txtDiv.Enabled = false;
            this.txtDiv.FormattingEnabled = true;
            this.txtDiv.ItemHeight = 15;
            this.txtDiv.Location = new System.Drawing.Point(722, 27);
            this.txtDiv.Name = "txtDiv";
            this.txtDiv.Size = new System.Drawing.Size(398, 379);
            this.txtDiv.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(889, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inconsistências";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "©️ Gretti";
            // 
            // frmContador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 418);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiv);
            this.Controls.Add(this.txtArqs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtTag);
            this.Controls.Add(this.btnSelecionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmContador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de tags XML";
            this.Load += new System.EventHandler(this.frmContador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSelecionar;
        private TextBox edtTag;
        private FolderBrowserDialog dlgXML;
        private Label label1;
        private Label label2;
        private Label label3;
        private OpenFileDialog dlgXMLArq;
        private ListBox txtArqs;
        private ListBox txtDiv;
        private Label label4;
        private Label label5;
    }
}