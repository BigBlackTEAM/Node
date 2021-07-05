
using System.Drawing;
using System.Windows.Forms;

namespace NodeListForm
{
    partial class NoteForm
    {
        Point point;
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
            this.Opacity = 0.04;
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
                ForeColor = Color.FromArgb(255, 240, 240, 240),
                Location = new Point(this.Width - 30, 0),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter,
                Anchor = AnchorStyles.Right,
            };
            QuitButton.FlatAppearance.BorderSize = 0;

            QuitButton.MouseClick += QuitButton_MouseClick;
            QuitButton.MouseEnter += QuitButton_MouseEnter;
            QuitButton.MouseLeave += QuitButton_MouseLeave;

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
                ReadOnly = true,
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
                ReadOnly = true,
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
                ReadOnly = true,
                Multiline = false,
                BorderStyle = BorderStyle.None,
                Text = $"",
                Font = new Font("Consolas", 10),
                Enabled = false
            };

            this.MouseDown += NoteForm_MouseDown;
            this.MouseMove += NoteForm_MouseMove;

            AppStartAnim = new Timer();
            AppStartAnim.Interval = 1;
            AppStartAnim.Tick += ChangeOpacity;
            AppStartAnim.Start();

            Controls.Add(Date);
            Controls.Add(QuitButton);
            Controls.Add(MinimizeButton);
            Controls.Add(MainText);
            Controls.Add(Caption);
        }

        private void MinimizeButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void QuitButton_MouseLeave(object sender, System.EventArgs e)
        {
            QuitButton.ForeColor = Color.FromArgb(255, 240, 240, 240);
        }

        private void QuitButton_MouseEnter(object sender, System.EventArgs e)
        {
            QuitButton.ForeColor = Color.Red;
        }

        private void QuitButton_MouseClick(object sender, MouseEventArgs e)
        {

            this.Close();
        }

        private void ChangeOpacity(object sender, System.EventArgs e)
        {
            this.Opacity += 0.04;
            if (this.Opacity >= 0.96)
                AppStartAnim.Stop();
        }

        private Button QuitButton;
        private Button MinimizeButton;

        private TextBox Date;
        private TextBox Caption;
        private TextBox MainText;

        private Timer AppStartAnim;
        #endregion
    }
}