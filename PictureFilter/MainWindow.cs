using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureFilter
{
    public partial class MainWindow : Form
    {
        public UserInterfaceController UIController { get; set; }

        private const int PanelX = 16;
        private const int PanelY = 398;
        private const int PanelWidth = 295;
        private const int PanelHeight = 129;

        private Panel currentPanel;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Init()
        {
            UIController.OpenNewImage(originalPictureBox.Image);
            transformationSelectComboBox.SelectedIndex = 0;
        }


        public void OnOpenFailed()
        {
            MessageBox.Show("Не удалось загрузить картинку из файла.");
        }

        public void OnTransformationFailed()
        {
            MessageBox.Show("Не удалось преобразовать картинку, возможно она имеет формат с индексированными пикселями. " +
                "Попробуйте перевести ее в другой формат. Для этого нажмите сохранить и выберите нужный формат сохранения.");
            UIController.ClearTransform();
            controlsPanel.Visible = true;
        }


        private Panel GetParamsPanel(int index)
        {
            if (index == 2)
            {
                return BrightnessParamsPanel;
            }

            if (index == 3)
            {
                return ContrastPanel;
            }

            if (index == 4)
            {
                return GammaPanel;
            }

            return null;
        }


        public void ShowTransformedPicture(Image picture)
        {
            transformedPictureBox.Image = (Image)picture.Clone();
            DrawBorder(transformedPictureBox.Image, Color.Green);
            controlsPanel.Visible = true;
        }

        public void OnImageSelected(Image picture)
        {
            originalPictureBox.Image = (Image)picture.Clone();
            transformedPictureBox.Image = (Image)picture.Clone();
            DrawBorder(originalPictureBox.Image, Color.Green);
            DrawBorder(transformedPictureBox.Image, Color.Green);
        }

        private void DrawBorder(Image picture, Color borderColor)
        {
            const float penWidthFactor = 0.00002f;
            const float minimumPenWidth = 2f;
            float area = picture.Width * picture.Height;
            float penWidth = area * penWidthFactor;
            if (penWidth < minimumPenWidth)
            {
                penWidth = minimumPenWidth;
            }

            try
            {
                using (Graphics painter = Graphics.FromImage(picture))
                {
                    using (var pen = new Pen(borderColor, penWidth))
                    {
                        Rectangle rec = new Rectangle(0, 0, picture.Width, picture.Height);
                        painter.DrawRectangle(pen, rec);
                    }
                }
            }
            catch (Exception)
            {

            }
        }


        private void SetActivePanel(Panel panel, bool on)
        {
            if (panel == null)
            {
                return;
            }

            if (on)
            {
                panel.Location = new Point(PanelX, PanelY);
                panel.Size = new Size(PanelWidth, PanelHeight);
                panel.Visible = true;
                currentPanel = panel;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openPictureFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            UIController.OpenNewImage(openPictureFileDialog.FileName);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UIController.SelectTransform(transformationSelectComboBox.SelectedIndex);
            SetActivePanel(currentPanel, false);
            SetActivePanel(GetParamsPanel(transformationSelectComboBox.SelectedIndex), true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UIController.ClearTransform();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controlsPanel.Visible = false;
            transformedPictureBox.Image = Properties.Resources.loadingPic;
            UIController.ApplyTransform();

        }

        private void increaseBright_CheckedChanged(object sender, EventArgs e)
        {
            UIController.BrightnessChangePercent = Math.Abs(UIController.BrightnessChangePercent);
        }

        private void decreaseBright_CheckedChanged(object sender, EventArgs e)
        {
            UIController.BrightnessChangePercent = -Math.Abs(UIController.BrightnessChangePercent);
        }

        private void brightNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (increaseBright.Checked)
            {
                UIController.BrightnessChangePercent = (int)brightNumericUpDown.Value;
            }
            else
            {
                UIController.BrightnessChangePercent = -(int)brightNumericUpDown.Value;
            }
        }

        private void contrastPercent_ValueChanged(object sender, EventArgs e)
        {
            if (contrastIncrease.Checked)
            {
                UIController.ContrastChangePercent = (int)contrastPercent.Value;
            }
            else
            {
                UIController.ContrastChangePercent = -(int)contrastPercent.Value;
            }
        }

        private void contrastIncrease_CheckedChanged(object sender, EventArgs e)
        {
            UIController.ContrastChangePercent = Math.Abs(UIController.ContrastChangePercent);
        }

        private void contrastDecrease_CheckedChanged(object sender, EventArgs e)
        {
            UIController.ContrastChangePercent = -Math.Abs(UIController.ContrastChangePercent);
        }

        private void GammaTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = GammaTextBox.Text;
            double gamma;
            bool succes = double.TryParse(text, out gamma);

            UIController.GammaParameter = succes ? gamma : 1;

            labelGamma.Text = "гамма параметр равен " + UIController.GammaParameter;


        }


        private System.Drawing.Imaging.ImageFormat[] saveFormats = { System.Drawing.Imaging.ImageFormat.Bmp,
            System.Drawing.Imaging.ImageFormat.Gif, System.Drawing.Imaging.ImageFormat.Icon,
            System.Drawing.Imaging.ImageFormat.Jpeg, System.Drawing.Imaging.ImageFormat.Png };

        private string saveFilter = "Bitmap image|*.bmp|Graphics Interchange Format|*.gif|Icon|*.ico|JPeg image|*.jpg|Portable Network Graphics|*.png";

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = saveFilter;

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            UIController.GetPicture().Save(saveFileDialog1.FileName, saveFormats[saveFileDialog1.FilterIndex - 1]); 
            // свойство FileDialog.FilterIndex выдает индексы начиная с 1
        }
    }
}
