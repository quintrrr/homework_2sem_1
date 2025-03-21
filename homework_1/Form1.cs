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
    public partial class Form1: Form
    {
        private List<ImageInfo> images = new List<ImageInfo>();

        public Form1()
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
                try
                {
                    imageBox.Image = Image.FromFile(image.Path);
                    textBoxImageName.Text = image.Title;
                }
                catch (Exception ex)
                {
                    imageBox.Image = Image.FromFile("../../resources/errorImage.png");
                    MessageBox.Show("Путь не найден");
                }
            }
        }

        private void UpdateListBox()
        {
            listBoxSelectImage.DataSource = null;
            listBoxSelectImage.DataSource = images;
            listBoxSelectImage.DisplayMember = "Title";
            listBoxSelectImage.ValueMember = "Path";
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


    }
}
