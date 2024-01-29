using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace TestGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int _pixelCount;

        private string _outputImageName;

        private Stopwatch _stopWatch = new Stopwatch();
        
        private void LoadButtonClick(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog();
                ofd.Filter = "Файлы изображений (*.bmp, *.jpg, *.png, *.tiff)|*.bmp;*.jpg;*.png;*.tiff";
                InputPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    InputPictureBox.Image = Image.FromFile(ofd.FileName);
                    NegativeClassicButton.Enabled = true;
                    GreyAverageButton.Enabled = true;
                    BitButton.Enabled = true;
                    NegativeSwapButton.Enabled = true;
                    GreyLitButton.Enabled = true;
                    GreyBrightButton.Enabled = true;
                }

                Image image = InputPictureBox.Image;

                int width = image.Width;
                int height = image.Height;
                ImageFormat format = image.RawFormat;
                _pixelCount = width * height;

                widthLabel.Text = "Ширина = " + width.ToString();
                heightLabel.Text = "Высота = " + height.ToString();
                pixelCountLabel.Text = "Всего пикселей = " + _pixelCount.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузки изображения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void NegativeClassicButtonClick(object sender, EventArgs e)
        {
            OnAlgoritmStart();

            Bitmap originalImage = new Bitmap(InputPictureBox.Image);

            Bitmap negativeImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color originalColor = originalImage.GetPixel(x, y);

                    Color negativeColor = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);

                    negativeImage.SetPixel(x, y, negativeColor);
                    AlgoritmsProgressBar.Value++;
                }
            }

            OnAlgoritmResult(negativeImage, "Негатив классический");
        }

        private void GreyAverageButtonClick(object sender, EventArgs e)
        {
            OnAlgoritmStart();

            Bitmap originalImage = new Bitmap(InputPictureBox.Image);

            // Получаем ширину и высоту изображения
            int width = originalImage.Width;
            int height = originalImage.Height;

            // Проходимся по каждому пикселю изображения
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);

                    // Вычисляем среднее значение яркости пикселя
                    int avg = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color monoColor = Color.FromArgb(avg, avg, avg);
                    originalImage.SetPixel(x, y, monoColor);

                    AlgoritmsProgressBar.Value++;
                }
            }

            OnAlgoritmResult(originalImage, "Оттенки серого усреднение");
        }

         void BitButtonClick(object sender, EventArgs e)
        {
            OnAlgoritmStart();

            Bitmap originalImage = new Bitmap(InputPictureBox.Image);

            // Получаем ширину и высоту изображения
            int width = originalImage.Width;
            int height = originalImage.Height;

            // Проходимся по каждому пикселю изображения
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);

                    // Вычисляем среднее значение яркости пикселя
                    int avgBrightness = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                    if (avgBrightness > 128)
                    {
                        Color monoColor = Color.FromArgb(255, 255, 255);
                        originalImage.SetPixel(x, y, monoColor);
                    }
                    else
                    {
                        Color monoColor = Color.FromArgb(0, 0, 0);
                        originalImage.SetPixel(x, y, monoColor);
                    }
                    AlgoritmsProgressBar.Value++;
                }
            }

            OnAlgoritmResult(originalImage, "Битовое");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://vk.com/syylik");
        }

        private void NegativeSwapButtonClick(object sender, EventArgs e)
        {
            OnAlgoritmStart();

            Bitmap originalImage = new Bitmap(InputPictureBox.Image);

            Bitmap negativeImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color originalColor = originalImage.GetPixel(x, y);

                        
                    Color negativeColor = Color.FromArgb(originalColor.B, originalColor.R, originalColor.G);

                    negativeImage.SetPixel(x, y, negativeColor);
                    AlgoritmsProgressBar.Value++;
                }
            }

            OnAlgoritmResult(originalImage, "Обмен каналами");
        }

        private void GreyLitButtonClick(object sender, EventArgs e)
        {
            OnAlgoritmStart();

            Bitmap originalImage = new Bitmap(InputPictureBox.Image);

            // Получаем ширину и высоту изображения
            int width = originalImage.Width;
            int height = originalImage.Height;

            // Проходимся по каждому пикселю изображения
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);
                    int red = pixelColor.R;
                    int green = pixelColor.G;
                    int blue = pixelColor.B;

                    int color_lighth = GetMaxAndMin(red, green, blue);
                    Color monoColor = Color.FromArgb(color_lighth, color_lighth, color_lighth);
                    originalImage.SetPixel(x, y, monoColor);

                    AlgoritmsProgressBar.Value++;
                }
            }

            OnAlgoritmResult(originalImage, "Оттенки серого осветление");

        }

        int GetMaxAndMin(int x, int y, int z)
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

        private void GreyBrightButtonClick(object sender, EventArgs e)
        {
            OnAlgoritmStart();

            Bitmap originalImage = new Bitmap(InputPictureBox.Image);

            // Получаем ширину и высоту изображения
            int width = originalImage.Width;
            int height = originalImage.Height;

            // Проходимся по каждому пикселю изображения
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);

                    Color monoColor = Color.FromArgb(Convert.ToInt32(pixelColor.R * 0.3), Convert.ToInt32(pixelColor.G * 0.59), Convert.ToInt32(pixelColor.B * 0.11));
                    originalImage.SetPixel(x, y, monoColor);

                    AlgoritmsProgressBar.Value++;
                    //if(x % 100 == 0) AlgoritmsProgressBar.Update();
                }
            }

            OnAlgoritmResult(originalImage, "Оттенки серого яркость");

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            SaveFileDialog.FileName = _outputImageName;
            SaveFileDialog.ShowDialog(this);

            if(SaveFileDialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)SaveFileDialog.OpenFile();

                ResultPictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);

                fs.Close();
            }
        }

        private void OnAlgoritmStart()
        {
            TimerLabel.Text = $"Время выполнения: ";
            _stopWatch.Restart();
            _stopWatch.Start();

            NegativeClassicButton.Enabled = false;
            LoadButton.Enabled = false;
            BitButton.Enabled = false;
            GreyAverageButton.Enabled = false;
            NegativeSwapButton.Enabled = false;
            GreyLitButton.Enabled = false;
            GreyBrightButton.Enabled = false;
            SaveButton.Enabled = false;

            AlgoritmsProgressBar.Value = 0;
            AlgoritmsProgressBar.Minimum = 0;
            AlgoritmsProgressBar.Maximum = _pixelCount;
        }
        private void OnAlgoritmResult(Bitmap resultImage, string outputName)
        {
            ResultPictureBox.Image = resultImage;
            _outputImageName = outputName;

            NegativeClassicButton.Enabled = true;
            LoadButton.Enabled = true;
            BitButton.Enabled = true;
            GreyAverageButton.Enabled = true;
            NegativeSwapButton.Enabled = true;
            GreyLitButton.Enabled = true;
            GreyBrightButton.Enabled = true;
            SaveButton.Enabled = true;

            _stopWatch.Stop();
            TimerLabel.Text = "Время выполнения: " + (_stopWatch.ElapsedMilliseconds / 1000f).ToString("0.00");
        }

        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();

        private void MinimizeButton_Click(object sender, EventArgs e) 
            => this.WindowState = FormWindowState.Minimized;
    }
}