using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PictureFilter
{
    public class PictureTransformer
    {
        public UserInterfaceController UIController { get; set; }

        private List<ImageFilter> filters = new List<ImageFilter>();
        private int index;
                
        public Image Picture { get; private set; }

        private Brightness brightnessChanger;

        private Contrast contrastChanger;

        private Gamma gammaTransform;

        public int BrightnessChangePercent
        {
            get
            {
                return brightnessChanger.Percent;
            }

            set
            {
                brightnessChanger.Percent = value;
            }
        }

        public int ContrastChangePercent
        {
            get
            {
                return contrastChanger.Percent;
            }

            set
            {
                contrastChanger.Percent = value;
            }
        }

        public double GammaParameter
        {
            get
            {
                return gammaTransform.GammaParameter;
            }

            set
            {
                gammaTransform.GammaParameter = value;
            }
        }

        public void Init()
        {
            var negative = new ColorReversation();
            filters.Add(negative);

            var blackWhite = new TransformationToGray();
            filters.Add(blackWhite);

            var bright = new Brightness();
            filters.Add(bright);
            brightnessChanger = bright;

            var contrast = new Contrast();
            filters.Add(contrast);
            contrastChanger = contrast;

            var gamma = new Gamma();
            gamma.GammaParameter = 1;
            filters.Add(gamma);
            gammaTransform = gamma;

            var bigPictureReaderWriter = new BigPictureReaderWriter();
            var smallPictureReaderWriter = new SmallPictureReaderWriter();
            var pictureReaderWriter = new PictureReaderWriterSelector(smallPictureReaderWriter, bigPictureReaderWriter);
            foreach (ImageFilter filter in filters)
            {
                filter.PictureReaderWriter = pictureReaderWriter;
            }
        }


        public void SetPicture(Image picture)
        {
            Picture = picture;
        }

        public void SelectTransform(int n)
        {
            index = n;
        }

        public void TransformImage()
        {
            Picture = (Image)Picture.Clone();
            TransformImageAsync();
           
        }

        private async void TransformImageAsync()
        {
            Image transformedPicture = await ReturnTransformedImageAsync();
            UIController.ShowTransformResult(transformedPicture);
        }

        private Task<Image> ReturnTransformedImageAsync()
        {
            return Task.Run(
                () => {
                    return filters[index].TransformImage(Picture);
                });
        }

        
    }
}
