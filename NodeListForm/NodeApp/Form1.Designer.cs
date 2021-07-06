using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace NodeListForm
{
    partial class Form1
    {
        static bool IsDarkMode = true;

        Point point;
        bool IsControlPanelShow = true;
        bool IsSearchPanelShow = false;
        bool IsDeleting = false;
        bool IsEditing = false;
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
            this.ForeColor = IsDarkMode ? Color.FromArgb(255, 238, 238, 238) : Color.FromArgb(255, 25, 25, 25);
            this.ShowIcon = false;
            this.BackColor = IsDarkMode ? Color.FromArgb(255, 25, 25, 25) : Color.FromArgb(255, 228, 228, 228);
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
                BackColor = IsDarkMode ? Color.FromArgb(255, 66, 66, 66) : Color.FromArgb(255, 254, 254, 254),
            };
            UpperPanel.MouseDoubleClick += UpperPanel_MouseDoubleClick;

            ControlPanel = new Panel()
            {
                Size = new Size(this.Width, 40),
                Location = new Point(0, -12),
                BackColor = IsDarkMode ? Color.FromArgb(255, 55, 55, 55) : Color.FromArgb(255, 200, 200, 200),
                Visible = false,
            };

            //NotesPanel = new Panel()
            //{
            //    Size = new Size(658, 370),
            //    Location = new Point(68, 160),
            //    BackColor = Color.FromArgb(255, 40, 40, 40),
            //};

            //NoteGUIs = new List<Notegui>();
            //for (int i = 0; i < 4; i++)
            //{
            //    NoteGUIs.Add(new Notegui(i));
            //}
            //NoteGUIs.ForEach(x => NotesPanel.Controls.Add(x.Panel));

            UpperPanel.MouseDown += UpperPanel_MouseDown;
            UpperPanel.MouseMove += UpperPanel_MouseMove;

            UpperBorder = new PictureBox()
            {
                Size = new Size(this.Width, 2),
                Location = new Point(0, 30),
                BackColor = IsDarkMode ? Color.FromArgb(255, 56, 56, 56) : Color.FromArgb(255, 180, 180, 180),
            };

            BottomBorder = new PictureBox()
            {
                Size = new Size(this.Width, 15),
                Location = new Point(0, this.Height - 15),
                BackColor = IsDarkMode ? Color.FromArgb(255, 66, 66, 66) : Color.FromArgb(255, 254, 254, 254),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
                Enabled = false,
            };

            NoteLabelBorder = new PictureBox()
            {
                Size = new Size(this.Width - 136, 3),
                Location = new Point(68, 139),
                BackColor = IsDarkMode ? Color.FromArgb(255, 66, 66, 66) : Color.FromArgb(255, 180, 180, 180),
                Enabled = false,
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
                    ForeColor = IsDarkMode? Color.FromArgb(255, 160, 160, 160):Color.FromArgb(255, 6, 6, 6),
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
                    ForeColor = IsDarkMode? Color.FromArgb(255, 160, 160, 160):Color.FromArgb(255, 6, 6, 6),
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
                    ForeColor = IsDarkMode? Color.FromArgb(255, 160, 160, 160):Color.FromArgb(255, 6, 6, 6),
                    Location = new Point(this.Width-90, 0),
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Anchor = AnchorStyles.Right,
                }
            });

            FuncButtons = new List<Button> { };

            FuncButtons.Add(new Button()
            {
                Location = new Point(120 * FuncButtons.Count + 30, 0),
                Size = new Size(65, 30),
                Text = "Заметка",
                Name = "Note",
                FlatStyle = FlatStyle.Flat,
                ForeColor = IsDarkMode ? Color.FromArgb(255, 160, 160, 160) : Color.FromArgb(255, 6, 6, 6),
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
                ForeColor = IsDarkMode ? Color.FromArgb(255, 160, 160, 160) : Color.FromArgb(255, 6, 6, 6),
                Font = new Font("Consolas", 9),
                Enabled = false,
                Visible = false,
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
                ForeColor = IsDarkMode ? Color.FromArgb(255, 160, 160, 160) : Color.FromArgb(255, 16, 16, 16),
                BackColor = IsDarkMode ? Color.FromArgb(255, 25, 25, 25) : Color.FromArgb(255, 240, 240, 240),
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
                ForeColor = IsDarkMode ? Color.FromArgb(255, 160, 160, 160) : Color.FromArgb(255, 16, 16, 16),
                BackColor = IsDarkMode ? Color.FromArgb(255, 25, 25, 25) : Color.FromArgb(255, 240, 240, 240),
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
                ForeColor = IsDarkMode ? Color.FromArgb(255, 160, 160, 160) : Color.FromArgb(255, 16, 16, 16),
                BackColor = IsDarkMode ? Color.FromArgb(255, 25, 25, 25) : Color.FromArgb(255, 240, 240, 240),
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
                ForeColor = IsDarkMode ? Color.FromArgb(255, 160, 160, 160) : Color.FromArgb(255, 16, 16, 16),
                BackColor = IsDarkMode ? Color.FromArgb(255, 25, 25, 25) : Color.FromArgb(255, 240, 240, 240),
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Consolas", 9),
                Region = new Region(RoundedRect(new Rectangle(0, 0, 30, 30), 16))
            });

            SearchPanel = new Panel()
            {
                Size = new Size(30, 30),
                Location = new Point(ControlButtons.Find(x => x.Name == "NoteSearch").Location.X, 5),
                BackColor = IsDarkMode ? Color.FromArgb(255, 25, 25, 25) : Color.FromArgb(255, 240, 240, 240),
                Region = new Region(RoundedRect(new Rectangle(0, 0, 30, 30), 16))
            };

            SearchField = new TextBox()
            {
                Text = "Поиск",
                Name = "SearchField",
                Location = new Point(15, 8),
                Size = new Size(200, 30),
                BorderStyle = BorderStyle.None,
                ForeColor = IsDarkMode ? Color.FromArgb(255, 160, 160, 160) : Color.FromArgb(255, 16, 16, 16),
                BackColor = IsDarkMode ? Color.FromArgb(255, 25, 25, 25) : Color.FromArgb(255, 240, 240, 240),
                MaxLength = 50
            };

            Background = new PictureBox()
            {
                Size = new Size(this.Width, this.Height),
                Location = new Point(0, 30),
                BackColor = IsDarkMode ? Color.FromArgb(255, 56, 56, 56) : Color.FromArgb(255, 170, 170, 170),
            };

            Theme = new Button()
            {
                Location = new Point(8, 8),
                Size = new Size(14, 14),
                Name = "Theme",
                FlatStyle = FlatStyle.Flat,
                BackColor = IsDarkMode ? Color.FromArgb(255, 255, 205, 66) : Color.FromArgb(255, 38, 37, 31),
                TextAlign = ContentAlignment.MiddleRight,
                Region = new Region(RoundedRect(new Rectangle(0, 0, 14, 14), 8))
            };
            Theme.FlatAppearance.BorderSize = 0;

            Theme.MouseClick += (sender, args) =>
            {
                IsDarkMode = !IsDarkMode;
                Theme.BackColor = IsDarkMode ? Color.FromArgb(255, 255, 205, 66) : Color.FromArgb(255, 38, 37, 31);
                ChangeTheme();
            };

            UpperPanel.Controls.Add(Theme);

            SearchField.GotFocus += SearchField_GotFocus;
            SearchField.LostFocus += SearchField_LostFocus;
            SearchField.TextChanged += SearchField_TextChanged;
            SearchField.KeyPress += SearchField_KeyPress;

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

            this.Opacity = 0.12;

            AppStartAnim = new Timer();
            AppStartAnim.Interval = 1;
            AppStartAnim.Tick += ChangeOpacity;
            AppStartAnim.Start();

            manager = new Manager(Controls, IsDarkMode);
            manager.NoteGUIs.ForEach(x => x.Delete.MouseClick += NoteDelete_MouseClick);
            manager.NavigateButtons.ForEach(x => x.MouseClick += Navigate_MouseClick);

            Controls.Add(UpperPanel);
            Controls.Add(BottomBorder);
            Controls.Add(UpperBorder);
            Controls.Add(NoteLabelBorder);




            manager.FinishInit(Controls);       // Метод 
                                                // Где-то тут нужно будет вызвать метод EventsForAllNotes()



            Controls.Add(ControlPanel);
        }

        private void EventsForAllNotes()        // Вот этот метод нужно будет вызвать для добавления ивентов
        {
            manager.NoteGUIs.ForEach(x => x.Panel.MouseClick += Panel_MouseClick);
            manager.NoteGUIs.ForEach(x => x.Caption.MouseClick += Panel_MouseClick);
            manager.NoteGUIs.ForEach(x => x.MainText.MouseClick += Panel_MouseClick);

            manager.NoteGUIs.ForEach(x => x.Panel.MouseEnter += Panel_MouseEnter);
            manager.NoteGUIs.ForEach(x => x.Caption.MouseEnter += Panel_MouseEnter);
            manager.NoteGUIs.ForEach(x => x.MainText.MouseEnter += Panel_MouseEnter);

            manager.NoteGUIs.ForEach(x => x.Panel.MouseLeave += Panel_MouseLeave);
            manager.NoteGUIs.ForEach(x => x.Caption.MouseLeave += Panel_MouseLeave);
            manager.NoteGUIs.ForEach(x => x.MainText.MouseLeave += Panel_MouseLeave);

            manager.NoteGUIs.ForEach(x => x.Edit.MouseClick += Edit_MouseClick);
            manager.NoteGUIs.ForEach(x => x.Delete.MouseClick += NoteDelete_MouseClick);
        }

        private void ChangeOpacity(object sender, System.EventArgs e)
        {
            this.Opacity += 0.04;
            if (this.Opacity >= 1)
                AppStartAnim.Stop();
        }

        private void Navigate_MouseClick(object sender, MouseEventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "NavigateToLeft":
                    manager.ChangePage(manager.Page - 1, this.Size);
                    break;
                case "NavigateToRight":
                    manager.ChangePage(manager.Page + 1, this.Size);
                    break;
            }
        }

        private void SearchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) manager.NoteGUIs.ForEach(x => x.Panel.Visible = true);
        }

        private void SearchField_TextChanged(object sender, System.EventArgs e)
        {
            //manager.Search((sender as TextBox).Text);
            var search = (sender as TextBox).Text;
            //manager.NoteGUIs.Clear();

            while (manager.NoteGUIs.Count != 0)
            {
                manager.DeleteNote(manager.NoteGUIs.Last(), this.Size);
            }
            foreach (var item in this.nodeManager.SearchByName(search))
            {
                manager.AddNote(this.Size);
                manager.NoteGUIs.Last().Caption.Text = item.Name;
                manager.NoteGUIs.Last().MainText.Text = item.Text;
            }
            EventsForAllNotes();
            manager.ChangePage(0, this.Size);


            if ((sender as TextBox).Text == "Поиск") manager.NoteGUIs.ForEach(x => x.Panel.Visible = true);
        }
        private void AddEventsForLastNote()
        {
            manager.NoteGUIs.Last().Panel.MouseClick += Panel_MouseClick;
            manager.NoteGUIs.Last().Caption.MouseClick += Panel_MouseClick;
            manager.NoteGUIs.Last().MainText.MouseClick += Panel_MouseClick;

            manager.NoteGUIs.Last().Panel.MouseEnter += Panel_MouseEnter;
            manager.NoteGUIs.Last().Caption.MouseEnter += Panel_MouseEnter;
            manager.NoteGUIs.Last().MainText.MouseEnter += Panel_MouseEnter;

            manager.NoteGUIs.Last().Panel.MouseLeave += Panel_MouseLeave;
            manager.NoteGUIs.Last().Caption.MouseLeave += Panel_MouseLeave;
            manager.NoteGUIs.Last().MainText.MouseLeave += Panel_MouseLeave;

            manager.NoteGUIs.Last().Edit.MouseClick += Edit_MouseClick;
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
            this.ActiveControl = null;
            switch ((sender as Button).Name)
            {
                case "NoteAdd":                 // При нажатии сюда должна добавляться новая записка
                    AddMode();                  // Этот метод убирает режим добавления (Не влияет на механизм добавления)
                    AddEventsForLastNote();     // Добавляются ивенты для последней записки

                    FormEdit FormEdit = new FormEdit(IsDarkMode);

                    FormEdit.Caption.Text = "Заголовок записки";            // Не изменять
                    FormEdit.MainText.Text = "Основной текст записки";      // Не изменять

                    FormEdit.Date.Text = "";                               // Сюда нужно будет класть значение даты с библиотеки записок

                    FormEdit.ShowDialog();

                    

                    manager.NoteGUIs.Last().Caption.Text = FormEdit.Caption.Text;           // Тут будет храниться заголовок записки
                    manager.NoteGUIs.Last().MainText.Text = FormEdit.MainText.Text;         // Тут будет храниться основной текст записки

                    if (!Directory.Exists("Nodes"))
                    {
                        Directory.CreateDirectory("Nodes");
                    }

                    if (!File.Exists("Nodes/" + FormEdit.Caption.Text + ".txt"))
                    {
                        File.Create("Nodes/" + FormEdit.Caption.Text + ".txt").Close();
                    }
                    File.WriteAllText("Nodes/" + FormEdit.Caption.Text + ".txt", FormEdit.MainText.Text);
                    this.nodeManager.Nodes.Add(new LogicLib.Node(FormEdit.Caption.Text, FormEdit.MainText.Text));
                    this.nodeManager.Nodes.Last().CreationTime = DateTime.Now;

                    //manager.NoteGUIs.Last().MainText.Text = FormEdit.Date.Text;           
                    //Не знаю, нужно ли добавлять изменение даты, но если что, в FormEdit.Designer.cs измени ReadOnly у Date на true

                    break;
                case "NoteSearch":
                    SearchMode();           // Активирует/Деактивирует режим поиска
                    break;
                case "NoteRemove":
                    DeleteMode();           // Активирует/Деактивирует режим удаления
                    break;
                case "NoteEdit":
                    EditMode();             // Активирует/Деактивирует режим изменения
                    break;
            }
        }

        private void Edit_MouseClick(object sender, MouseEventArgs e)
        {
            FormEdit FormEdit;

            string Caption = manager.NoteGUIs.Find(x => x.Edit.Name == (sender as Button).Name).Caption.Text;
            string MainText = manager.NoteGUIs.Find(x => x.Edit.Name == (sender as Button).Name).MainText.Text;
            string Date = "06.07.2021";

            FormEdit = new FormEdit(IsDarkMode, Caption, MainText, Date);

            FormEdit.ShowDialog();

            //manager.NoteGUIs.Find(x => x.Edit.Name == (sender as Button).Name).Caption.ForeColor = FormEdit.CaptionColor;
            //manager.NoteGUIs.Find(x => x.Edit.Name == (sender as Button).Name).MainText.ForeColor = FormEdit.MainTextColor;
            //manager.NoteGUIs.Find(x => x.Edit.Name == (sender as Button).Name).Panel.ForeColor = FormEdit.PanelColor;
            //manager.NoteGUIs.Find(x => x.Edit.Name == (sender as Button).Name).MainColor = FormEdit.PanelColor;

            manager.NoteGUIs.Find(x => x.Edit.Name == (sender as Button).Name).Caption.Text = FormEdit.Caption.Text;
            manager.NoteGUIs.Find(x => x.Edit.Name == (sender as Button).Name).MainText.Text = FormEdit.MainText.Text;

            EditMode();
        }

        private void Panel_MouseLeave(object sender, System.EventArgs e)
        {
            if (sender is Panel)
                (sender as Panel).BackColor = IsDarkMode ? Color.FromArgb(255, 45, 45, 45) : Color.FromArgb(255, 255, 255, 255);
        }
        private void Panel_MouseEnter(object sender, System.EventArgs e)
        {
            if (sender is Panel)
                (sender as Panel).BackColor = IsDarkMode ? Color.FromArgb(255, 55, 55, 55) : Color.FromArgb(255, 196, 196, 200);
            else if (sender is Label)
            {
                (sender as Label).Parent.BackColor = IsDarkMode ? Color.FromArgb(255, 55, 55, 55) : Color.FromArgb(255, 196, 196, 200);
            }
        }

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            NoteForm Note;

            string Caption = string.Empty;
            string MainText = string.Empty;
            string Date = string.Empty;

            if (sender is Panel)
            {
                Caption = manager.NoteGUIs.Find(x => x.Panel.Name == (sender as Panel).Name).Caption.Text;
                MainText = manager.NoteGUIs.Find(x => x.Panel.Name == (sender as Panel).Name).MainText.Text;
                Date = "06.07.2021";
            }
            else
            {
                Caption = manager.NoteGUIs.Find(x => x.Caption.Name == (sender as Label).Name).Caption.Text;
                MainText = manager.NoteGUIs.Find(x => x.Caption.Name == (sender as Label).Name).MainText.Text;
                Date = "06.07.2021";
            }

            Note = new NoteForm(IsDarkMode, Caption, MainText, Date);

            Note.Show();
        }

        private void AddMode()
        {
            ChangeNoteModes(false, false);
            manager.AddNote(this.Size);
            manager.NoteGUIs.Last().Delete.MouseClick += NoteDelete_MouseClick;
        }

        private void NoteDelete_MouseClick(object sender, MouseEventArgs e)
        {
            this.nodeManager.Nodes.RemoveAt(Convert.ToInt32((sender as Button).Name));
            //MessageBox.Show((sender as Button).Name);
            manager.DeleteNote(manager.NoteGUIs.Find(x => x.Panel.Name == (sender as Button).Name), this.Size);
            ChangeNoteModes(false, true);

            Directory.Delete("Nodes", true);
            Directory.CreateDirectory("Nodes");
            foreach (var item in this.nodeManager.Nodes)
            {
                File.Create("Nodes/" + item.Name + ".txt").Close();
                File.WriteAllText("Nodes/" + item.Name + ".txt", item.Text);
            }

        }

        private void SearchMode()
        {
            ChangeNoteModes(false, false);
            IsSearchPanelShow = !IsSearchPanelShow;
            SearchPanelAnim.Start();
        }
        private void DeleteMode()
        {
            ChangeNoteModes(false, !IsDeleting);
            IsSearchPanelShow = false;
            SearchPanelAnim.Start();
        }
        private void EditMode()
        {
            ChangeNoteModes(!IsEditing, false);
            IsSearchPanelShow = false;
            SearchPanelAnim.Start();
        }
        private void ChangeNoteModes(bool IsEditing, bool IsDeleting)
        {
            this.IsEditing = IsEditing;
            this.IsDeleting = IsDeleting;
            ControlButtons.Find(x => x.Name == "NoteRemove").ForeColor = IsDeleting ? Color.FromArgb(255, 230, 60, 60) : (IsDarkMode ? Color.FromArgb(255, 160, 160, 160) : Color.FromArgb(255, 6, 6, 6));
            ControlButtons.Find(x => x.Name == "NoteEdit").ForeColor = IsEditing ? Color.FromArgb(180, 0, 122, 204) : (IsDarkMode ? Color.FromArgb(255, 160, 160, 160) : Color.FromArgb(255, 6, 6, 6));
            manager.NoteGUIs.ForEach(x => x.Edit.Visible = this.IsEditing);
            manager.NoteGUIs.ForEach(x => x.Delete.Visible = this.IsDeleting);
        }

        private void SearchField_GotFocus(object sender, System.EventArgs e)
        {
            if (SearchField.Text == "Поиск") SearchField.Text = string.Empty;
        }
        private void SearchField_LostFocus(object sender, System.EventArgs e)
        {
            while (manager.NoteGUIs.Count != 0)
            {
                manager.DeleteNote(manager.NoteGUIs.Last(), this.Size);
            }
            if (SearchField.Text == string.Empty) SearchField.Text = "Поиск";
            foreach (var item in this.nodeManager.Nodes)
            {
                manager.AddNote(this.Size);
                manager.NoteGUIs.Last().Caption.Text = item.Name;
                manager.NoteGUIs.Last().MainText.Text = item.Text;
            }
            EventsForAllNotes();
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
                manager.UpdateMinimizeSize(this.Size);
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
            if ((sender as Button).Name == "Quit") MainButtons.Find(x => x.Name == "Quit").ForeColor = IsDarkMode ? Color.FromArgb(255, 160, 160, 160) : Color.FromArgb(255, 6, 6, 6);
        }
        private void X_MouseEnter(object sender, System.EventArgs e)
        {
            if ((sender as Button).Name == "Quit") MainButtons.Find(x => x.Name == "Quit").ForeColor = Color.Red;
        }
        private void Form1_Resize(object sender, System.EventArgs e)
        {
            UpperPanel.Size = new Size(this.Width, UpperPanel.Height);
            ControlPanel.Size = new Size(this.Width, ControlPanel.Height);
            UpperBorder.Size = new Size(this.Width, UpperBorder.Height);
            BottomBorder.Size = new Size(this.Width, BottomBorder.Height);
            NoteLabelBorder.Size = new Size(this.Width - 136, NoteLabelBorder.Height);

            manager.UpdateSize(this.Size);
            if (this.Height < 87) ControlPanel.Location = new Point(0, this.Height - ControlPanel.Size.Height - 15);
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
                    else
                    {
                        this.WindowState = FormWindowState.Normal;
                        manager.UpdateMinimizeSize(this.Size);
                    }
                    break;
            }
        }

        private void ChangeTheme()
        {
            this.ForeColor = IsDarkMode ? Color.FromArgb(255, 238, 238, 238) : Color.FromArgb(255, 25, 25, 25);
            this.BackColor = IsDarkMode ? Color.FromArgb(255, 25, 25, 25) : Color.FromArgb(255, 228, 228, 228);
            UpperPanel.BackColor = IsDarkMode ? Color.FromArgb(255, 66, 66, 66) : Color.FromArgb(255, 254, 254, 254);
            ControlPanel.BackColor = IsDarkMode ? Color.FromArgb(255, 55, 55, 55) : Color.FromArgb(255, 200, 200, 200);
            UpperBorder.BackColor = IsDarkMode ? Color.FromArgb(255, 56, 56, 56) : Color.FromArgb(255, 180, 180, 180);
            BottomBorder.BackColor = IsDarkMode ? Color.FromArgb(255, 66, 66, 66) : Color.FromArgb(255, 254, 254, 254);
            NoteLabelBorder.BackColor = IsDarkMode ? Color.FromArgb(255, 66, 66, 66) : Color.FromArgb(255, 180, 180, 180);
            MainButtons.ForEach(x=>x.ForeColor = IsDarkMode ? Color.FromArgb(255, 160, 160, 160) : Color.FromArgb(255, 6, 6, 6));
            FuncButtons.ForEach(x => x.ForeColor = IsDarkMode ? Color.FromArgb(255, 160, 160, 160) : Color.FromArgb(255, 6, 6, 6));
            ControlButtons.ForEach(x => x.ForeColor = IsDarkMode ? Color.FromArgb(255, 160, 160, 160) : Color.FromArgb(255, 16, 16, 16));
            ControlButtons.ForEach(x => x.BackColor = IsDarkMode ? Color.FromArgb(255, 25, 25, 25) : Color.FromArgb(255, 240, 240, 240));
            SearchPanel.BackColor = IsDarkMode ? Color.FromArgb(255, 25, 25, 25) : Color.FromArgb(255, 240, 240, 240);
            SearchField.ForeColor = IsDarkMode ? Color.FromArgb(255, 160, 160, 160) : Color.FromArgb(255, 16, 16, 16);
            SearchField.BackColor = IsDarkMode ? Color.FromArgb(255, 25, 25, 25) : Color.FromArgb(255, 240, 240, 240);
            Background.BackColor = IsDarkMode ? Color.FromArgb(255, 56, 56, 56) : Color.FromArgb(255, 170, 170, 170);

            File.Create("Mode.txt").Close();
            File.WriteAllText("Mode.txt",IsDarkMode.ToString());

            manager.UpdateTheme(IsDarkMode);
            manager.NoteGUIs.ForEach(x => x.ChangeColors(IsDarkMode));
        }

        private Panel UpperPanel;
        private Panel ControlPanel;
        private Panel SearchPanel;
        private List<Button> MainButtons;
        private List<Button> FuncButtons;
        private List<Button> ControlButtons;
        private TextBox SearchField;

        private Manager manager;

        private PictureBox UpperBorder;
        private PictureBox BottomBorder;
        private PictureBox NoteLabelBorder;
        private Timer ControlPanelAnim;
        private Timer SearchPanelAnim;
        private Timer AppStartAnim;

        private Button Theme;

        private PictureBox Background;
        #endregion
    }
}