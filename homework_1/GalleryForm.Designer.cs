namespace homework_1
{
    partial class GalleryForm
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
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.textBoxImageName = new System.Windows.Forms.TextBox();
            this.listBoxSelectImage = new System.Windows.Forms.ListBox();
            this.ContextMenuListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteImage = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.openFileDialogSelectImage = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnRename = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.ContextMenuListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadFromFile.Location = new System.Drawing.Point(23, 375);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(142, 36);
            this.btnLoadFromFile.TabIndex = 0;
            this.btnLoadFromFile.Text = "загрузить из файла";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveToFile.Location = new System.Drawing.Point(23, 416);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(142, 36);
            this.btnSaveToFile.TabIndex = 1;
            this.btnSaveToFile.Text = "сохранить ";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // imageBox
            // 
            this.imageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox.Location = new System.Drawing.Point(182, 20);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(547, 400);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            // 
            // textBoxImageName
            // 
            this.textBoxImageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImageName.Location = new System.Drawing.Point(182, 432);
            this.textBoxImageName.MaxLength = 52;
            this.textBoxImageName.Name = "textBoxImageName";
            this.textBoxImageName.Size = new System.Drawing.Size(422, 20);
            this.textBoxImageName.TabIndex = 3;
            this.textBoxImageName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxImageName_KeyDown);
            // 
            // listBoxSelectImage
            // 
            this.listBoxSelectImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxSelectImage.ContextMenuStrip = this.ContextMenuListBox;
            this.listBoxSelectImage.FormattingEnabled = true;
            this.listBoxSelectImage.HorizontalScrollbar = true;
            this.listBoxSelectImage.Location = new System.Drawing.Point(23, 20);
            this.listBoxSelectImage.Name = "listBoxSelectImage";
            this.listBoxSelectImage.Size = new System.Drawing.Size(142, 303);
            this.listBoxSelectImage.TabIndex = 4;
            this.listBoxSelectImage.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectImage_SelectedIndexChanged);
            this.listBoxSelectImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxSelectImage_MouseDown);
            // 
            // ContextMenuListBox
            // 
            this.ContextMenuListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteImage});
            this.ContextMenuListBox.Name = "ContextMunuListBox";
            this.ContextMenuListBox.Size = new System.Drawing.Size(196, 26);
            this.ContextMenuListBox.Opened += new System.EventHandler(this.ContextMunuListBox_Opened);
            // 
            // deleteImage
            // 
            this.deleteImage.Name = "deleteImage";
            this.deleteImage.Size = new System.Drawing.Size(195, 22);
            this.deleteImage.Text = "Удалить изображение";
            this.deleteImage.Click += new System.EventHandler(this.deleteImage_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadImage.Location = new System.Drawing.Point(23, 334);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(142, 36);
            this.btnLoadImage.TabIndex = 5;
            this.btnLoadImage.Text = "загрузить изображние";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // openFileDialogSelectImage
            // 
            this.openFileDialogSelectImage.FileName = "openFileDialog1";
            this.openFileDialogSelectImage.Multiselect = true;
            // 
            // openFileDialogSelectFile
            // 
            this.openFileDialogSelectFile.FileName = "openFileDialog1";
            // 
            // btnRename
            // 
            this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRename.Location = new System.Drawing.Point(610, 428);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(119, 26);
            this.btnRename.TabIndex = 6;
            this.btnRename.Text = "переименовать";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // GalleryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 461);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.listBoxSelectImage);
            this.Controls.Add(this.textBoxImageName);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnLoadFromFile);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 360);
            this.Name = "GalleryForm";
            this.Text = "Галерея";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ContextMenuListBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.TextBox textBoxImageName;
        private System.Windows.Forms.ListBox listBoxSelectImage;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogSelectImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogSelectFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnRename;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip ContextMenuListBox;
        private System.Windows.Forms.ToolStripMenuItem deleteImage;
    }
}

