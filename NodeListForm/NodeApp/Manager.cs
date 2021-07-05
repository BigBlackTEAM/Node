﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NodeListForm
{
    class Manager
    {
        public Panel NotesPanel;
        public List<Notegui> NoteGUIs;
        public Label NoteLabel;
        public Label CountLabel;
        public List<Button> NavigateButtons;

        public int Page;
        public Manager(Control.ControlCollection Controls)
        {
            NoteGUIs = new List<Notegui>();

            NotesPanel = new Panel()
            {
                Size = new Size(658, 370),
                Location = new Point(68, 160),
                BackColor = Color.FromArgb(255, 40, 40, 40),
            };

            NavigateButtons = new List<Button>()
            {
                new Button() {
                Location = new Point(150, 100),
                Size = new Size(30, 30),
                Text = "<",
                Anchor = AnchorStyles.Left | AnchorStyles.Top,
                Name = "NavigateToLeft",
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.FromArgb(255, 160, 160, 160),
                BackColor = Color.FromArgb(255, 66, 66, 66),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Consolas", 9),
                Region = new Region(RoundedRect(new Rectangle(0, 0, 30, 30), 16))
                },

                new Button() {
                Location = new Point(185, 100),
                Size = new Size(30, 30),
                Text = ">",
                Anchor = AnchorStyles.Left | AnchorStyles.Top,
                Name = "NavigateToRight",
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.FromArgb(255, 160, 160, 160),
                BackColor = Color.FromArgb(255, 66, 66, 66),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Consolas", 9),
                Region = new Region(RoundedRect(new Rectangle(0, 0, 30, 30), 16))
                },
            };
            NavigateButtons.ForEach(x => x.FlatAppearance.BorderSize = 0);
            //for (int i = 0; i < 5; i++)
            //{
            //    NoteGUIs.Add(new Notegui(i));
            //}

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
                Text = $"СТРАНИЦА {Page} | ВСЕГО 0",
                Location = new Point(333, 100),
                Size = new Size(400, 30),
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Consolas", 15),
                ForeColor = Color.FromArgb(255, 160, 160, 160),
                Anchor = AnchorStyles.Right | AnchorStyles.Top
            };

            NavigateButtons.ForEach(x => Controls.Add(x));

            Controls.Add(NotesPanel);
            Controls.Add(NoteLabel);
            Controls.Add(CountLabel);
        }
        public void StartInit()
        {
            // Тут должно происходить добавление визуала к созданным ранее запискам при перезапуске приложения

            int Size = 3; // Инициализируется сначала коллекция записок, а потом сюда нужно присвоить значение / или сразу в фор

            for(int i = 0; i < Size; i++)   // Переменная i нужна для того, чтобы задать контролам имена, чтобы можно было обращаться к ним
            {
                this.NoteGUIs.Add(new Notegui(i, "Заголовок", "Основной текст"));       // Пример добавления новой записки
            }

            // После нужно будет добавить в главную форму после создания всех записок нужные ивенты к ним

            // После того, как инициализируешь визуальные записки, вызови метод FinishInit() и EventsForAllNotes()

        }
        public void FinishInit(Control.ControlCollection Controls)
        {
            if (this.Page == 0) NavigateButtons[0].Enabled = false;
            else NavigateButtons[0].Enabled = true;

            if (this.Page == NoteGUIs.Count / 35) NavigateButtons[1].Enabled = false;
            else NavigateButtons[1].Enabled = true;

            NoteGUIs.ForEach(x => NotesPanel.Controls.Add(x.Panel));
            CountLabel.Text = $"СТРАНИЦА {Page + 1} | ВСЕГО {NoteGUIs.Count}";

            NavigateButtons.ForEach(x => x.SendToBack());
            CountLabel.SendToBack();
            NoteLabel.SendToBack();
        }

        public void ChangePage(int Page, Size FormSize)
        {
            this.Page = Page;
            UpdateSize(FormSize);

            if (this.Page == 0) NavigateButtons[0].Enabled = false;
            else NavigateButtons[0].Enabled = true;

            if (this.Page == NoteGUIs.Count / 35) NavigateButtons[1].Enabled = false;
            else NavigateButtons[1].Enabled = true;

            CountLabel.Text = $"СТРАНИЦА {this.Page + 1} | ВСЕГО {NoteGUIs.Count}";
            NoteGUIs.Where(x => x.Page != this.Page).ToList().ForEach(x => x.Panel.Visible = false);
            NoteGUIs.Where(x => x.Page == this.Page).ToList().ForEach(x => x.Panel.Visible = true);
        }
        public void UpdateSize(Size FormSize)
        {
            NotesPanel.Size = new Size(FormSize.Width - 135, FormSize.Height - 199);
            
            //for (int i = Page*35; i < NoteGUIs.Count; i++)
            //{
            //    NoteGUIs[i].Panel.Size = new Size((int)((FormSize.Width - 136 - FormSize.Width / 64 * 6) / 7), ((FormSize.Height > 569) ? (FormSize.Height - 199 - FormSize.Width / 64 * 4) / 5 : NoteGUIs[i].Panel.Height));
            //    NoteGUIs[i].Panel.Location = new Point(0 + (NoteGUIs[i].Panel.Width + FormSize.Width / 64) * (i % 7), 0 + (NoteGUIs[i].Panel.Height + FormSize.Width / 64) * (i % 35 / 7));
            //    NoteGUIs[i].UpdateBorders();
            //}

            NoteGUIs.Where(x => x.Page == this.Page).ToList().ForEach(x => x.Panel.Size = new Size((int)((FormSize.Width - 136 - FormSize.Width / 64 * 6) / 7), ((FormSize.Height > 569) ? (FormSize.Height - 199 - FormSize.Width / 64 * 4) / 5 : x.Panel.Height)));
            NoteGUIs.Where(x => x.Page == this.Page).ToList().ForEach(x => x.Panel.Location = new Point(0 + (x.Panel.Width + FormSize.Width / 64) * (int.Parse(x.Panel.Name) % 7), 0 + (x.Panel.Height + FormSize.Width / 64) * (int.Parse(x.Panel.Name) % 35 / 7)));
            NoteGUIs.Where(x => x.Page == this.Page).ToList().ForEach(x => x.UpdateBorders());
        }
        public void UpdateMinimizeSize(Size FormSize)
        {
            NotesPanel.Size = new Size(FormSize.Width - 135, FormSize.Height - 199);

            NoteGUIs.Where(x => x.Page == this.Page).ToList().ForEach(x => x.Panel.Size = new Size((int)((FormSize.Width - 136 - FormSize.Width / 64 * 6) / 7), (int)(FormSize.Height - 199 - FormSize.Width / 64 * 4) / 5 ));
            NoteGUIs.Where(x => x.Page == this.Page).ToList().ForEach(x => x.Panel.Location = new Point(0 + (x.Panel.Width + FormSize.Width / 64) * (int.Parse(x.Panel.Name) % 7), 0 + (x.Panel.Height + FormSize.Width / 64) * (int.Parse(x.Panel.Name) % 35 / 7)));
            NoteGUIs.Where(x => x.Page == this.Page).ToList().ForEach(x => x.UpdateBorders());
        }
        private void UpdateCount()
        {
            CountLabel.Text = $"СТРАНИЦА {Page + 1} | ВСЕГО {NoteGUIs.Count}";

            if (this.Page == NoteGUIs.Count / 35) NavigateButtons[1].Enabled = false;
            else NavigateButtons[1].Enabled = true;
        }
        private void UpdateNames()
        {
            for (int i = 0; i < NoteGUIs.Count; i++)
            {
                NoteGUIs[i].Panel.Name = i.ToString();
                NoteGUIs[i].Delete.Name = i.ToString();
                NoteGUIs[i].Edit.Name = i.ToString();
                NoteGUIs[i].Caption.Name = i.ToString();
                NoteGUIs[i].MainText.Name = i.ToString();

                int NewPage = i / 35;
                if (NoteGUIs[i].Page != NewPage) NoteGUIs[i].Panel.Visible = true;

                NoteGUIs[i].Page = i / 35;
            }
        }
        public void AddNote(Size FormSize)
        {
            this.NoteGUIs.Add(new Notegui(NoteGUIs.Count));
            UpdateSize(FormSize);
            NotesPanel.Controls.Add(NoteGUIs[NoteGUIs.Count - 1].Panel);
            if (NoteGUIs.Last().Page != this.Page) NoteGUIs.Last().Panel.Visible = false;
            UpdateCount();
            if (NoteGUIs.Count % 35 == 1 && NoteGUIs.Count != 1) ChangePage(this.Page + 1, FormSize);
        }
        public void DeleteNote(Notegui note, Size FormSize)
        {
            NoteGUIs.Remove(note);
            NotesPanel.Controls.Remove(note.Panel);
            UpdateSize(FormSize);
            UpdateCount();
            UpdateNames();
            UpdateSize(FormSize);
        }
        public void Search(string filter)
        {
            //NoteGUIs.Where(x => !x.Caption.Text.Contains(filter)).ToList().ForEach(x=> x.Panel.Visible = false);
            //NoteGUIs.Where(x => !x.Caption.Text.Contains(filter)).ToList().ForEach(x=> x.Panel.Visible = false);
        }
        private GraphicsPath RoundedRect(Rectangle baseRect, int radius)
        {
            var diameter = radius * 2;
            var sz = new Size(diameter, diameter);
            var arc = new Rectangle(baseRect.Location, sz);
            var path = new GraphicsPath();

            path.AddArc(arc, 180, 90);

            arc.X = baseRect.Right - diameter;
            path.AddArc(arc, 270, 90);

            arc.Y = baseRect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            arc.X = baseRect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}