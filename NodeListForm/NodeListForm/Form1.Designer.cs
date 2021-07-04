using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NodeListForm
{
    partial class Form1
    {
        Point point;
        bool IsControlPanelShow = true;
        bool IsSearchPanelShow = false;
        int FloatTimeOfControlPanelAnim;
        int FloatTimeOfSearchFieldAnim;
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
            this.ClientSize = new System.Drawing.Size(793, 569);
            this.Name = "BigBlackNotes";
            this.Text = "BigBlackNotes";
            this.ForeColor = Color.FromArgb(255, 240, 240, 240);
            this.ShowIcon = false;
            this.BackColor = Color.FromArgb(255, 40, 40, 40);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(793, 47);
            this.Resize += Form1_Resize;
            this.MouseUp += Form1_MouseUp;
            this.MouseDown += Form1_MouseDown;

            UpperPanel = new Panel()
            {
                Size = new Size(this.Width, 30),
                Location = new Point(0, 0),
                BackColor = Color.FromArgb(255, 66, 66, 66),
            };
            UpperPanel.MouseDoubleClick += UpperPanel_MouseDoubleClick;

            ControlPanel = new Panel()
            {
                Size = new Size(this.Width, 40),
                Location = new Point(0, -12),
                BackColor = Color.FromArgb(255, 55, 55, 55),
                Visible = false,
            };

            NotesPanel = new Panel()
            {
                Size = new Size(658, 370),
                Location = new Point(68, 160),
                BackColor = Color.FromArgb(255, 40, 40, 40),
            };

            Notes = new List<Panel>();
            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * Notes.Count % 7, 0 + 76 * Notes.Count / 7),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.Add(new Panel()
            {
                Size = new Size(87, 65),
                Location = new Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),
                BackColor = Color.FromArgb(255, 66, 66, 66)
            });

            Notes.ForEach(x => NotesPanel.Controls.Add(x));

            UpperPanel.MouseDown += UpperPanel_MouseDown;
            UpperPanel.MouseMove += UpperPanel_MouseMove;

            UpperBorder = new PictureBox()
            {
                Size = new Size(this.Width, 2),
                Location = new Point(0, 30),
                BackColor = Color.FromArgb(255, 56, 56, 56)
            };

            BottomBorder = new PictureBox()
            {
                Size = new Size(this.Width, 15),
                Location = new Point(0, this.Height - 15),
                BackColor = Color.FromArgb(255, 66, 66, 66),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
                Enabled = false,
            };

            NoteLabelBorder = new PictureBox()
            {
                Size = new Size(this.Width - 136, 3),
                Location = new Point(68, 139),
                BackColor = Color.FromArgb(255, 66, 66, 66),
                Enabled = false,
            };
            NoteLabel = new Label()
            {
                Text = "ЗАМЕТКИ",
                Location = new Point(63, 100),
                Size = new Size(90, 30),
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.FromArgb(255, 160, 160, 160),
                Font = new Font("Consolas", 15),
            };
            CountLabel = new Label()
            {
                Text = "ВСЕГО 30",
                Location = new Point(340, 100),
                Size = new Size(400, 30),
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Consolas", 15),
                ForeColor = Color.FromArgb(255, 160, 160, 160),
                Anchor = AnchorStyles.Right | AnchorStyles.Top
            };

            BottomBorder.MouseDown += UpperPanel_MouseDown;
            BottomBorder.MouseMove += UpperPanel_MouseMove;

            MainButtons = new List<Button>();
            MainButtons.AddRange(new List<Button>()
            {
                new Button()
                {
                    Name = "Quit",
                    Font = new Font("Consolas", 13),
                    Text = "✕",
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
                Name = "Note",
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.FromArgb(255, 160, 160, 160),
                Font = new Font("Consolas", 9),
                TextAlign = ContentAlignment.MiddleCenter,
            });

            FuncButtons.Add(new Button()
            {
                Location = new Point(80, 0),
                Size = new Size(100, 30),
                Text = "Настройки",
                Name = "Settings",
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.FromArgb(255, 160, 160, 160),
                Font = new Font("Consolas", 9),
                TextAlign = ContentAlignment.MiddleCenter,
            });

            ControlButtons = new List<Button> { };

            ControlButtons.Add(new Button()
            {
                Location = new Point(15 + 40 * ControlButtons.Count, 5),
                Size = new Size(30, 30),
                Text = "+",
                Name = "NoteAdd",
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.FromArgb(255, 160, 160, 160),
                BackColor = Color.FromArgb(255, 36, 36, 36),
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Consolas", 14),
                Region = new Region(RoundedRect(new Rectangle(0, 0, 30, 30), 16))
            });

            ControlButtons.Add(new Button()
            {
                Location = new Point(15 + 40 * ControlButtons.Count, 5),
                Size = new Size(30, 30),
                Text = "-",
                Name = "NoteRemove",
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.FromArgb(255, 160, 160, 160),
                BackColor = Color.FromArgb(255, 36, 36, 36),
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Consolas", 14),
                Region = new Region(RoundedRect(new Rectangle(0, 0, 30, 30), 16))
            });

            ControlButtons.Add(new Button()
            {
                Location = new Point(15 + 40 * ControlButtons.Count, 5),
                Size = new Size(30, 30),
                Text = "🖋️",
                Name = "NoteEdit",
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.FromArgb(255, 160, 160, 160),
                BackColor = Color.FromArgb(255, 36, 36, 36),
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Consolas", 9),
                Region = new Region(RoundedRect(new Rectangle(0, 0, 30, 30), 16))
            });

            ControlButtons.Add(new Button()
            {
                Location = new Point(15 + 40 * ControlButtons.Count, 5),
                Size = new Size(30, 30),
                Text = "🔎",
                Name = "NoteSearch",
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.FromArgb(255, 160, 160, 160),
                BackColor = Color.FromArgb(255, 36, 36, 36),
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Consolas", 9),
                Region = new Region(RoundedRect(new Rectangle(0, 0, 30, 30), 16))
            });

            SearchPanel = new Panel()
            {
                Size = new Size(30, 30),
                Location = new Point(ControlButtons.Find(x => x.Name == "NoteSearch").Location.X, 5),
                BackColor = Color.FromArgb(255, 36, 36, 36),
                Region = new Region(RoundedRect(new Rectangle(0, 0, 30, 30), 16))
            };

            SearchField = new TextBox()
            {
                Text = "Поиск",
                Name = "SearchField",
                Location = new Point(15, 8),
                Size = new Size(200, 30),
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(255, 36, 36, 36),
                ForeColor = Color.FromArgb(255, 160, 160, 160),
                MaxLength = 50
            };

            SearchField.GotFocus += SearchField_GotFocus;
            SearchField.LostFocus += SearchField_LostFocus;
            SearchPanel.Controls.Add(SearchField);

            ControlButtons.ForEach(x => x.FlatAppearance.BorderSize = 0);
            ControlButtons.ForEach(x => ControlPanel.Controls.Add(x));
            ControlButtons.ForEach(x => x.MouseClick += X_MouseClick2);
            ControlPanel.Controls.Add(SearchPanel);

            FuncButtons.ForEach(x => x.FlatAppearance.BorderSize = 0);
            FuncButtons.ForEach(x => UpperPanel.Controls.Add(x));
            FuncButtons.ForEach(x => x.MouseClick += X_MouseClick1);

            MainButtons.ForEach(x => UpperPanel.Controls.Add(x));
            MainButtons.ForEach(x => x.FlatAppearance.BorderSize = 0);

            MainButtons.ForEach(x => x.MouseEnter += X_MouseEnter);
            MainButtons.ForEach(x => x.MouseLeave += X_MouseLeave);
            MainButtons.ForEach(x => x.MouseClick += X_MouseClick);

            ControlPanelAnim = new Timer();
            ControlPanelAnim.Tick += ControlPanelAnim_Tick;
            ControlPanelAnim.Interval = 1;

            SearchPanelAnim = new Timer();
            SearchPanelAnim.Tick += SearchPanelAnim_Tick;
            SearchPanelAnim.Interval = 1;

            Controls.Add(UpperPanel);
            Controls.Add(BottomBorder);
            Controls.Add(UpperBorder);
            Controls.Add(NoteLabel);
            Controls.Add(CountLabel);
            Controls.Add(NoteLabelBorder);
            Controls.Add(NotesPanel);
            Controls.Add(ControlPanel);
        }

        private void SearchPanelAnim_Tick(object sender, System.EventArgs e)
        {
            FloatTimeOfSearchFieldAnim = 100;
            if (!IsSearchPanelShow)
            {
                if (SearchPanel.Size.Width > 30)
                {
                    SearchPanel.Size = new Size(SearchPanel.Size.Width - FloatTimeOfSearchFieldAnim / 8, SearchPanel.Size.Width);
                    SearchField.Location = new Point(SearchField.Location.X - 1, SearchField.Location.Y);
                    SearchPanel.Region = new Region(RoundedRect(new Rectangle(0, 0, SearchPanel.Width, 30), 16));
                    if (FloatTimeOfSearchFieldAnim > 28) FloatTimeOfSearchFieldAnim -= 25;
                }
                else
                {
                    SearchPanel.Size = new Size(30, SearchPanel.Size.Width);
                    SearchPanel.Region = new Region(RoundedRect(new Rectangle(0, 0, SearchPanel.Width, 30), 16));
                    SearchPanelAnim.Stop();
                }
            }
            else
            {
                if (SearchPanel.Size.Width < 260)
                {
                    SearchPanel.Size = new Size(SearchPanel.Size.Width + FloatTimeOfSearchFieldAnim / 8, SearchPanel.Size.Width);
                    SearchField.Location = new Point(SearchField.Location.X + 1, SearchField.Location.Y);
                    SearchPanel.Region = new Region(RoundedRect(new Rectangle(0, 0, SearchPanel.Width, 30), 16));
                    if (FloatTimeOfSearchFieldAnim > 28) FloatTimeOfSearchFieldAnim -= 25;
                }
                else
                {
                    SearchPanel.Size = new Size(260, SearchPanel.Size.Width);
                    SearchPanel.Region = new Region(RoundedRect(new Rectangle(0, 0, SearchPanel.Width, 30), 16));
                    SearchPanelAnim.Stop();
                }
            }
        }

        private void X_MouseClick2(object sender, MouseEventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "NoteSearch":
                    IsSearchPanelShow = !IsSearchPanelShow;
                    SearchPanelAnim.Start();
                    break;
            }
        }

        private void SearchField_GotFocus(object sender, System.EventArgs e)
        {
            if (SearchField.Text == "Поиск") SearchField.Text = string.Empty;
        }

        private void SearchField_LostFocus(object sender, System.EventArgs e)
        {
            if (SearchField.Text == string.Empty) SearchField.Text = "Поиск";
        }

        private void ControlPanelAnim_Tick(object sender, System.EventArgs e)
        {
            if (ControlPanel.Location.Y < -12)
                ControlPanel.Location = new Point(0, -12);

            if (IsControlPanelShow)
            {
                if (ControlPanel.Location.Y > -12)
                {
                    ControlPanel.Location = new Point(ControlPanel.Location.X, ControlPanel.Location.Y - FloatTimeOfControlPanelAnim / 25);
                    if (FloatTimeOfControlPanelAnim > 32) FloatTimeOfControlPanelAnim -= 7;
                }
                else
                {
                    ControlPanel.Visible = false;
                    ControlPanel.Location = new Point(ControlPanel.Location.X, -12);
                    ControlPanelAnim.Stop();
                }
            }
            else
            {
                ControlPanel.Visible = true;
                if (ControlPanel.Location.Y < 32)
                {
                    ControlPanel.Location = new Point(ControlPanel.Location.X, ControlPanel.Location.Y + FloatTimeOfControlPanelAnim / 25);
                    if (FloatTimeOfControlPanelAnim > 32) FloatTimeOfControlPanelAnim -= 7;
                }
                else
                {
                    ControlPanel.Location = new Point(ControlPanel.Location.X, 32);
                    ControlPanelAnim.Stop();
                }
            }
        }

        private void X_MouseClick1(object sender, MouseEventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "Note":
                    IsControlPanelShow = !IsControlPanelShow;
                    FloatTimeOfControlPanelAnim = 120;
                    ControlPanelAnim.Start();
                    if (IsSearchPanelShow)
                    {
                        IsSearchPanelShow = false;
                        SearchPanelAnim.Start();
                    }
                    break;
            }
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
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
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
            //Cursor.Current = Cursors.Default;
        }

        private void X_MouseEnter(object sender, System.EventArgs e)
        {
            if ((sender as Button).Name == "Quit") MainButtons.Find(x => x.Name == "Quit").ForeColor = Color.Red;
            //Cursor.Current = Cursors.Hand;
        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            UpperPanel.Size = new Size(this.Width, UpperPanel.Height);
            ControlPanel.Size = new Size(this.Width, ControlPanel.Height);
            UpperBorder.Size = new Size(this.Width, UpperBorder.Height);
            BottomBorder.Size = new Size(this.Width, BottomBorder.Height);
            NoteLabelBorder.Size = new Size(this.Width - 136, NoteLabelBorder.Height);

            //Notes.ForEach(x => x.Size = new Size((int)(this.Width / 9.12), (int)(this.Height / 8.84)));
            NotesPanel.Size = new Size(this.Width - 135, this.Height - 199);
            for (int i = 0; i < Notes.Count; i++)
            {
                Notes[i].Size = new Size((int)((this.Width - 136 - this.Width / 64 * 6) / 7), ((this.Height > 569) ? (this.Height - 199 - this.Width / 64 * 4) / 5 : Notes[i].Height));
                Notes[i].Location = new Point(0 + (Notes[i].Width + this.Width / 64) * (i % 7), 0 + (Notes[i].Height + this.Width / 64) * (i / 7));
            }
            //ew Point(0 + 96 * (Notes.Count % 7), 0 + 76 * (Notes.Count / 7)),

            if (this.Height < 87) ControlPanel.Location = new Point(0, this.Height - ControlPanel.Size.Height - 15);
            //if (this.Height < 87) ControlPanel.Location = new Point(0, ControlPanel.Location.Y -1);
            //if (this.Height > 47 && !IsControlPanelShow) ControlPanel.Location = new Point(0, ControlPanel.Location.Y + 1);
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
        private Panel ControlPanel;
        private Panel SearchPanel;
        private List<Button> MainButtons;
        private List<Button> FuncButtons;
        private List<Button> ControlButtons;
        private TextBox SearchField;
        private Label NoteLabel;
        private Label CountLabel;

        private Panel NotesPanel;
        private List<Panel> Notes;

        private PictureBox UpperBorder;
        private PictureBox BottomBorder;
        private PictureBox NoteLabelBorder;
        private Timer ControlPanelAnim;
        private Timer SearchPanelAnim;
        #endregion
    }
}