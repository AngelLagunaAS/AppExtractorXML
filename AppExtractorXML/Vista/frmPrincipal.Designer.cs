namespace AppExtractorXML.Vista
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialogXML = new System.Windows.Forms.OpenFileDialog();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.gboxXML = new System.Windows.Forms.GroupBox();
            this.txtRutaXML = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.gBoxZIP = new System.Windows.Forms.GroupBox();
            this.txtRutaZIP = new System.Windows.Forms.TextBox();
            this.btnDestino = new System.Windows.Forms.Button();
            this.gboxXML.SuspendLayout();
            this.gBoxZIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogXML
            // 
            this.openFileDialogXML.FileName = "openFileDialogXML";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(140, 228);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(152, 48);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar Archivos";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // gboxXML
            // 
            this.gboxXML.Controls.Add(this.txtRutaXML);
            this.gboxXML.Controls.Add(this.btnAbrir);
            this.gboxXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxXML.Location = new System.Drawing.Point(12, 39);
            this.gboxXML.Name = "gboxXML";
            this.gboxXML.Size = new System.Drawing.Size(408, 71);
            this.gboxXML.TabIndex = 7;
            this.gboxXML.TabStop = false;
            this.gboxXML.Text = "Ruta de XML";
            // 
            // txtRutaXML
            // 
            this.txtRutaXML.Enabled = false;
            this.txtRutaXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaXML.Location = new System.Drawing.Point(27, 31);
            this.txtRutaXML.Name = "txtRutaXML";
            this.txtRutaXML.Size = new System.Drawing.Size(270, 24);
            this.txtRutaXML.TabIndex = 7;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(296, 30);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(83, 26);
            this.btnAbrir.TabIndex = 6;
            this.btnAbrir.Text = "Buscar";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // gBoxZIP
            // 
            this.gBoxZIP.Controls.Add(this.txtRutaZIP);
            this.gBoxZIP.Controls.Add(this.btnDestino);
            this.gBoxZIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxZIP.Location = new System.Drawing.Point(12, 140);
            this.gBoxZIP.Name = "gBoxZIP";
            this.gBoxZIP.Size = new System.Drawing.Size(408, 71);
            this.gBoxZIP.TabIndex = 8;
            this.gBoxZIP.TabStop = false;
            this.gBoxZIP.Text = "Ruta de ZIP";
            // 
            // txtRutaZIP
            // 
            this.txtRutaZIP.Enabled = false;
            this.txtRutaZIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaZIP.Location = new System.Drawing.Point(28, 32);
            this.txtRutaZIP.Name = "txtRutaZIP";
            this.txtRutaZIP.Size = new System.Drawing.Size(270, 24);
            this.txtRutaZIP.TabIndex = 8;
            // 
            // btnDestino
            // 
            this.btnDestino.Location = new System.Drawing.Point(297, 31);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(83, 26);
            this.btnDestino.TabIndex = 7;
            this.btnDestino.Text = "Buscar";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(439, 297);
            this.Controls.Add(this.gBoxZIP);
            this.Controls.Add(this.gboxXML);
            this.Controls.Add(this.btnProcesar);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Extractor de XML";
            this.gboxXML.ResumeLayout(false);
            this.gboxXML.PerformLayout();
            this.gBoxZIP.ResumeLayout(false);
            this.gBoxZIP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialogXML;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.GroupBox gboxXML;
        private System.Windows.Forms.TextBox txtRutaXML;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.GroupBox gBoxZIP;
        private System.Windows.Forms.TextBox txtRutaZIP;
        private System.Windows.Forms.Button btnDestino;
    }
}