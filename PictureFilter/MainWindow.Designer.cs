namespace PictureFilter
{
    partial class MainWindow
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
            this.loadButton = new System.Windows.Forms.Button();
            this.openPictureFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.transformationSelectComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.transformedPictureBox = new System.Windows.Forms.PictureBox();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.transformationsTitleLabel = new System.Windows.Forms.Label();
            this.BrightnessParamsPanel = new System.Windows.Forms.Panel();
            this.brightnessPercentLabel = new System.Windows.Forms.Label();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.decreaseBright = new System.Windows.Forms.RadioButton();
            this.increaseBright = new System.Windows.Forms.RadioButton();
            this.brightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ContrastPanel = new System.Windows.Forms.Panel();
            this.contrastPercentLabel = new System.Windows.Forms.Label();
            this.contrastLabel = new System.Windows.Forms.Label();
            this.contrastDecrease = new System.Windows.Forms.RadioButton();
            this.contrastIncrease = new System.Windows.Forms.RadioButton();
            this.contrastPercent = new System.Windows.Forms.NumericUpDown();
            this.GammaPanel = new System.Windows.Forms.Panel();
            this.GammaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelGamma = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.transformedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            this.controlsPanel.SuspendLayout();
            this.BrightnessParamsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightNumericUpDown)).BeginInit();
            this.ContrastPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastPercent)).BeginInit();
            this.GammaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(24, 3);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(73, 30);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openPictureFileDialog
            // 
            this.openPictureFileDialog.FileName = "openFileDialog1";
            // 
            // transformationSelectComboBox
            // 
            this.transformationSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transformationSelectComboBox.FormattingEnabled = true;
            this.transformationSelectComboBox.Items.AddRange(new object[] {
            "Обращение цвета",
            "Перевод в черно-белое",
            "Изменение яркости",
            "Изменение контрастности",
            "Гамма"});
            this.transformationSelectComboBox.Location = new System.Drawing.Point(16, 371);
            this.transformationSelectComboBox.Name = "transformationSelectComboBox";
            this.transformationSelectComboBox.Size = new System.Drawing.Size(295, 21);
            this.transformationSelectComboBox.TabIndex = 3;
            this.transformationSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(24, 49);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(372, 43);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applyButton.Location = new System.Drawing.Point(24, 103);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(372, 54);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "применить";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // transformedPictureBox
            // 
            this.transformedPictureBox.Image = global::PictureFilter.Properties.Resources.StartPicture;
            this.transformedPictureBox.Location = new System.Drawing.Point(484, 12);
            this.transformedPictureBox.Name = "transformedPictureBox";
            this.transformedPictureBox.Size = new System.Drawing.Size(414, 326);
            this.transformedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.transformedPictureBox.TabIndex = 2;
            this.transformedPictureBox.TabStop = false;
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.Image = global::PictureFilter.Properties.Resources.StartPicture;
            this.originalPictureBox.Location = new System.Drawing.Point(12, 12);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(414, 326);
            this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originalPictureBox.TabIndex = 0;
            this.originalPictureBox.TabStop = false;
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.saveButton);
            this.controlsPanel.Controls.Add(this.loadButton);
            this.controlsPanel.Controls.Add(this.applyButton);
            this.controlsPanel.Controls.Add(this.clearButton);
            this.controlsPanel.Location = new System.Drawing.Point(484, 344);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(414, 160);
            this.controlsPanel.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(109, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(73, 30);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // transformationsTitleLabel
            // 
            this.transformationsTitleLabel.AutoSize = true;
            this.transformationsTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transformationsTitleLabel.Location = new System.Drawing.Point(12, 344);
            this.transformationsTitleLabel.Name = "transformationsTitleLabel";
            this.transformationsTitleLabel.Size = new System.Drawing.Size(310, 24);
            this.transformationsTitleLabel.TabIndex = 7;
            this.transformationsTitleLabel.Text = "Выбор преобразования картинки";
            // 
            // BrightnessParamsPanel
            // 
            this.BrightnessParamsPanel.Controls.Add(this.brightnessPercentLabel);
            this.BrightnessParamsPanel.Controls.Add(this.brightnessLabel);
            this.BrightnessParamsPanel.Controls.Add(this.decreaseBright);
            this.BrightnessParamsPanel.Controls.Add(this.increaseBright);
            this.BrightnessParamsPanel.Controls.Add(this.brightNumericUpDown);
            this.BrightnessParamsPanel.Location = new System.Drawing.Point(458, 492);
            this.BrightnessParamsPanel.Name = "BrightnessParamsPanel";
            this.BrightnessParamsPanel.Size = new System.Drawing.Size(11, 27);
            this.BrightnessParamsPanel.TabIndex = 8;
            this.BrightnessParamsPanel.Visible = false;
            // 
            // brightnessPercentLabel
            // 
            this.brightnessPercentLabel.AutoSize = true;
            this.brightnessPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brightnessPercentLabel.Location = new System.Drawing.Point(175, 47);
            this.brightnessPercentLabel.Name = "brightnessPercentLabel";
            this.brightnessPercentLabel.Size = new System.Drawing.Size(32, 26);
            this.brightnessPercentLabel.TabIndex = 4;
            this.brightnessPercentLabel.Text = "%";
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(86, 52);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(19, 13);
            this.brightnessLabel.TabIndex = 3;
            this.brightnessLabel.Text = "на";
            // 
            // decreaseBright
            // 
            this.decreaseBright.AutoSize = true;
            this.decreaseBright.Location = new System.Drawing.Point(155, 13);
            this.decreaseBright.Name = "decreaseBright";
            this.decreaseBright.Size = new System.Drawing.Size(125, 17);
            this.decreaseBright.TabIndex = 2;
            this.decreaseBright.Text = "уменьшить яркость";
            this.decreaseBright.UseVisualStyleBackColor = true;
            this.decreaseBright.CheckedChanged += new System.EventHandler(this.decreaseBright_CheckedChanged);
            // 
            // increaseBright
            // 
            this.increaseBright.AutoSize = true;
            this.increaseBright.Checked = true;
            this.increaseBright.Location = new System.Drawing.Point(12, 13);
            this.increaseBright.Name = "increaseBright";
            this.increaseBright.Size = new System.Drawing.Size(120, 17);
            this.increaseBright.TabIndex = 1;
            this.increaseBright.TabStop = true;
            this.increaseBright.Text = "увеличить яркость";
            this.increaseBright.UseVisualStyleBackColor = true;
            this.increaseBright.CheckedChanged += new System.EventHandler(this.increaseBright_CheckedChanged);
            // 
            // brightNumericUpDown
            // 
            this.brightNumericUpDown.Location = new System.Drawing.Point(123, 50);
            this.brightNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.brightNumericUpDown.Name = "brightNumericUpDown";
            this.brightNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.brightNumericUpDown.TabIndex = 0;
            this.brightNumericUpDown.ValueChanged += new System.EventHandler(this.brightNumericUpDown_ValueChanged);
            // 
            // ContrastPanel
            // 
            this.ContrastPanel.Controls.Add(this.contrastPercentLabel);
            this.ContrastPanel.Controls.Add(this.contrastLabel);
            this.ContrastPanel.Controls.Add(this.contrastDecrease);
            this.ContrastPanel.Controls.Add(this.contrastIncrease);
            this.ContrastPanel.Controls.Add(this.contrastPercent);
            this.ContrastPanel.Location = new System.Drawing.Point(458, 433);
            this.ContrastPanel.Name = "ContrastPanel";
            this.ContrastPanel.Size = new System.Drawing.Size(11, 33);
            this.ContrastPanel.TabIndex = 9;
            this.ContrastPanel.Visible = false;
            // 
            // label4
            // 
            this.contrastPercentLabel.AutoSize = true;
            this.contrastPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contrastPercentLabel.Location = new System.Drawing.Point(175, 47);
            this.contrastPercentLabel.Name = "label4";
            this.contrastPercentLabel.Size = new System.Drawing.Size(32, 26);
            this.contrastPercentLabel.TabIndex = 4;
            this.contrastPercentLabel.Text = "%";
            // 
            // contrastLabel
            // 
            this.contrastLabel.AutoSize = true;
            this.contrastLabel.Location = new System.Drawing.Point(86, 52);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(19, 13);
            this.contrastLabel.TabIndex = 3;
            this.contrastLabel.Text = "на";
            // 
            // contrastDecrease
            // 
            this.contrastDecrease.AutoSize = true;
            this.contrastDecrease.Location = new System.Drawing.Point(155, 13);
            this.contrastDecrease.Name = "contrastDecrease";
            this.contrastDecrease.Size = new System.Drawing.Size(130, 17);
            this.contrastDecrease.TabIndex = 2;
            this.contrastDecrease.Text = "уменьшить контраст";
            this.contrastDecrease.UseVisualStyleBackColor = true;
            this.contrastDecrease.CheckedChanged += new System.EventHandler(this.contrastDecrease_CheckedChanged);
            // 
            // contrastIncrease
            // 
            this.contrastIncrease.AutoSize = true;
            this.contrastIncrease.Checked = true;
            this.contrastIncrease.Location = new System.Drawing.Point(12, 13);
            this.contrastIncrease.Name = "contrastIncrease";
            this.contrastIncrease.Size = new System.Drawing.Size(125, 17);
            this.contrastIncrease.TabIndex = 1;
            this.contrastIncrease.TabStop = true;
            this.contrastIncrease.Text = "увеличить контраст";
            this.contrastIncrease.UseVisualStyleBackColor = true;
            this.contrastIncrease.CheckedChanged += new System.EventHandler(this.contrastIncrease_CheckedChanged);
            // 
            // contrastPercent
            // 
            this.contrastPercent.Location = new System.Drawing.Point(123, 50);
            this.contrastPercent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.contrastPercent.Name = "contrastPercent";
            this.contrastPercent.Size = new System.Drawing.Size(46, 20);
            this.contrastPercent.TabIndex = 0;
            this.contrastPercent.ValueChanged += new System.EventHandler(this.contrastPercent_ValueChanged);
            // 
            // GammaPanel
            // 
            this.GammaPanel.Controls.Add(this.GammaTextBox);
            this.GammaPanel.Controls.Add(this.labelGamma);
            this.GammaPanel.Location = new System.Drawing.Point(458, 393);
            this.GammaPanel.Name = "GammaPanel";
            this.GammaPanel.Size = new System.Drawing.Size(11, 29);
            this.GammaPanel.TabIndex = 10;
            this.GammaPanel.Visible = false;
            // 
            // GammaTextBox
            // 
            this.GammaTextBox.Location = new System.Drawing.Point(115, 53);
            this.GammaTextBox.Mask = "00.00";
            this.GammaTextBox.Name = "GammaTextBox";
            this.GammaTextBox.Size = new System.Drawing.Size(36, 20);
            this.GammaTextBox.TabIndex = 2;
            this.GammaTextBox.TextChanged += new System.EventHandler(this.GammaTextBox_TextChanged);
            // 
            // labelGamma
            // 
            this.labelGamma.AutoSize = true;
            this.labelGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGamma.Location = new System.Drawing.Point(39, 20);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(196, 20);
            this.labelGamma.TabIndex = 1;
            this.labelGamma.Text = "гамма параметр равен 1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(932, 531);
            this.Controls.Add(this.GammaPanel);
            this.Controls.Add(this.ContrastPanel);
            this.Controls.Add(this.BrightnessParamsPanel);
            this.Controls.Add(this.transformationsTitleLabel);
            this.Controls.Add(this.transformationSelectComboBox);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.transformedPictureBox);
            this.Controls.Add(this.originalPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "PictureFilter";
            ((System.ComponentModel.ISupportInitialize)(this.transformedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            this.BrightnessParamsPanel.ResumeLayout(false);
            this.BrightnessParamsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightNumericUpDown)).EndInit();
            this.ContrastPanel.ResumeLayout(false);
            this.ContrastPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastPercent)).EndInit();
            this.GammaPanel.ResumeLayout(false);
            this.GammaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.OpenFileDialog openPictureFileDialog;
        private System.Windows.Forms.PictureBox transformedPictureBox;
        private System.Windows.Forms.ComboBox transformationSelectComboBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Label transformationsTitleLabel;
        private System.Windows.Forms.Panel BrightnessParamsPanel;
        private System.Windows.Forms.NumericUpDown brightNumericUpDown;
        private System.Windows.Forms.RadioButton decreaseBright;
        private System.Windows.Forms.RadioButton increaseBright;
        private System.Windows.Forms.Label brightnessPercentLabel;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Panel ContrastPanel;
        private System.Windows.Forms.Label contrastPercentLabel;
        private System.Windows.Forms.Label contrastLabel;
        private System.Windows.Forms.RadioButton contrastDecrease;
        private System.Windows.Forms.RadioButton contrastIncrease;
        private System.Windows.Forms.NumericUpDown contrastPercent;
        private System.Windows.Forms.Panel GammaPanel;
        private System.Windows.Forms.Label labelGamma;
        private System.Windows.Forms.MaskedTextBox GammaTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

