namespace PhotoRenamer
{
    partial class MainForm
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
            if (disposing && (components != null)) {
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.list = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbLoadImages = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFirstImage = new System.Windows.Forms.ToolStripButton();
            this.tsbPrevImage = new System.Windows.Forms.ToolStripButton();
            this.tsbNextImage = new System.Windows.Forms.ToolStripButton();
            this.tsbLastImage = new System.Windows.Forms.ToolStripButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSizeToFit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.newName = new PhotoRenamer.ToolStripSpringTextBox();
            this.tsbAccept = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.progressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openDlg = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.list);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(731, 445);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 0;
            // 
            // list
            // 
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.FormattingEnabled = true;
            this.list.IntegralHeight = false;
            this.list.Location = new System.Drawing.Point(0, 25);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(150, 420);
            this.list.TabIndex = 0;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoadImages,
            this.toolStripSeparator1,
            this.tsbFirstImage,
            this.tsbPrevImage,
            this.tsbNextImage,
            this.tsbLastImage});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(150, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbLoadImages
            // 
            this.tsbLoadImages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLoadImages.Image = global::PhotoRenamer.Properties.Resources.folder_image;
            this.tsbLoadImages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadImages.Name = "tsbLoadImages";
            this.tsbLoadImages.Size = new System.Drawing.Size(23, 22);
            this.tsbLoadImages.Text = "Load Images...";
            this.tsbLoadImages.Click += new System.EventHandler(this.tsbLoadImages_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFirstImage
            // 
            this.tsbFirstImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFirstImage.Enabled = false;
            this.tsbFirstImage.Image = global::PhotoRenamer.Properties.Resources.resultset_first;
            this.tsbFirstImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFirstImage.Name = "tsbFirstImage";
            this.tsbFirstImage.Size = new System.Drawing.Size(23, 22);
            this.tsbFirstImage.Text = "First Image";
            this.tsbFirstImage.Click += new System.EventHandler(this.tsbFirstImage_Click);
            // 
            // tsbPrevImage
            // 
            this.tsbPrevImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrevImage.Enabled = false;
            this.tsbPrevImage.Image = global::PhotoRenamer.Properties.Resources.resultset_previous;
            this.tsbPrevImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrevImage.Name = "tsbPrevImage";
            this.tsbPrevImage.Size = new System.Drawing.Size(23, 22);
            this.tsbPrevImage.Text = "Previous Image";
            this.tsbPrevImage.Click += new System.EventHandler(this.tsbPrevImage_Click);
            // 
            // tsbNextImage
            // 
            this.tsbNextImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNextImage.Enabled = false;
            this.tsbNextImage.Image = global::PhotoRenamer.Properties.Resources.resultset_next;
            this.tsbNextImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNextImage.Name = "tsbNextImage";
            this.tsbNextImage.Size = new System.Drawing.Size(23, 22);
            this.tsbNextImage.Text = "Next Image";
            this.tsbNextImage.Click += new System.EventHandler(this.tsbNextImage_Click);
            // 
            // tsbLastImage
            // 
            this.tsbLastImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLastImage.Enabled = false;
            this.tsbLastImage.Image = global::PhotoRenamer.Properties.Resources.resultset_last;
            this.tsbLastImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLastImage.Name = "tsbLastImage";
            this.tsbLastImage.Size = new System.Drawing.Size(23, 22);
            this.tsbLastImage.Text = "Last Image";
            this.tsbLastImage.Click += new System.EventHandler(this.tsbLastImage_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.ErrorImage = global::PhotoRenamer.Properties.Resources.notfound;
            this.pictureBox.Location = new System.Drawing.Point(0, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(577, 398);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSizeToFit,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.newName,
            this.tsbAccept,
            this.toolStripSeparator3,
            this.tsbAbout});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(577, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbSizeToFit
            // 
            this.tsbSizeToFit.Checked = true;
            this.tsbSizeToFit.CheckOnClick = true;
            this.tsbSizeToFit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbSizeToFit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSizeToFit.Image = global::PhotoRenamer.Properties.Resources.arrow_in;
            this.tsbSizeToFit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSizeToFit.Name = "tsbSizeToFit";
            this.tsbSizeToFit.Size = new System.Drawing.Size(23, 22);
            this.tsbSizeToFit.Text = "Size Images to Fit";
            this.tsbSizeToFit.Click += new System.EventHandler(this.tsbSizeToFit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(145, 22);
            this.toolStripLabel1.Text = "New name (no extension):";
            // 
            // newName
            // 
            this.newName.Enabled = false;
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(276, 25);
            this.newName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newName_KeyDown);
            this.newName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newName_KeyPress);
            this.newName.TextChanged += new System.EventHandler(this.newName_TextChanged);
            // 
            // tsbAccept
            // 
            this.tsbAccept.Enabled = false;
            this.tsbAccept.Image = global::PhotoRenamer.Properties.Resources.accept;
            this.tsbAccept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAccept.Name = "tsbAccept";
            this.tsbAccept.Size = new System.Drawing.Size(64, 22);
            this.tsbAccept.Text = "Accept";
            this.tsbAccept.Click += new System.EventHandler(this.tsbAccept_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAbout
            // 
            this.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAbout.Image = global::PhotoRenamer.Properties.Resources.information;
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(23, 22);
            this.tsbAbout.Text = "About Photo Renamer...";
            this.tsbAbout.Click += new System.EventHandler(this.tsbAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.progressLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(577, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // progressLabel
            // 
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(103, 17);
            this.progressLabel.Text = "No images loaded";
            // 
            // openDlg
            // 
            this.openDlg.Filter = "Image files (*.jpg;*.jpeg;*.gif;*.png;*.bmp)|*.jpg;*.jpeg;*.gif;*.png;*.bmp|All f" +
    "iles (*.*)|*.*";
            this.openDlg.Multiselect = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 445);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Photo Renamer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbLoadImages;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbPrevImage;
        private System.Windows.Forms.ToolStripButton tsbFirstImage;
        private System.Windows.Forms.ToolStripButton tsbNextImage;
        private System.Windows.Forms.ToolStripButton tsbLastImage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel progressLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openDlg;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private PhotoRenamer.ToolStripSpringTextBox newName;
        private System.Windows.Forms.ToolStripButton tsbAccept;
        private System.Windows.Forms.ToolStripButton tsbSizeToFit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbAbout;
    }
}

