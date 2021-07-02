using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NodeListForm
{
    partial class Form1
    {
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
            this.BackColor = Color.FromArgb(255, 26, 26, 26);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Resize += Form1_Resize;

            UpperPanel = new Panel()
            {
                Size = new Size(this.Width, 30),
                Location = new Point(0, 0),
                BackColor = Color.FromArgb(255, 16, 16, 16)
            };

            Border = new PictureBox()
            {
                Size = new Size(this.Width, 1),
                Location = new Point(0, 30),
                BackColor = Color.FromArgb(255, 0, 0, 0)
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
                    ForeColor = Color.FromArgb(255, 130, 130, 130),
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
                    ForeColor = Color.FromArgb(255, 130, 130, 130),
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
                    ForeColor = Color.FromArgb(255, 130, 130, 130),
                    Location = new Point(this.Width-90, 0),
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Anchor = AnchorStyles.Right,
                }
            });

            MainButtons.ForEach(x => UpperPanel.Controls.Add(x));
            MainButtons.ForEach(x => x.FlatAppearance.BorderSize = 0);
            MainButtons.ForEach(x => x.MouseEnter += X_MouseEnter);
            MainButtons.ForEach(x => x.MouseLeave += X_MouseLeave);
            MainButtons.ForEach(x => x.MouseClick += X_MouseClick);

            Controls.Add(UpperPanel);
            Controls.Add(Border);
        }

        private void X_MouseLeave(object sender, System.EventArgs e)
        {
            if ((sender as Button).Name == "Quit") MainButtons.Find(x => x.Name == "Quit").ForeColor = Color.FromArgb(255, 130, 130, 130);
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

        private PictureBox Border;
        #endregion
    }
}

