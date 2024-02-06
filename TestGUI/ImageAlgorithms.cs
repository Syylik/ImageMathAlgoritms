using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestGUI
{
    internal sealed class ImageAlgorithms
    {
        public Bitmap NegativeClassic(Bitmap originalImage)
        {
            Bitmap outputImage = new Bitmap(originalImage.Width, originalImage.Height);

            for(int x = 0; x < outputImage.Width; x++)
            {
                for(int y = 0; y < outputImage.Height; y++)
                {
                    Color originalColor = originalImage.GetPixel(x, y);

                    Color negativeColor = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);

                    outputImage.SetPixel(x, y, negativeColor);
                }
            }

            return outputImage;
        }

        public Bitmap GrayAverage(Bitmap originalImage)
        {
            Bitmap outputImage = new Bitmap(originalImage.Width, originalImage.Height);

            for(int y = 0; y < outputImage.Height; y++)
            {
                for(int x = 0; x < outputImage.Width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);

                    int avg = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color monoColor = Color.FromArgb(avg, avg, avg);
                    outputImage.SetPixel(x, y, monoColor);
                }
            }

            return outputImage;
        }

        public Bitmap Bit(Bitmap originalImage)
        {
            Bitmap outputImage = new Bitmap(originalImage.Width, originalImage.Height);

            for(int y = 0; y < outputImage.Height; y++)
            {
                for(int x = 0; x < outputImage.Width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);

                    int avgBrightness = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                    if(avgBrightness > 128)
                    {
                        Color monoColor = Color.FromArgb(255, 255, 255);
                        originalImage.SetPixel(x, y, monoColor);
                    }
                    else
                    {
                        Color monoColor = Color.FromArgb(0, 0, 0);
                        outputImage.SetPixel(x, y, monoColor);
                    }
                }
            }

            return outputImage;
        }

        public Bitmap NegativeSwap(Bitmap originalImage)
        {
            Bitmap outputImage = new Bitmap(originalImage.Width, originalImage.Height);

            for(int x = 0; x < outputImage.Width; x++)
            {
                for(int y = 0; y < outputImage.Height; y++)
                {
                    Color originalColor = originalImage.GetPixel(x, y);

                    Color negativeColor = Color.FromArgb(originalColor.B, originalColor.R, originalColor.G);

                    outputImage.SetPixel(x, y, negativeColor);
                }
            }

            return outputImage;
        }

        public Bitmap GrayLit(Bitmap originalImage)
        {
            Bitmap outputImage = new Bitmap(originalImage.Width, originalImage.Height);

            for(int y = 0; y < originalImage.Height; y++)
            {
                for(int x = 0; x < originalImage.Width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);
                    int red = pixelColor.R;
                    int green = pixelColor.G;
                    int blue = pixelColor.B;

                    int color_lighth = GetMaxAndMin(red, green, blue);
                    Color monoColor = Color.FromArgb(color_lighth, color_lighth, color_lighth);
                    outputImage.SetPixel(x, y, monoColor);
                }
            }

            return outputImage;
        }

        private int GetMaxAndMin(int x, int y, int z)
        {
            int max = 0, min = 0;

            int yzMax = Math.Max(y, z);
            int yzMin = Math.Min(y, z);

            if(x > yzMax) max = x;
            else max = yzMax;

            if(x < yzMax) min = x;
            else min = yzMin;

            int average = (max + min) / 2;
            return average;
        }

        public Bitmap GrayBright(Bitmap originalImage)
        {
            Bitmap outputImage = new Bitmap(originalImage.Width, originalImage.Height);

            for(int y = 0; y < outputImage.Height; y++)
            {
                for(int x = 0; x < outputImage.Width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);

                    Color monoColor = Color.FromArgb(Convert.ToInt32(pixelColor.R * 0.3), Convert.ToInt32(pixelColor.G * 0.59), Convert.ToInt32(pixelColor.B * 0.11));
                    outputImage.SetPixel(x, y, monoColor);
                }
            }

            return outputImage;
        }
    }
}