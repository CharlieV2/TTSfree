namespace TTSfree.CustomControls
{
    partial class SelectedDocumentPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.PictureBox();
            this.FileIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileNameLabel.Location = new System.Drawing.Point(39, 7);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(94, 21);
            this.FileNameLabel.TabIndex = 2;
            this.FileNameLabel.Text = "Имя файла";
            // 
            // CancelButton
            // 
            this.CancelButton.Image = global::TTSfree.Properties.Resources.cancel_default;
            this.CancelButton.Location = new System.Drawing.Point(296, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(30, 30);
            this.CancelButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CancelButton.TabIndex = 3;
            this.CancelButton.TabStop = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            this.CancelButton.MouseEnter += new System.EventHandler(this.CancelButton_MouseEnter);
            this.CancelButton.MouseLeave += new System.EventHandler(this.CancelButton_MouseLeave);
            // 
            // FileIcon
            // 
            this.FileIcon.Location = new System.Drawing.Point(3, 2);
            this.FileIcon.Name = "FileIcon";
            this.FileIcon.Size = new System.Drawing.Size(32, 32);
            this.FileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FileIcon.TabIndex = 0;
            this.FileIcon.TabStop = false;
            // 
            // SelectedDocumentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FileIcon);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FileNameLabel);
            this.Name = "SelectedDocumentPanel";
            this.Size = new System.Drawing.Size(325, 38);
            ((System.ComponentModel.ISupportInitialize)(this.CancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FileIcon;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.PictureBox CancelButton;
    }
}
