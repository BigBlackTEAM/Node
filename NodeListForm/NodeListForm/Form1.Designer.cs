using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NodeListForm
{
    partial class Form1
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "BigBlackNotes";
            this.Text = "BigBlackNotes";
            this.ForeColor = Color.FromArgb(255, 240, 240, 240);
            this.ShowIcon = false;
            this.BackColor = Color.FromArgb(255, 40, 40, 40);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(283, 60);
            this.Resize += Form1_Resize;
            this.MouseUp += Form1_MouseUp;
            this.MouseDown += Form1_MouseDown;

            UpperPanel = new Panel()
            {
                Size = new Size(this.Width, 30),
                Location = new Point(0, 0),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            };
            UpperPanel.MouseDoubleClick += UpperPanel_MouseDoubleClick;


            UpperPanel.MouseDown += UpperPanel_MouseDown;
            UpperPanel.MouseMove += UpperPanel_MouseMove;

            Border = new PictureBox()
            {
                Size = new Size(this.Width, 1),
                Location = new Point(0, 30),
                BackColor = Color.FromArgb(255, 56, 56, 56)
            };

            MainButtons = new List<Button>();
            MainButtons.AddRange(new List<Button>()
            {
                new Button()
                {
                    Name = "Quit",
                    Font = new Font("Consolas", 13),
                    Text = "x",
                    Size = new Size(30, 30),
                    ForeColor = Color.FromArgb(255, 160, 160, 160),
                    Location = new Point(this.Width-30,0),
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Anchor = AnchorStyles.Right,
                },
                new Button()
                {
                    Name = "Maximize",
                    Font = new Font("Consolas", 13),
                    Text = "◻",
                    Size = new Size(30, 30),
                    ForeColor = Color.FromArgb(255, 160, 160, 160),
                    Location = new Point(this.Width-60, 0),
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Anchor = AnchorStyles.Right,
                },
                new Button()
                {
                    Name = "Minimize",
                    Font = new Font("Consolas", 13),
                    Text = "-",
                    Size = new Size(30, 30),
                    ForeColor = Color.FromArgb(255, 160, 160, 160),
                    Location = new Point(this.Width-90, 0),
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Anchor = AnchorStyles.Right,
                }
            });

            FuncButtons = new List<Button> { };

            FuncButtons.Add(new Button()
            {
                Location = new Point(120 * FuncButtons.Count, 0),
                Size = new Size(80, 30),
                Text = "Заметка",
                Name = "File",
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.FromArgb(255, 160, 160, 160),
                Font = new Font("Consolas", 9),
                TextAlign = ContentAlignment.MiddleCenter,
            });

            FuncButtons.Add(new Button()
            {
                Location = new Point(80, 0),
                Size = new Size(120, 30),
                Text = "Редактировать",
                Name = "Edit",
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.FromArgb(255, 160, 160, 160),
                Font = new Font("Consolas", 9),
                TextAlign = ContentAlignment.MiddleCenter,
            });

            FuncButtons.ForEach(x => x.FlatAppearance.BorderSize = 0);
            FuncButtons.ForEach(x => UpperPanel.Controls.Add(x));

            MainButtons.ForEach(x => UpperPanel.Controls.Add(x));
            MainButtons.ForEach(x => x.FlatAppearance.BorderSize = 0);

            MainButtons.ForEach(x => x.MouseEnter += X_MouseEnter);
            MainButtons.ForEach(x => x.MouseLeave += X_MouseLeave);
            MainButtons.ForEach(x => x.MouseClick += X_MouseClick);

            Controls.Add(UpperPanel);
            Controls.Add(Border);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.Location.Y < 0 && (this.Location.X > 40 && this.Location.X + point.X <= Screen.PrimaryScreen.Bounds.Width - 40))
                {
                    this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                    this.Location = new Point(0, 0);
                }
                else if (this.Location.X < 0)
                {
                    if (this.Location.Y > 0)
                    {
                        this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height);
                        this.Location = new Point(0, 0);
                    }
                    else
                    {
                        this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
                        this.Location = new Point(0, 0);
                    }
                }
                else if (this.Location.X + point.X > Screen.PrimaryScreen.Bounds.Width - 40)
                {
                    if (this.Location.Y > 0)
                    {
                        this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height);
                        this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, 0);
                    }
                    else
                    {
                        this.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
                        this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, 0);
                    }
                }
            }
        }

        private void UpperPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void UpperPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point Delta = new Point(point.X - this.Location.X, point.Y - this.Location.Y);
                this.Location = new Point(this.Location.X + e.X - point.X, this.Location.Y + e.Y - point.Y);
            }
        }

        private void UpperPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point = new Point(e.X, e.Y);
            }
        }
        private void X_MouseLeave(object sender, System.EventArgs e)
        {
            if ((sender as Button).Name == "Quit") MainButtons.Find(x => x.Name == "Quit").ForeColor = Color.FromArgb(255, 160, 160, 160);
        }

        private void X_MouseEnter(object sender, System.EventArgs e)
        {
            if ((sender as Button).Name == "Quit") MainButtons.Find(x => x.Name == "Quit").ForeColor = Color.Red;
        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            UpperPanel.Size = new Size(this.Width, 30);
            Border.Size = new Size(this.Width, 1);
        }

        private void X_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            switch (button.Name)
            {
                case "Quit":
                    this.Close();
                    break;
                case "Minimize":
                    this.WindowState = FormWindowState.Minimized;
                    break;
                case "Maximize":
                    if (this.WindowState != FormWindowState.Maximized)
                        this.WindowState = FormWindowState.Maximized;
                    else this.WindowState = FormWindowState.Normal;
                    break;
            }
        }


        private Panel UpperPanel;
        private List<Button> MainButtons;
        private List<Button> FuncButtons;

        private PictureBox Border;
        #endregion
    }
}

