namespace DownloadManager
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Yeni İndirme");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Devam Eden İndirmeler", 0, 0);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Tamamlanan İndirmeler", 1, 1);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Ayarlar", 4, 4);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("İşlemler", 3, 3, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tblMainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.treeMenu = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tblMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMainContainer
            // 
            this.tblMainContainer.ColumnCount = 2;
            this.tblMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.74932F));
            this.tblMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.25068F));
            this.tblMainContainer.Controls.Add(this.treeMenu, 0, 0);
            this.tblMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainContainer.Location = new System.Drawing.Point(0, 0);
            this.tblMainContainer.Margin = new System.Windows.Forms.Padding(4);
            this.tblMainContainer.Name = "tblMainContainer";
            this.tblMainContainer.RowCount = 1;
            this.tblMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblMainContainer.Size = new System.Drawing.Size(979, 529);
            this.tblMainContainer.TabIndex = 0;
            // 
            // treeMenu
            // 
            this.treeMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMenu.ImageIndex = 0;
            this.treeMenu.ImageList = this.imageList;
            this.treeMenu.ItemHeight = 25;
            this.treeMenu.Location = new System.Drawing.Point(4, 4);
            this.treeMenu.Margin = new System.Windows.Forms.Padding(4);
            this.treeMenu.Name = "treeMenu";
            treeNode1.ImageIndex = 2;
            treeNode1.Name = "Node1";
            treeNode1.SelectedImageKey = "newdownload.png";
            treeNode1.Tag = "new";
            treeNode1.Text = "Yeni İndirme";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "Node2";
            treeNode2.SelectedImageIndex = 0;
            treeNode2.Tag = "notcomplated";
            treeNode2.Text = "Devam Eden İndirmeler";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "Node3";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Tag = "complated";
            treeNode3.Text = "Tamamlanan İndirmeler";
            treeNode4.ImageIndex = 4;
            treeNode4.Name = "Node4";
            treeNode4.SelectedImageIndex = 4;
            treeNode4.Tag = "settings";
            treeNode4.Text = "Ayarlar";
            treeNode5.ImageIndex = 3;
            treeNode5.Name = "Node0";
            treeNode5.SelectedImageIndex = 3;
            treeNode5.Text = "İşlemler";
            this.treeMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeMenu.SelectedImageIndex = 0;
            this.treeMenu.Size = new System.Drawing.Size(244, 521);
            this.treeMenu.TabIndex = 0;
            this.treeMenu.DoubleClick += new System.EventHandler(this.treeMenu_DoubleClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "download.png");
            this.imageList.Images.SetKeyName(1, "downloaded.png");
            this.imageList.Images.SetKeyName(2, "newdownload.png");
            this.imageList.Images.SetKeyName(3, "operations.png");
            this.imageList.Images.SetKeyName(4, "settings.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 529);
            this.Controls.Add(this.tblMainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Manager V. 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.tblMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMainContainer;
        private System.Windows.Forms.TreeView treeMenu;
        private System.Windows.Forms.ImageList imageList;
    }
}