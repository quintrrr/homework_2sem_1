using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using homework_1.classes;

namespace homework_1
{
    public partial class GalleryForm: Form
    {
        private List<ImageInfo> images = new List<ImageInfo>();

        public GalleryForm()
        {
            InitializeComponent();

            
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialogSelectImage.Filter = "Файлы изображений|*.png;*.jpg;*.jpeg";
           if (openFileDialogSelectImage.ShowDialog() == DialogResult.OK)
            {
                string[] paths = openFileDialogSelectImage.FileNames;
                foreach (string path in paths)
                {
                    ImageInfo newImage = new ImageInfo(path, Path.GetFileNameWithoutExtension(path));
                    images.Add(newImage);                
                }
                UpdateListBox();
                listBoxSelectImage.SelectedItem = images.Last();
            }

        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            openFileDialogSelectFile.Filter = "Текстовые файлы|*.txt";
            if (openFileDialogSelectFile.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialogSelectFile.FileName;
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (File.Exists(parts.First()))
                    {
                        ImageInfo newImage = new ImageInfo(parts.First().Trim(), parts.Last().Trim());
                        images.Add(newImage);
                    }
                }
                UpdateListBox();
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Текстовые файлы|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                List<string> list = new List<string>();
                foreach (ImageInfo image in images)
                {
                    list.Add($"{image.Path}, {image.Title}");
                }
                File.WriteAllLines(path,list);
                MessageBox.Show("Файл сохранен");
            }
        }

        private void listBoxSelectImage_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxSelectImage.SelectedItem is ImageInfo image)
            {
                textBoxImageName.Text = image.Title;
                try
                {
                    imageBox.Image = Image.FromFile(image.Path);
                }
                catch (Exception ex)
                {
                    imageBox.Image = Image.FromFile("../../resources/errorImage.png");
                }
            }
        }

        private void UpdateListBox()
        {
            listBoxSelectImage.DataSource = null;
            listBoxSelectImage.DisplayMember = "Title";
            listBoxSelectImage.DataSource = images;
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (listBoxSelectImage.SelectedItem is ImageInfo image)
            {
                image.Title = textBoxImageName.Text;
                UpdateListBox();
            }    
        }

        private void textBoxImageName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRename_Click(sender, e);
                e.Handled = e.SuppressKeyPress = true;

            }
        }

        private void listBoxSelectImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listBoxSelectImage.IndexFromPoint(e.X, e.Y) != ListBox.NoMatches)
                {
                    listBoxSelectImage.SelectedIndex = listBoxSelectImage.IndexFromPoint(e.X, e.Y);  
                }

            }
        }

        private void deleteImage_Click(object sender, EventArgs e)
        {
            if (listBoxSelectImage.SelectedItem is ImageInfo image)
            {
                images.Remove(image);
                imageBox.Image = imageBox.InitialImage;
                textBoxImageName.Text = "";
                UpdateListBox();
                if (listBoxSelectImage.SelectedItem == null && images.Count != 0)
                {
                    listBoxSelectImage.SelectedItem = images.Last();
                    UpdateListBox();
                }
            }
        }

        private void ContextMunuListBox_Opened(object sender, EventArgs e)
        {
            deleteImage.Enabled = listBoxSelectImage.SelectedItem != null;
        }
    }
}
