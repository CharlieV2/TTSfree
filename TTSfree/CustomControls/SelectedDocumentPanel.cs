using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTSfree.CustomControls
{
    public partial class SelectedDocumentPanel : UserControl
    {
        public SelectedDocumentPanel()
        {
            InitializeComponent();
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
