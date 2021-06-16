namespace DownloadManager
{
    partial class frmNewDownload
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDownloadRate = new System.Windows.Forms.ComboBox();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.chcStart = new System.Windows.Forms.CheckBox();
            this.btnAddDownload = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "İndirme Adresi";
            // 
            // txtFileUrl
            // 
            this.txtFileUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFileUrl.Location = new System.Drawing.Point(108, 23);
            this.txtFileUrl.Name = "txtFileUrl";
            this.txtFileUrl.Size = new System.Drawing.Size(262, 21);
            this.txtFileUrl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "İndirme Hızı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kayıt Yeri";
            // 
            // cmbDownloadRate
            // 
            this.cmbDownloadRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDownloadRate.FormattingEnabled = true;
            this.cmbDownloadRate.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048",
            "4096"});
            this.cmbDownloadRate.Location = new System.Drawing.Point(108, 59);
            this.cmbDownloadRate.Name = "cmbDownloadRate";
            this.cmbDownloadRate.Size = new System.Drawing.Size(100, 23);
            this.cmbDownloadRate.TabIndex = 4;
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOutputPath.Location = new System.Drawing.Point(108, 100);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(227, 21);
            this.txtOutputPath.TabIndex = 5;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectPath.Location = new System.Drawing.Point(342, 100);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(28, 21);
            this.btnSelectPath.TabIndex = 6;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // chcStart
            // 
            this.chcStart.AutoSize = true;
            this.chcStart.Checked = true;
            this.chcStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chcStart.Location = new System.Drawing.Point(108, 141);
            this.chcStart.Name = "chcStart";
            this.chcStart.Size = new System.Drawing.Size(207, 19);
            this.chcStart.TabIndex = 7;
            this.chcStart.Text = "İndirme İşlemi Hemen Başlatılsın";
            this.chcStart.UseVisualStyleBackColor = true;
            // 
            // btnAddDownload
            // 
            this.btnAddDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddDownload.Location = new System.Drawing.Point(108, 177);
            this.btnAddDownload.Name = "btnAddDownload";
            this.btnAddDownload.Size = new System.Drawing.Size(100, 36);
            this.btnAddDownload.TabIndex = 8;
            this.btnAddDownload.Text = "Listeye Ekle";
            this.btnAddDownload.UseVisualStyleBackColor = true;
            this.btnAddDownload.Click += new System.EventHandler(this.btnAddDownload_Click);
            // 
            // frmNewDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 225);
            this.Controls.Add(this.btnAddDownload);
            this.Controls.Add(this.chcStart);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.cmbDownloadRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileUrl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni İndirme İşlemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDownloadRate;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.CheckBox chcStart;
        private System.Windows.Forms.Button btnAddDownload;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}