
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace NodeListForm
{
    partial class FormEdit
    {
        Point point;

        public Color CaptionColor;
        public Color MainTextColor;
        public Color PanelColor;
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Text = "";
            this.Opacity = 0.99;
            this.ForeColor = Color.FromArgb(255, 240, 240, 240);
            this.ShowIcon = false;
            this.BackColor = Color.FromArgb(255, 30, 30, 30);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Opacity = 0.12;

            QuitButton = new Button()
            {
                Name = "Quit",
                Font = new Font("Consolas", 15),
                Text = "✕",
                Size = new Size(30, 30),
                ForeColor = Color.Red,
                Location = new Point(this.Width - 30, 0),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter,
                Anchor = AnchorStyles.Right,
            };
            QuitButton.FlatAppearance.BorderSize = 0;

            QuitButton.MouseClick += QuitButton_MouseClick;

            MinimizeButton = new Button()
            {
                Name = "Minimize",
                Font = new Font("Consolas", 15),
                Text = "-",
                Size = new Size(30, 30),
                ForeColor = Color.FromArgb(255, 160, 160, 160),
                Location = new Point(this.Width - 60, 0),
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleCenter,
                Anchor = AnchorStyles.Right,
            };
            MinimizeButton.FlatAppearance.BorderSize = 0;
            MinimizeButton.MouseClick += MinimizeButton_MouseClick;

            Caption = new TextBox()
            {
                BackColor = this.BackColor,
                ForeColor = Color.FromArgb(255, 240, 240, 240),
                Size = new Size(this.Width - 50, (int)((float)this.Height / 3) - 45),
                Location = new Point(25, 25),
                ReadOnly = false,
                Multiline = true,
                BorderStyle = BorderStyle.None,
                Text = $"",
                Font = new Font("Consolas", 13)
            };
            MainText = new TextBox()
            {
                BackColor = this.BackColor,
                ForeColor = Color.FromArgb(255, 200, 200, 200),
                Size = new Size(this.Width - 50, (int)((float)this.Height / 1.5) - 60),
                Location = new Point(25, (int)((float)this.Height / 4) + 35),
                ReadOnly = false,
                Multiline = true,
                BorderStyle = BorderStyle.None,
                TextAlign = HorizontalAlignment.Left,
                Text = "",
                Font = new Font("Consolas", 11)
            };
            Date = new TextBox()
            {
                BackColor = this.BackColor,
                ForeColor = Color.FromArgb(255, 240, 240, 240),
                Size = new Size(100, 30),
                Location = new Point(25, this.Height - 45),
                ReadOnly = false,
                Multiline = false,
                BorderStyle = BorderStyle.None,
                Text = $"",
                Font = new Font("Consolas", 10),
                Enabled = false
            };

            this.MouseDown += NoteForm_MouseDown;
            this.MouseMove += NoteForm_MouseMove;

            ColorButtons = new List<Button>()
            {
                new Button()
                {
                    Size = new Size(20,20),
                    Location = new Point(this.Width-195, this.Height-45),
                    Region = new Region(RoundedRect(new Rectangle(0, 0, 20, 20), 11)),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(255,45,45,45),
                    Name = "Default"
                },
                new Button()
                {
                    Size = new Size(20,20),
                    Location = new Point(this.Width-165, this.Height-45),
                    Region = new Region(RoundedRect(new Rectangle(0, 0, 20, 20), 11)),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(255,253,199,112),
                    Name = "Yellow"
                },
                new Button()
                {
                    Size = new Size(20,20),
                    Location = new Point(this.Width-135, this.Height-45),
                    Region = new Region(RoundedRect(new Rectangle(0, 0, 20, 20), 11)),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(255,253,153,114),
                    Name = "Orange"
                },
                new Button()
                {
                    Size = new Size(20,20),
                    Location = new Point(this.Width-105, this.Height-45),
                    Region = new Region(RoundedRect(new Rectangle(0, 0, 20, 20), 11)),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(255,179,144,250),
                    Name = "Purple"
                },
                new Button()
                {
                    Size = new Size(20,20),
                    Location = new Point(this.Width-75, this.Height-45),
                    Region = new Region(RoundedRect(new Rectangle(0, 0, 20, 20), 11)),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(255,0,209,252),
                    Name = "Blue"
                },
                new Button()
                {
                    Size = new Size(20,20),
                    Location = new Point(this.Width-45, this.Height-45),
                    Region = new Region(RoundedRect(new Rectangle(0, 0, 20, 20), 11)),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(255,226,236,141),
                    Name = "Green"
                },
            };
            ColorButtons.ForEach(x => x.FlatAppearance.BorderSize = 0);
            ColorButtons.ForEach(x => x.MouseClick += X_MouseClick);
            //ColorButtons.ForEach(x => x.ForeColor = Color.FromArgb(255,16,16,16));

            AppStartAnim = new Timer();
            AppStartAnim.Interval = 1;
            AppStartAnim.Tick += ChangeOpacity;
            AppStartAnim.Start();

            //ColorButtons.ForEach(x => this.Controls.Add(x));
            ColorButtons.ForEach(x => x.Enabled = false);

            Controls.Add(Date);
            Controls.Add(QuitButton);
            Controls.Add(MinimizeButton);
            Controls.Add(MainText);
            Controls.Add(Caption);

            MainText.GotFocus += MainText_GotFocus;
            MainText.LostFocus += MainText_LostFocus;

            Caption.GotFocus += Caption_GotFocus;
            Caption.LostFocus += Caption_LostFocus;
        }

        private void Caption_LostFocus(object sender, System.EventArgs e)
        {
            if (Caption.Text == string.Empty) Caption.Text = "Заголовок записки";
        }

        private void Caption_GotFocus(object sender, System.EventArgs e)
        {
            if (Caption.Text == "Заголовок записки") Caption.Text = string.Empty;
        }

        private void MainText_LostFocus(object sender, System.EventArgs e)
        {
            if (MainText.Text == string.Empty) MainText.Text = "Основной текст записки";
        }

        private void MainText_GotFocus(object sender, System.EventArgs e)
        {
            if (MainText.Text == "Основной текст записки") MainText.Text = string.Empty;
        }

        private void X_MouseClick(object sender, MouseEventArgs e)
        {
            ColorButtons.Find(x => x.Name == (sender as Button).Name).Text = "✓";
            ColorButtons.Where(x => x.Name != (sender as Button).Name).ToList().ForEach(x => x.Text = "");

            switch ((sender as Button).Name)
            {
                case "Default":
                    this.BackColor = Color.FromArgb(255, 30, 30, 30);
                    UpdateColors(false);
                    break;
                case "Yellow":
                    this.BackColor = Color.FromArgb(255, 253, 199, 112);
                    UpdateColors(true);
                    break;
                case "Orange":
                    this.BackColor = Color.FromArgb(255, 253, 153, 114);
                    UpdateColors(true);
                    break;
                case "Purple":
                    this.BackColor = Color.FromArgb(255, 182, 145, 253);
                    UpdateColors(true);
                    break;
                case "Blue":
                    this.BackColor = Color.FromArgb(255, 0, 211, 253);
                    UpdateColors(true);
                    break;
                case "Green":
                    this.BackColor = Color.FromArgb(255, 226, 236, 141);
                    UpdateColors(true);
                    break;
            }
        }
        private void UpdateColors(bool IsLight)
        {
            if (IsLight)
            {
                this.Caption.ForeColor = Color.FromArgb(255, 16, 16, 16);
                this.MainText.ForeColor = Color.FromArgb(255, 40, 40, 40);
                this.Date.ForeColor = Color.FromArgb(255, 40, 40, 40);

                this.QuitButton.ForeColor = Color.FromArgb(255, 16, 16, 16);
                this.MinimizeButton.ForeColor = Color.FromArgb(255, 16, 16, 16);
            }
            else
            {
                this.Caption.ForeColor = Color.FromArgb(255, 240, 240, 240);
                this.MainText.ForeColor = Color.FromArgb(255, 200, 200, 200);
                this.Date.ForeColor = Color.FromArgb(255, 200, 200, 200);

                this.QuitButton.ForeColor = Color.FromArgb(255, 240, 240, 240);
                this.MinimizeButton.ForeColor = Color.FromArgb(255, 240, 240, 240);
            }
            UpdateMainColors();
            UpdateOutputColors();
        }
        private void UpdateOutputColors()
        {
            CaptionColor = this.Caption.ForeColor;
            MainTextColor = this.MainText.ForeColor;
            PanelColor = this.BackColor;
        }
        private void MinimizeButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void UpdateMainColors()
        {
            this.Caption.BackColor = this.BackColor;
            this.MainText.BackColor = this.BackColor;
            this.Date.BackColor = this.BackColor;
        }
        private void NoteForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point Delta = new Point(point.X - this.Location.X, point.Y - this.Location.Y);
                this.Location = new Point(this.Location.X + e.X - point.X, this.Location.Y + e.Y - point.Y);
            }
        }

        private void NoteForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point = new Point(e.X, e.Y);
            }
        }

        private void QuitButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void ChangeOpacity(object sender, System.EventArgs e)
        {
            this.Opacity += 0.04;
            if (this.Opacity >= 1)
                AppStartAnim.Stop();
        }

        private List<Button> ColorButtons;

        private Button QuitButton;
        private Button MinimizeButton;

        public TextBox Date;
        public TextBox Caption;
        public TextBox MainText;

        private Timer AppStartAnim;
        #endregion
    }
}