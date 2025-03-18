namespace homework_1
{
    partial class Form1
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
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.textBoxImageName = new System.Windows.Forms.TextBox();
            this.listBoxSelectImage = new System.Windows.Forms.ListBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.openFileDialogSelectImage = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnRename = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(23, 366);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(128, 36);
            this.btnLoadFromFile.TabIndex = 0;
            this.btnLoadFromFile.Text = "загрузить из файла";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(23, 407);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(128, 36);
            this.btnSaveToFile.TabIndex = 1;
            this.btnSaveToFile.Text = "сохранить ";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(168, 20);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(561, 391);
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            // 
            // textBoxImageName
            // 
            this.textBoxImageName.Location = new System.Drawing.Point(168, 423);
            this.textBoxImageName.Name = "textBoxImageName";
            this.textBoxImageName.Size = new System.Drawing.Size(436, 20);
            this.textBoxImageName.TabIndex = 3;
            // 
            // listBoxSelectImage
            // 
            this.listBoxSelectImage.FormattingEnabled = true;
            this.listBoxSelectImage.Location = new System.Drawing.Point(23, 20);
            this.listBoxSelectImage.Name = "listBoxSelectImage";
            this.listBoxSelectImage.Size = new System.Drawing.Size(127, 290);
            this.listBoxSelectImage.TabIndex = 4;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(23, 325);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(128, 36);
            this.btnLoadImage.TabIndex = 5;
            this.btnLoadImage.Text = "загрузить изображние";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // openFileDialogSelectImage
            // 
            this.openFileDialogSelectImage.FileName = "openFileDialog1";
            // 
            // openFileDialogSelectFile
            // 
            this.openFileDialogSelectFile.FileName = "openFileDialog1";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(610, 419);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(119, 26);
            this.btnRename.TabIndex = 6;
            this.btnRename.Text = "переименовать";
            this.btnRename.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 452);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.listBoxSelectImage);
            this.Controls.Add(this.textBoxImageName);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnLoadFromFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
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
    }
}

