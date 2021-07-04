using System;
using System.Collections.Generic;
using System.Drawing;
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
        public Manager(Control.ControlCollection Controls)
        {
            NoteGUIs = new List<Notegui>();

            NotesPanel = new Panel()
            {
                Size = new Size(658, 370),
                Location = new Point(68, 160),
                BackColor = Color.FromArgb(255, 40, 40, 40),
            };

            for (int i = 0; i < 5; i++)
            {
                NoteGUIs.Add(new Notegui(i));
            }

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
                Text = "ВСЕГО 0",
                Location = new Point(340, 100),
                Size = new Size(400, 30),
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Consolas", 15),
                ForeColor = Color.FromArgb(255, 160, 160, 160),
                Anchor = AnchorStyles.Right | AnchorStyles.Top
            };

            Controls.Add(NotesPanel);
            Controls.Add(NoteLabel);
            Controls.Add(CountLabel);
        }
        public void Init(Control.ControlCollection Controls)
        {
            NoteGUIs.ForEach(x => NotesPanel.Controls.Add(x.Panel));
            CountLabel.Text = "ВСЕГО " + (NoteGUIs.Count).ToString();
        }
        public void UpdateSize(Size FormSize)
        {
            NotesPanel.Size = new Size(FormSize.Width - 135, FormSize.Height - 199);
            for (int i = 0; i < NoteGUIs.Count; i++)
            {
                NoteGUIs[i].Panel.Size = new Size((int)((FormSize.Width - 136 - FormSize.Width / 64 * 6) / 7), ((FormSize.Height > 569) ? (FormSize.Height - 199 - FormSize.Width / 64 * 4) / 5 : NoteGUIs[i].Panel.Height));
                NoteGUIs[i].Panel.Location = new Point(0 + (NoteGUIs[i].Panel.Width + FormSize.Width / 64) * (i % 7), 0 + (NoteGUIs[i].Panel.Height + FormSize.Width / 64) * (i / 7));
                NoteGUIs[i].UpdateBorders();
            }
        }
        private void UpdateCount()
        {
            CountLabel.Text = "ВСЕГО " + (NoteGUIs.Count).ToString();
        }
        private void UpdateNames()
        {
            for (int i = 0; i < NoteGUIs.Count; i++)
            {
                NoteGUIs[i].Panel.Name = i.ToString();
                NoteGUIs[i].Delete.Name = i.ToString();
                NoteGUIs[i].Edit.Name = i.ToString();
            }
        }
        public void AddNote(Size FormSize)
        {
            this.NoteGUIs.Add(new Notegui(NoteGUIs.Count));
            UpdateSize(FormSize);
            NotesPanel.Controls.Add(NoteGUIs[NoteGUIs.Count - 1].Panel);
            UpdateCount();
        }
        public void DeleteNote(Notegui note, Size FormSize)
        {
            NoteGUIs.Remove(note);
            NotesPanel.Controls.Remove(note.Panel);
            UpdateSize(FormSize);
            UpdateCount();
            UpdateNames();
        }
        public void Search(string filter)
        {
            NoteGUIs.Where(x => !x.Caption.Text.Contains(filter)).ToList().ForEach(x=> x.Panel.Visible = false);
            //NoteGUIs.Where(x => !x.Caption.Text.Contains(filter)).ToList().ForEach(x=> x.Panel.Visible = false);
        }
    }
}
