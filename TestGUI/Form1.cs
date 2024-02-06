using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace TestGUI
{
    public sealed partial class MainForm : Form
    {
        private readonly ImageAlgorithms _imageAlg;

        public MainForm()
        {
            InitializeComponent();
            _imageAlg = new ImageAlgorithms();
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
            OnAlgoritmResult(_imageAlg.NegativeClassic(new Bitmap(InputPictureBox.Image)), "Негатив классический");
        }

        private void GreyAverageButtonClick(object sender, EventArgs e)
        {
            OnAlgoritmStart();
            OnAlgoritmResult(_imageAlg.GrayAverage(new Bitmap(InputPictureBox.Image)), "Оттенки серого усреднение");
        }

        private void BitButtonClick(object sender, EventArgs e)
        {
            OnAlgoritmStart();
            OnAlgoritmResult(_imageAlg.Bit(new Bitmap(InputPictureBox.Image)), "Битовое");
        }

        private void NegativeSwapButtonClick(object sender, EventArgs e)
        {
            OnAlgoritmStart();
            OnAlgoritmResult(_imageAlg.NegativeSwap(new Bitmap(InputPictureBox.Image)), "Обмен каналами");
        }

        private void GreyLitButtonClick(object sender, EventArgs e)
        {
            OnAlgoritmStart();
            OnAlgoritmResult(_imageAlg.GrayLit(new Bitmap(InputPictureBox.Image)), "Оттенки серого осветление");

        }

        private void GreyBrightButtonClick(object sender, EventArgs e)
        {
            OnAlgoritmStart();
            OnAlgoritmResult(_imageAlg.GrayBright(new Bitmap(InputPictureBox.Image)), "Оттенки серого яркость");
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            SaveFileDialog.FileName = _outputImageName;
            SaveFileDialog.ShowDialog(this);

            if(SaveFileDialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)SaveFileDialog.OpenFile();

                ResultPictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                fs.Close();
            }
        }

        private void OnAlgoritmStart()
        {
            TimerLabel.Text = "Время выполнения: ";
            _stopWatch.Restart();
            _stopWatch.Start();

            SetButtonsEnabledState(false);
        }
        private void OnAlgoritmResult(Bitmap resultImage, string outputName)
        {
            ResultPictureBox.Image = resultImage;
            _outputImageName = outputName;

            SetButtonsEnabledState(true);

            _stopWatch.Stop();
            TimerLabel.Text = "Время выполнения: " + (_stopWatch.ElapsedMilliseconds / 1000f).ToString("0.00");
        }

        private void SetButtonsEnabledState(bool state)
        {
            NegativeClassicButton.Enabled = state;
            LoadButton.Enabled = state;
            BitButton.Enabled = state;
            GreyAverageButton.Enabled = state;
            NegativeSwapButton.Enabled = state;
            GreyLitButton.Enabled = state;
            GreyBrightButton.Enabled = state;
            SaveButton.Enabled = state;

            PleaseWaitLabel.Enabled = !state;
        }

        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();

        private void MinimizeButton_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://vk.com/syylik");
    }
}