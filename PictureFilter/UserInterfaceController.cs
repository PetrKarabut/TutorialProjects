using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PictureFilter
{
    public class UserInterfaceController
    {
        public MainWindow WindowForm { get; set; }
        public PictureTransformer Transformer { get; set; }

        private Image startPicture;

        public void OpenNewImage(string path)
        {
            try
            {
                var picture = Image.FromFile(path);
                startPicture = (Image)picture.Clone();
                SelectImage(picture);
            }
            catch (Exception)
            {
                WindowForm.OnOpenFailed();
            }

            
        }

        public void OpenNewImage(Image picture)
        {
            SelectImage(picture);
            startPicture = (Image)picture.Clone();
        }

        public void SelectTransform(int index)
        {
            Transformer.SelectTransform(index);
        }

        public void ApplyTransform()
        {
            Transformer.TransformImage();
        }

        public void ClearTransform()
        {
           if (startPicture != null)
            {
                SelectImage(startPicture);
            }
        }

        public void ShowTransformResult(Image picture)
        {
            if (picture == null)
            {
                WindowForm.OnTransformationFailed();
                return;
            }
            WindowForm.ShowTransformedPicture(picture);
        }


        public Image GetPicture()
        {
            return Transformer.Picture;
        }

        private void SelectImage(Image picture)
        {
            WindowForm.OnImageSelected(picture);
            Transformer.SetPicture(picture);
        }

        public int BrightnessChangePercent
        {
            get
            {
                return Transformer.BrightnessChangePercent;
            }

            set
            {
                Transformer.BrightnessChangePercent = value;
            }
        }

        public int ContrastChangePercent
        {
            get
            {
                return Transformer.ContrastChangePercent;
            }

            set
            {
                Transformer.ContrastChangePercent = value;
            }
        }

        public double GammaParameter
        {
            get
            {
                return Transformer.GammaParameter;
            }

            set
            {
                Transformer.GammaParameter = value;
            }
        }
    }
}
