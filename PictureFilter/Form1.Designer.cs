namespace PictureFilter
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BrightnessParamsPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.decreaseBright = new System.Windows.Forms.RadioButton();
            this.increaseBright = new System.Windows.Forms.RadioButton();
            this.brightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ContrastPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contrastDecrease = new System.Windows.Forms.RadioButton();
            this.contrastIncrease = new System.Windows.Forms.RadioButton();
            this.contrastPercent = new System.Windows.Forms.NumericUpDown();
            this.GammaPanel = new System.Windows.Forms.Panel();
            this.GammaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelGamma = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.BrightnessParamsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightNumericUpDown)).BeginInit();
            this.ContrastPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastPercent)).BeginInit();
            this.GammaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Обращение цвета",
            "Перевод в черно-белое",
            "Изменение яркости",
            "Изменение контрастности",
            "Гамма"});
            this.comboBox1.Location = new System.Drawing.Point(16, 371);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(24, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(372, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "очистить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(24, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(372, 54);
            this.button3.TabIndex = 5;
            this.button3.Text = "применить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PictureFilter.Properties.Resources.StartPicture;
            this.pictureBox2.Location = new System.Drawing.Point(484, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(414, 326);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PictureFilter.Properties.Resources.StartPicture;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(484, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 160);
            this.panel1.TabIndex = 6;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выбор преобразования картинки";
            // 
            // BrightnessParamsPanel
            // 
            this.BrightnessParamsPanel.Controls.Add(this.label3);
            this.BrightnessParamsPanel.Controls.Add(this.label2);
            this.BrightnessParamsPanel.Controls.Add(this.decreaseBright);
            this.BrightnessParamsPanel.Controls.Add(this.increaseBright);
            this.BrightnessParamsPanel.Controls.Add(this.brightNumericUpDown);
            this.BrightnessParamsPanel.Location = new System.Drawing.Point(459, 498);
            this.BrightnessParamsPanel.Name = "BrightnessParamsPanel";
            this.BrightnessParamsPanel.Size = new System.Drawing.Size(19, 21);
            this.BrightnessParamsPanel.TabIndex = 8;
            this.BrightnessParamsPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(175, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "на";
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
            this.ContrastPanel.Controls.Add(this.label4);
            this.ContrastPanel.Controls.Add(this.label5);
            this.ContrastPanel.Controls.Add(this.contrastDecrease);
            this.ContrastPanel.Controls.Add(this.contrastIncrease);
            this.ContrastPanel.Controls.Add(this.contrastPercent);
            this.ContrastPanel.Location = new System.Drawing.Point(459, 447);
            this.ContrastPanel.Name = "ContrastPanel";
            this.ContrastPanel.Size = new System.Drawing.Size(12, 29);
            this.ContrastPanel.TabIndex = 9;
            this.ContrastPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(175, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "на";
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
            this.GammaPanel.Location = new System.Drawing.Point(441, 389);
            this.GammaPanel.Name = "GammaPanel";
            this.GammaPanel.Size = new System.Drawing.Size(30, 33);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(932, 531);
            this.Controls.Add(this.GammaPanel);
            this.Controls.Add(this.ContrastPanel);
            this.Controls.Add(this.BrightnessParamsPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "PictureFilter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
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

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BrightnessParamsPanel;
        private System.Windows.Forms.NumericUpDown brightNumericUpDown;
        private System.Windows.Forms.RadioButton decreaseBright;
        private System.Windows.Forms.RadioButton increaseBright;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ContrastPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
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

