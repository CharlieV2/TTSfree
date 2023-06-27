using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TTSfree.CustomControls
{
    public partial class SelectedDocumentPanel : UserControl
    {

        public string DocumentName { get; set; }
        public string DocumentPath { get; set; }
        public string DocumentExtension { get; set; }

        private Dictionary<string, System.Drawing.Image> ImageDictionary;

        public SelectedDocumentPanel()
        {
            InitializeComponent();
        }

        public SelectedDocumentPanel(string path)
        {
            InitializeComponent();
            InitializeImageDictionary();

            DocumentPath = path;
            DocumentName = Path.GetFileNameWithoutExtension(path);
            DocumentExtension = Path.GetExtension(path);

            FillPanel();
        }

        private void InitializeImageDictionary()
        {
            ImageDictionary = new Dictionary<string, System.Drawing.Image>()
            {
                { ".docx", Properties.Resources.docx_extension },
                { ".doc", Properties.Resources.doc_extension },
                { ".txt", Properties.Resources.txt_extension }
            };

        }

        private void FillPanel()
        {
            FileNameLabel.Text = DocumentName;

            FileIcon.Image = ImageDictionary[DocumentExtension];            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            Dispose();
        }

        private void CancelButton_MouseEnter(object sender, EventArgs e)
        {
            CancelButton.Image = Properties.Resources.cancel_active;
        }

        private void CancelButton_MouseLeave(object sender, EventArgs e)
        {
            CancelButton.Image = Properties.Resources.cancel_default;
        }
    }
}
