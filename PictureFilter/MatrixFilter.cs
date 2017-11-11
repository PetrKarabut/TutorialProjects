using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PictureFilter
{
    class MatrixFilter : ImageFilter
    {
        public void ApplyMatrix(Image picture, double[,] matrix, int length)
        {
            Bitmap copyImage = (Bitmap)picture.Clone();
            Bitmap image = (Bitmap)picture;

            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    byte red = GetChanel(copyImage, x, y, matrix, length, Chanel.Red);
                    byte green = GetChanel(copyImage, x, y, matrix, length, Chanel.Green);
                    byte blue = GetChanel(copyImage, x, y, matrix, length, Chanel.Blue);

                    Color newColor = Color.FromArgb(red, green, blue);
                    image.SetPixel(x, y, newColor);
                }
            }
        }

        private enum Chanel { Red, Green, Blue }

        private byte GetChanel(Bitmap image, int x, int y, double[,] matrix, int length, Chanel chanel)
        {
            int l = (length - 1) / 2;
            int[,] pixels = new int[length, length];

            for (int i = x - l; i <= x + l; i++)
            {
                for (int j = y - l; j < y + l; j++)
                {
                    if (i >= 0 && i < image.Width && j >= 0 && j < image.Height)
                    {
                        switch (chanel)
                        {
                            case Chanel.Red:
                                pixels[i - (x - l), j - (y - l)] = image.GetPixel(i, j).R;
                                break;
                            case Chanel.Blue:
                                pixels[i - (x - l), j - (y - l)] = image.GetPixel(i, j).B;
                                break;
                            case Chanel.Green:
                                pixels[i - (x - l), j - (y - l)] = image.GetPixel(i, j).G;
                                break;
                        }
                    }
                }
            }

            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    sum += (int)Math.Round(pixels[i, j] * matrix[i, j]);
                }
            }
            

            if (sum < 0)
            {
                sum = 0;
            }

            if (sum > 255)
            {
                sum = 255;
            }

            return (byte)sum;
        }
    }
}
