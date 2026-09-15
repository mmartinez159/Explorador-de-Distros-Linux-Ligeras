namespace Explorador_de_Distros_Linux_Ligeras
{
    partial class Form1
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
            comboDistro = new ComboBox();
            Descripcion = new Label();
            LinkDescarga = new LinkLabel();
            picLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // comboDistro
            // 
            comboDistro.FormattingEnabled = true;
            comboDistro.Location = new Point(55, 29);
            comboDistro.Name = "comboDistro";
            comboDistro.Size = new Size(675, 28);
            comboDistro.TabIndex = 0;
            comboDistro.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Descripcion
            // 
            Descripcion.AutoSize = true;
            Descripcion.Location = new Point(459, 92);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(50, 20);
            Descripcion.TabIndex = 1;
            Descripcion.Text = "label1";
            // 
            // LinkDescarga
            // 
            LinkDescarga.AutoSize = true;
            LinkDescarga.Location = new Point(387, 380);
            LinkDescarga.Name = "LinkDescarga";
            LinkDescarga.Size = new Size(76, 20);
            LinkDescarga.TabIndex = 2;
            LinkDescarga.TabStop = true;
            LinkDescarga.Text = "linkLabel1";
            LinkDescarga.LinkClicked += LinkDescarga_LinkClicked;
            // 
            // picLogo
            // 
            picLogo.Location = new Point(55, 92);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(245, 274);
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picLogo);
            Controls.Add(LinkDescarga);
            Controls.Add(Descripcion);
            Controls.Add(comboDistro);
            Name = "Form1";
            Text = "Explorador de Distros Linux Ligeras";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboDistro;
        private Label Descripcion;
        private LinkLabel LinkDescarga;
        private PictureBox picLogo;
    }
}
