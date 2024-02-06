namespace TestGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TimerLabel = new System.Windows.Forms.Label();
            this.JerkInfoLabel = new System.Windows.Forms.Label();
            this.pixelCountLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.AuthorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.guna2BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.NegativeClassicButton = new Guna.UI2.WinForms.Guna2Button();
            this.LoadButton = new Guna.UI2.WinForms.Guna2Button();
            this.SaveButton = new Guna.UI2.WinForms.Guna2Button();
            this.ResultPictureBox = new System.Windows.Forms.PictureBox();
            this.InputPictureBox = new System.Windows.Forms.PictureBox();
            this.NegativeSwapButton = new Guna.UI2.WinForms.Guna2Button();
            this.GreyAverageButton = new Guna.UI2.WinForms.Guna2Button();
            this.GreyLitButton = new Guna.UI2.WinForms.Guna2Button();
            this.GreyBrightButton = new Guna.UI2.WinForms.Guna2Button();
            this.BitButton = new Guna.UI2.WinForms.Guna2Button();
            this.InfoGroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.PleaseWaitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputPictureBox)).BeginInit();
            this.InfoGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TimerLabel.Location = new System.Drawing.Point(17, 108);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(120, 15);
            this.TimerLabel.TabIndex = 14;
            this.TimerLabel.Text = "Время выполнения: ";
            // 
            // JerkInfoLabel
            // 
            this.JerkInfoLabel.AutoSize = true;
            this.JerkInfoLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JerkInfoLabel.ForeColor = System.Drawing.Color.Tomato;
            this.JerkInfoLabel.Location = new System.Drawing.Point(21, 169);
            this.JerkInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JerkInfoLabel.Name = "JerkInfoLabel";
            this.JerkInfoLabel.Size = new System.Drawing.Size(235, 13);
            this.JerkInfoLabel.TabIndex = 2;
            this.JerkInfoLabel.Text = "В момент выполнения не перемещайте окно:";
            // 
            // pixelCountLabel
            // 
            this.pixelCountLabel.AutoSize = true;
            this.pixelCountLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pixelCountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.pixelCountLabel.Location = new System.Drawing.Point(17, 86);
            this.pixelCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pixelCountLabel.Name = "pixelCountLabel";
            this.pixelCountLabel.Size = new System.Drawing.Size(92, 13);
            this.pixelCountLabel.TabIndex = 0;
            this.pixelCountLabel.Text = "Всего пикселей:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.heightLabel.Location = new System.Drawing.Point(17, 63);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(47, 13);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "Высота:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.widthLabel.Location = new System.Drawing.Point(17, 39);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(55, 13);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Ширина:";
            // 
            // AuthorLinkLabel
            // 
            this.AuthorLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorLinkLabel.AutoSize = true;
            this.AuthorLinkLabel.LinkVisited = true;
            this.AuthorLinkLabel.Location = new System.Drawing.Point(733, 382);
            this.AuthorLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorLinkLabel.Name = "AuthorLinkLabel";
            this.AuthorLinkLabel.Size = new System.Drawing.Size(105, 13);
            this.AuthorLinkLabel.TabIndex = 9;
            this.AuthorLinkLabel.TabStop = true;
            this.AuthorLinkLabel.Text = "Автор программы";
            this.AuthorLinkLabel.VisitedLinkColor = System.Drawing.Color.Teal;
            this.AuthorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Файлы изображений (*.jpg, *.png *.bmp *.tiff)|*.jpg;*.png;*.bmp;*.tiff";
            // 
            // guna2BorderlessForm
            // 
            this.guna2BorderlessForm.BorderRadius = 30;
            this.guna2BorderlessForm.ContainerControl = this;
            this.guna2BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm.TransparentWhileDrag = true;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.MinimizeButton.Image = global::TestGUI.Properties.Resources.minimizeIcon;
            this.MinimizeButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.MinimizeButton.ImageRotate = 0F;
            this.MinimizeButton.ImageSize = new System.Drawing.Size(27, 27);
            this.MinimizeButton.Location = new System.Drawing.Point(771, 12);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.MinimizeButton.Size = new System.Drawing.Size(31, 36);
            this.MinimizeButton.TabIndex = 18;
            this.MinimizeButton.UseTransparentBackground = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.ExitButton.Image = global::TestGUI.Properties.Resources.closeIcon;
            this.ExitButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.ExitButton.ImageRotate = 0F;
            this.ExitButton.ImageSize = new System.Drawing.Size(27, 27);
            this.ExitButton.Location = new System.Drawing.Point(804, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.ExitButton.Size = new System.Drawing.Size(36, 36);
            this.ExitButton.TabIndex = 17;
            this.ExitButton.UseTransparentBackground = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NegativeClassicButton
            // 
            this.NegativeClassicButton.BorderRadius = 15;
            this.NegativeClassicButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NegativeClassicButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NegativeClassicButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NegativeClassicButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NegativeClassicButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NegativeClassicButton.Enabled = false;
            this.NegativeClassicButton.FillColor = System.Drawing.Color.White;
            this.NegativeClassicButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NegativeClassicButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NegativeClassicButton.ImageSize = new System.Drawing.Size(22, 22);
            this.NegativeClassicButton.Location = new System.Drawing.Point(334, 83);
            this.NegativeClassicButton.Name = "NegativeClassicButton";
            this.NegativeClassicButton.Size = new System.Drawing.Size(197, 28);
            this.NegativeClassicButton.TabIndex = 16;
            this.NegativeClassicButton.Text = "Негатив: классический";
            this.NegativeClassicButton.Click += new System.EventHandler(this.NegativeClassicButtonClick);
            // 
            // LoadButton
            // 
            this.LoadButton.BorderRadius = 20;
            this.LoadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoadButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoadButton.ForeColor = System.Drawing.Color.White;
            this.LoadButton.Image = global::TestGUI.Properties.Resources.LoadIcon;
            this.LoadButton.ImageOffset = new System.Drawing.Point(-1, 0);
            this.LoadButton.ImageSize = new System.Drawing.Size(22, 22);
            this.LoadButton.Location = new System.Drawing.Point(329, 21);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(202, 45);
            this.LoadButton.TabIndex = 15;
            this.LoadButton.Text = "Загрузить...";
            this.LoadButton.Click += new System.EventHandler(this.LoadButtonClick);
            // 
            // SaveButton
            // 
            this.SaveButton.BorderRadius = 20;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveButton.Enabled = false;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Image = global::TestGUI.Properties.Resources.SaveIcon;
            this.SaveButton.ImageOffset = new System.Drawing.Point(-1, 0);
            this.SaveButton.ImageSize = new System.Drawing.Size(22, 22);
            this.SaveButton.Location = new System.Drawing.Point(329, 345);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(202, 45);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Сохранить результат";
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // ResultPictureBox
            // 
            this.ResultPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResultPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ResultPictureBox.Location = new System.Drawing.Point(20, 213);
            this.ResultPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.ResultPictureBox.Name = "ResultPictureBox";
            this.ResultPictureBox.Size = new System.Drawing.Size(300, 177);
            this.ResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResultPictureBox.TabIndex = 3;
            this.ResultPictureBox.TabStop = false;
            // 
            // InputPictureBox
            // 
            this.InputPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.InputPictureBox.Location = new System.Drawing.Point(20, 21);
            this.InputPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.InputPictureBox.Name = "InputPictureBox";
            this.InputPictureBox.Size = new System.Drawing.Size(300, 177);
            this.InputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InputPictureBox.TabIndex = 1;
            this.InputPictureBox.TabStop = false;
            // 
            // NegativeSwapButton
            // 
            this.NegativeSwapButton.BorderRadius = 15;
            this.NegativeSwapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NegativeSwapButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NegativeSwapButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NegativeSwapButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NegativeSwapButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NegativeSwapButton.Enabled = false;
            this.NegativeSwapButton.FillColor = System.Drawing.Color.White;
            this.NegativeSwapButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NegativeSwapButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NegativeSwapButton.ImageSize = new System.Drawing.Size(22, 22);
            this.NegativeSwapButton.Location = new System.Drawing.Point(334, 120);
            this.NegativeSwapButton.Name = "NegativeSwapButton";
            this.NegativeSwapButton.Size = new System.Drawing.Size(197, 28);
            this.NegativeSwapButton.TabIndex = 19;
            this.NegativeSwapButton.Text = "Негатив: обмен каналами";
            this.NegativeSwapButton.Click += new System.EventHandler(this.NegativeSwapButtonClick);
            // 
            // GreyAverageButton
            // 
            this.GreyAverageButton.BorderRadius = 15;
            this.GreyAverageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GreyAverageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GreyAverageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GreyAverageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GreyAverageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GreyAverageButton.Enabled = false;
            this.GreyAverageButton.FillColor = System.Drawing.Color.White;
            this.GreyAverageButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GreyAverageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.GreyAverageButton.ImageSize = new System.Drawing.Size(22, 22);
            this.GreyAverageButton.Location = new System.Drawing.Point(334, 173);
            this.GreyAverageButton.Name = "GreyAverageButton";
            this.GreyAverageButton.Size = new System.Drawing.Size(197, 28);
            this.GreyAverageButton.TabIndex = 20;
            this.GreyAverageButton.Text = "Оттенки серого: усреднение";
            this.GreyAverageButton.Click += new System.EventHandler(this.GreyAverageButtonClick);
            // 
            // GreyLitButton
            // 
            this.GreyLitButton.BorderRadius = 15;
            this.GreyLitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GreyLitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GreyLitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GreyLitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GreyLitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GreyLitButton.Enabled = false;
            this.GreyLitButton.FillColor = System.Drawing.Color.White;
            this.GreyLitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GreyLitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.GreyLitButton.ImageSize = new System.Drawing.Size(22, 22);
            this.GreyLitButton.Location = new System.Drawing.Point(334, 208);
            this.GreyLitButton.Name = "GreyLitButton";
            this.GreyLitButton.Size = new System.Drawing.Size(197, 28);
            this.GreyLitButton.TabIndex = 21;
            this.GreyLitButton.Text = "Оттенки серого: осветление";
            this.GreyLitButton.Click += new System.EventHandler(this.GreyLitButtonClick);
            // 
            // GreyBrightButton
            // 
            this.GreyBrightButton.BorderRadius = 15;
            this.GreyBrightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GreyBrightButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GreyBrightButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GreyBrightButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GreyBrightButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GreyBrightButton.Enabled = false;
            this.GreyBrightButton.FillColor = System.Drawing.Color.White;
            this.GreyBrightButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GreyBrightButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.GreyBrightButton.ImageSize = new System.Drawing.Size(22, 22);
            this.GreyBrightButton.Location = new System.Drawing.Point(334, 243);
            this.GreyBrightButton.Name = "GreyBrightButton";
            this.GreyBrightButton.Size = new System.Drawing.Size(197, 28);
            this.GreyBrightButton.TabIndex = 22;
            this.GreyBrightButton.Text = "Оттенки серого: яркость";
            this.GreyBrightButton.Click += new System.EventHandler(this.GreyBrightButtonClick);
            // 
            // BitButton
            // 
            this.BitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BitButton.BorderRadius = 15;
            this.BitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BitButton.Enabled = false;
            this.BitButton.FillColor = System.Drawing.Color.White;
            this.BitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BitButton.ImageSize = new System.Drawing.Size(22, 22);
            this.BitButton.Location = new System.Drawing.Point(334, 300);
            this.BitButton.Name = "BitButton";
            this.BitButton.Size = new System.Drawing.Size(197, 28);
            this.BitButton.TabIndex = 23;
            this.BitButton.Text = "Битовое изображение";
            this.BitButton.Click += new System.EventHandler(this.BitButtonClick);
            // 
            // InfoGroupBox1
            // 
            this.InfoGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoGroupBox1.AutoRoundedCorners = true;
            this.InfoGroupBox1.BorderRadius = 20;
            this.InfoGroupBox1.Controls.Add(this.PleaseWaitLabel);
            this.InfoGroupBox1.Controls.Add(this.TimerLabel);
            this.InfoGroupBox1.Controls.Add(this.widthLabel);
            this.InfoGroupBox1.Controls.Add(this.JerkInfoLabel);
            this.InfoGroupBox1.Controls.Add(this.heightLabel);
            this.InfoGroupBox1.Controls.Add(this.pixelCountLabel);
            this.InfoGroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.InfoGroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.InfoGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InfoGroupBox1.ForeColor = System.Drawing.Color.White;
            this.InfoGroupBox1.Location = new System.Drawing.Point(540, 54);
            this.InfoGroupBox1.Name = "InfoGroupBox1";
            this.InfoGroupBox1.Size = new System.Drawing.Size(300, 200);
            this.InfoGroupBox1.TabIndex = 24;
            this.InfoGroupBox1.Text = "Информация:";
            // 
            // PleaseWaitLabel
            // 
            this.PleaseWaitLabel.AutoSize = true;
            this.PleaseWaitLabel.Enabled = false;
            this.PleaseWaitLabel.ForeColor = System.Drawing.Color.Orange;
            this.PleaseWaitLabel.Location = new System.Drawing.Point(21, 138);
            this.PleaseWaitLabel.Name = "PleaseWaitLabel";
            this.PleaseWaitLabel.Size = new System.Drawing.Size(217, 15);
            this.PleaseWaitLabel.TabIndex = 15;
            this.PleaseWaitLabel.Text = "Программа сейчас выполняет работу";
            this.PleaseWaitLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(854, 412);
            this.Controls.Add(this.InfoGroupBox1);
            this.Controls.Add(this.BitButton);
            this.Controls.Add(this.GreyBrightButton);
            this.Controls.Add(this.GreyLitButton);
            this.Controls.Add(this.GreyAverageButton);
            this.Controls.Add(this.NegativeSwapButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NegativeClassicButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AuthorLinkLabel);
            this.Controls.Add(this.ResultPictureBox);
            this.Controls.Add(this.InputPictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(854, 412);
            this.MinimumSize = new System.Drawing.Size(854, 412);
            this.Name = "MainForm";
            this.Text = "МАТЕМАТИЧЕСКИЕ АЛГОРИТМЫ В ОБРАБОТКЕ ИЗОБРАЖЕНИЙ";
            ((System.ComponentModel.ISupportInitialize)(this.ResultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputPictureBox)).EndInit();
            this.InfoGroupBox1.ResumeLayout(false);
            this.InfoGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox InputPictureBox;
        private System.Windows.Forms.PictureBox ResultPictureBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label pixelCountLabel;
        private System.Windows.Forms.Label JerkInfoLabel;
        private System.Windows.Forms.LinkLabel AuthorLinkLabel;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Label TimerLabel;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm;
        private Guna.UI2.WinForms.Guna2Button SaveButton;
        private Guna.UI2.WinForms.Guna2Button LoadButton;
        private Guna.UI2.WinForms.Guna2Button NegativeClassicButton;
        private Guna.UI2.WinForms.Guna2ImageButton ExitButton;
        private Guna.UI2.WinForms.Guna2ImageButton MinimizeButton;
        private Guna.UI2.WinForms.Guna2Button GreyBrightButton;
        private Guna.UI2.WinForms.Guna2Button GreyLitButton;
        private Guna.UI2.WinForms.Guna2Button GreyAverageButton;
        private Guna.UI2.WinForms.Guna2Button NegativeSwapButton;
        private Guna.UI2.WinForms.Guna2Button BitButton;
        private Guna.UI2.WinForms.Guna2GroupBox InfoGroupBox1;
        private System.Windows.Forms.Label PleaseWaitLabel;
    }
}

