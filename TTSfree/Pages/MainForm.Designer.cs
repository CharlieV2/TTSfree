namespace TTSfree
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DocumentsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.UploadPanel = new System.Windows.Forms.PictureBox();
            this.OutputPathEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.GetAudioButton = new System.Windows.Forms.Button();
            this.ExtensionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RateTrackBar = new System.Windows.Forms.TrackBar();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.RateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UploadPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // DocumentsPanel
            // 
            this.DocumentsPanel.AutoScroll = true;
            this.DocumentsPanel.Location = new System.Drawing.Point(12, 73);
            this.DocumentsPanel.Name = "DocumentsPanel";
            this.DocumentsPanel.Size = new System.Drawing.Size(360, 281);
            this.DocumentsPanel.TabIndex = 1;
            // 
            // UploadPanel
            // 
            this.UploadPanel.Image = global::TTSfree.Properties.Resources.upload_panel;
            this.UploadPanel.Location = new System.Drawing.Point(12, 12);
            this.UploadPanel.Name = "UploadPanel";
            this.UploadPanel.Size = new System.Drawing.Size(360, 55);
            this.UploadPanel.TabIndex = 0;
            this.UploadPanel.TabStop = false;
            // 
            // OutputPathEntry
            // 
            this.OutputPathEntry.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.OutputPathEntry.Location = new System.Drawing.Point(12, 380);
            this.OutputPathEntry.Name = "OutputPathEntry";
            this.OutputPathEntry.Size = new System.Drawing.Size(291, 23);
            this.OutputPathEntry.TabIndex = 2;
            this.OutputPathEntry.TabStop = false;
            this.OutputPathEntry.Text = "Рабочий стол";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label1.Location = new System.Drawing.Point(12, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Место сохранения";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrowseButton.Location = new System.Drawing.Point(309, 380);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(63, 25);
            this.BrowseButton.TabIndex = 4;
            this.BrowseButton.TabStop = false;
            this.BrowseButton.Text = "Обзор...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            // 
            // GetAudioButton
            // 
            this.GetAudioButton.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetAudioButton.Location = new System.Drawing.Point(526, 380);
            this.GetAudioButton.Name = "GetAudioButton";
            this.GetAudioButton.Size = new System.Drawing.Size(80, 25);
            this.GetAudioButton.TabIndex = 5;
            this.GetAudioButton.TabStop = false;
            this.GetAudioButton.Text = "Озвучить";
            this.GetAudioButton.UseVisualStyleBackColor = true;
            // 
            // ExtensionComboBox
            // 
            this.ExtensionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExtensionComboBox.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtensionComboBox.FormattingEnabled = true;
            this.ExtensionComboBox.Items.AddRange(new object[] {
            ".wav",
            ".mp3"});
            this.ExtensionComboBox.Location = new System.Drawing.Point(486, 46);
            this.ExtensionComboBox.Name = "ExtensionComboBox";
            this.ExtensionComboBox.Size = new System.Drawing.Size(69, 25);
            this.ExtensionComboBox.TabIndex = 6;
            this.ExtensionComboBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label2.Location = new System.Drawing.Point(390, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Расширение";
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.Location = new System.Drawing.Point(473, 90);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(104, 45);
            this.VolumeTrackBar.TabIndex = 8;
            this.VolumeTrackBar.TabStop = false;
            this.VolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeTrackBar.Value = 100;
            this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label3.Location = new System.Drawing.Point(390, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Громкость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label4.Location = new System.Drawing.Point(390, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Скорость";
            // 
            // RateTrackBar
            // 
            this.RateTrackBar.LargeChange = 1;
            this.RateTrackBar.Location = new System.Drawing.Point(473, 141);
            this.RateTrackBar.Minimum = -10;
            this.RateTrackBar.Name = "RateTrackBar";
            this.RateTrackBar.Size = new System.Drawing.Size(104, 45);
            this.RateTrackBar.TabIndex = 10;
            this.RateTrackBar.TabStop = false;
            this.RateTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RateTrackBar.Scroll += new System.EventHandler(this.RateTrackBar_Scroll);
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.VolumeLabel.Location = new System.Drawing.Point(577, 90);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(30, 20);
            this.VolumeLabel.TabIndex = 12;
            this.VolumeLabel.Text = "100";
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.RateLabel.Location = new System.Drawing.Point(577, 141);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(17, 20);
            this.RateLabel.TabIndex = 13;
            this.RateLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 415);
            this.Controls.Add(this.RateLabel);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RateTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VolumeTrackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExtensionComboBox);
            this.Controls.Add(this.GetAudioButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputPathEntry);
            this.Controls.Add(this.DocumentsPanel);
            this.Controls.Add(this.UploadPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "TTSfree (Текст в речь)";
            ((System.ComponentModel.ISupportInitialize)(this.UploadPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UploadPanel;
        private System.Windows.Forms.FlowLayoutPanel DocumentsPanel;
        private System.Windows.Forms.TextBox OutputPathEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button GetAudioButton;
        private System.Windows.Forms.ComboBox ExtensionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar RateTrackBar;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label RateLabel;
    }
}

