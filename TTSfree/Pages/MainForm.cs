using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTSfree.CustomControls;
using TTSfree.Utilities;

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

            ExtensionComboBox.SelectedIndex = 0;
        }

        private void GetAudioButton_Click(object sender, EventArgs e)
        {
            if (OutputPathEntry.Text == "" || OutputPathEntry.Text == "Рабочий стол")
            {
                OutputPathEntry.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }

            if (Directory.Exists(OutputPathEntry.Text))
            {
                string outputFilePath;
                string tempFilePath;
                string text;

                foreach (SelectedDocumentPanel documentPanel in DocumentsPanel.Controls)
                {
                    outputFilePath = Path.Combine(OutputPathEntry.Text, documentPanel.DocumentName + ExtensionComboBox.Text);
                    tempFilePath = Path.Combine(OutputPathEntry.Text, documentPanel.DocumentName + "_temp" + ExtensionComboBox.Text);
                    text = FileReader.GetText(documentPanel.DocumentPath);

                    TextToSpeech textToSpeech = new TextToSpeech(text, outputFilePath, tempFilePath, VolumeTrackBar.Value, RateTrackBar.Value);

                    Task.Run(() => textToSpeech.CreateAudioFile());
                }
            }
            else
            {
                MessageBox.Show("Указанная директория не найдена.", "Директория не найдена", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void UploadPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void UploadPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string extension;
            bool isDublicate = false;

            if (files.Length > 0)
            {
                foreach (string file in files)
                {
                    isDublicate = false;
                    extension = Path.GetExtension(file);

                    if (extension == ".doc" || extension == ".docx" || extension == ".txt")
                    {
                        foreach (SelectedDocumentPanel documentPanel in DocumentsPanel.Controls)
                        {
                            if (documentPanel.DocumentPath == file)
                            {
                                isDublicate = true;
                            }
                        }


                        if (isDublicate)
                        {
                            MessageBox.Show("Файл уже добавлен: " + Path.GetFileName(file), "Файл уже добавлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            SelectedDocumentPanel selectedDocument = new SelectedDocumentPanel(file);
                            DocumentsPanel.Controls.Add(selectedDocument);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Недопустимый файл: " + Path.GetFileName(file), "Недопустимый файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Выберите диекторию для сохранения аудио";

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                OutputPathEntry.Text = folderBrowserDialog.SelectedPath;
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
