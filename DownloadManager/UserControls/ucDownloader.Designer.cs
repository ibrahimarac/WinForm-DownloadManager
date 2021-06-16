namespace DownloadManager.UserControls
{
    partial class ucDownloader
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.progressDownloader = new System.Windows.Forms.ProgressBar();
            this.btnPauseContinue = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.lblPercentage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFileName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressDownloader, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPauseContinue, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 24);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPercentage
            // 
            this.lblPercentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPercentage.Location = new System.Drawing.Point(193, 0);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(41, 24);
            this.lblPercentage.TabIndex = 1;
            this.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFileName
            // 
            this.lblFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFileName.Location = new System.Drawing.Point(3, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(184, 24);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressDownloader
            // 
            this.progressDownloader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressDownloader.Location = new System.Drawing.Point(240, 3);
            this.progressDownloader.Name = "progressDownloader";
            this.progressDownloader.Size = new System.Drawing.Size(184, 18);
            this.progressDownloader.TabIndex = 2;
            // 
            // btnPauseContinue
            // 
            this.btnPauseContinue.BackgroundImage = global::DownloadManager.Properties.Resources.pause;
            this.btnPauseContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPauseContinue.FlatAppearance.BorderSize = 0;
            this.btnPauseContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPauseContinue.Location = new System.Drawing.Point(430, 3);
            this.btnPauseContinue.Name = "btnPauseContinue";
            this.btnPauseContinue.Size = new System.Drawing.Size(30, 18);
            this.btnPauseContinue.TabIndex = 3;
            this.btnPauseContinue.UseVisualStyleBackColor = true;
            this.btnPauseContinue.Click += new System.EventHandler(this.btnPauseContinue_Click);
            // 
            // ucDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucDownloader";
            this.Size = new System.Drawing.Size(476, 24);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.ProgressBar progressDownloader;
        private System.Windows.Forms.Button btnPauseContinue;
    }
}
