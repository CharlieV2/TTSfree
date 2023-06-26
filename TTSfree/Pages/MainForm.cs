using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTSfree
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            UploadPanel.AllowDrop = true;

            UploadPanel.DragEnter += UploadPanel_DragEnter;
            UploadPanel.DragDrop += UploadPanel_DragDrop;
        }





        private void UploadPanel_DragEnter(object sender, DragEventArgs e)
        {
            // Проверяем, что перетаскиваемые данные являются изображением
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void UploadPanel_DragDrop(object sender, DragEventArgs e)
        {
            // Получаем перетаскиваемые данные
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Проверяем, что есть хотя бы один файл
            if (files.Length > 0)
            {
                // Загружаем изображение из первого файла
                Image image = Image.FromFile(files[0]);

                // Отображаем изображение в PictureBox
                UploadPanel.Image = image;
            }
        }














        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            VolumeLabel.Text = VolumeTrackBar.Value.ToString();
        }

        private void RateTrackBar_Scroll(object sender, EventArgs e)
        {
            RateLabel.Text = RateTrackBar.Value.ToString();
        }
    }
}
