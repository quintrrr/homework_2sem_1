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
            openFileDialogSelectImage.Filter = "Файлы изображений|*.png;*.jpg;*.jpeg|Все файлы|*.*";
           if (openFileDialogSelectImage.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialogSelectImage.FileName;
                ImageInfo newImage = new ImageInfo(path, "Изображение");
                images.Add(newImage);
            }

        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            openFileDialogSelectFile.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            if (openFileDialogSelectFile.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialogSelectFile.FileName;
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    ImageInfo newImage = new ImageInfo(parts[0].Trim(), parts[1].Trim());
                    images.Add(newImage);
                }
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
    }
}
