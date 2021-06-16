namespace DownloadManager.UserControls
{
    partial class ucComplatedDownloads
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
            this.label1 = new System.Windows.Forms.Label();
            this.listComplatedDownloads = new System.Windows.Forms.ListView();
            this.fileurl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.baslama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bitis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.indirmehizi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.konum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listComplatedDownloads, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 558);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamamlanan İndirme İşlemleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listComplatedDownloads
            // 
            this.listComplatedDownloads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileurl,
            this.baslama,
            this.bitis,
            this.indirmehizi,
            this.konum});
            this.listComplatedDownloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listComplatedDownloads.HideSelection = false;
            this.listComplatedDownloads.Location = new System.Drawing.Point(4, 41);
            this.listComplatedDownloads.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listComplatedDownloads.Name = "listComplatedDownloads";
            this.listComplatedDownloads.Size = new System.Drawing.Size(716, 513);
            this.listComplatedDownloads.TabIndex = 1;
            this.listComplatedDownloads.UseCompatibleStateImageBehavior = false;
            this.listComplatedDownloads.View = System.Windows.Forms.View.Details;
            // 
            // fileurl
            // 
            this.fileurl.Text = "Url Adresi";
            this.fileurl.Width = 244;
            // 
            // baslama
            // 
            this.baslama.Text = "Başlangıç Tarihi";
            this.baslama.Width = 93;
            // 
            // bitis
            // 
            this.bitis.Text = "Bitiş Tarihi";
            this.bitis.Width = 98;
            // 
            // indirmehizi
            // 
            this.indirmehizi.Text = "İndirma Hızı";
            this.indirmehizi.Width = 99;
            // 
            // konum
            // 
            this.konum.Text = "Dosya Yolu";
            this.konum.Width = 121;
            // 
            // ucComplatedDownloads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucComplatedDownloads";
            this.Size = new System.Drawing.Size(724, 558);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listComplatedDownloads;
        private System.Windows.Forms.ColumnHeader fileurl;
        private System.Windows.Forms.ColumnHeader baslama;
        private System.Windows.Forms.ColumnHeader bitis;
        private System.Windows.Forms.ColumnHeader indirmehizi;
        private System.Windows.Forms.ColumnHeader konum;
    }
}
