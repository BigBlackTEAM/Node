using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NodeListForm
{
    class Notegui
    {
        bool IsDarkMode;

        public Panel Panel;
        public Label Caption;
        public Label MainText;
        public Button Delete;
        public Button Edit;
        public int Page;

        public Notegui(int Num, bool IsDarkMode)
        {
            this.IsDarkMode = IsDarkMode;

            Page = Num / 35;
            Panel = new Panel()
            {
                Size = new Size(87, 65),
                Cursor = Cursors.Hand,
                Location = new Point(0 + 96 * (Num % 7), 0 + 76 * ((Num % 35) / 7)),
                BackColor = IsDarkMode ? Color.FromArgb(255, 45, 45, 45) : Color.FromArgb(255, 255, 255, 255),
                Name = Num.ToString(),
            };
            Caption = new Label()
            {
                Parent = Panel,
                Name = Panel.Name,
                Cursor = Cursors.Hand,
                ForeColor = IsDarkMode ? Color.FromArgb(255, 240, 240, 240) : Color.FromArgb(255, 26, 26, 26),
                Location = new Point(5, 5),
                Size = new Size(77, 30),
                //Text = $"Список {Num} вещей, которые нужно успеть сделать до следующей недели по просьбе родителей",
                Text = "Заголовок записки",
                Font = new Font("Consolas", 8)
            };
            MainText = new Label()
            {
                Parent = Panel,
                Name = Panel.Name,
                Cursor = Cursors.Hand,
                ForeColor = IsDarkMode ? Color.FromArgb(255, 240, 240, 240) : Color.FromArgb(255, 56, 56, 56),
                Location = new Point(5, 35),
                Size = new Size(77, 30),
                //Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Text = "Основной текст записки",
                Font = new Font("Consolas", 7)
            };
            Delete = new Button()
            {
                ForeColor = Color.White,
                BackColor = IsDarkMode ? Color.FromArgb(180, 206, 17, 38) : Color.FromArgb(200, 206, 17, 38),
                Text = "✕",
                Name = this.Panel.Name,
                Size = new Size(Panel.Width, Panel.Height),
                Font = new Font("Consolas", 15),
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleCenter,
                Visible = false
            };
            Delete.FlatAppearance.BorderSize = 0;

            Edit = new Button()
            {
                ForeColor = Color.White,
                BackColor = IsDarkMode ? Color.FromArgb(180, 0, 122, 204) : Color.FromArgb(200, 0, 122, 204),
                Text = "🖋",
                Name = this.Panel.Name,
                Size = new Size(Panel.Width, Panel.Height),
                Font = new Font("Consolas", 15),
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleCenter,
                Visible = false
            };
            Edit.FlatAppearance.BorderSize = 0;

            Panel.Controls.Add(Edit);
            Panel.Controls.Add(Delete);
            Panel.Controls.Add(MainText);
            Panel.Controls.Add(Caption);
        }
        public Notegui(int Num, bool IsDarkMode, string Caption, string MainText) : this(Num, IsDarkMode)
        {
            this.Caption.Text = Caption;
            this.MainText.Text = MainText;
        }
        public void UpdateBorders()
        {
            this.Caption.Size = new Size(this.Panel.Width - 10, (int)((float)this.Panel.Height / 2.6));
            this.Caption.Font = new Font("Consolas", 8 + this.Caption.Width / 50);
            this.MainText.Location = new Point(5, this.Panel.Height / 2);
            this.MainText.Size = new Size(this.Panel.Width - 10, (int)((float)this.Panel.Height / 2.16));
            this.MainText.Font = new Font("Consolas", 7 + this.MainText.Width / 50);
            this.Delete.Size = new Size(this.Panel.Width, this.Panel.Height);
            this.Edit.Size = new Size(this.Panel.Width, this.Panel.Height);
        }
        public void ChangeColors(bool IsDarkMode)
        {
            this.IsDarkMode = IsDarkMode;

            Panel.BackColor = IsDarkMode ? Color.FromArgb(255, 45, 45, 45) : Color.FromArgb(255, 255, 255, 255);
            Caption.ForeColor = IsDarkMode ? Color.FromArgb(255, 240, 240, 240) : Color.FromArgb(255, 26, 26, 26);
            MainText.ForeColor = IsDarkMode ? Color.FromArgb(255, 240, 240, 240) : Color.FromArgb(255, 56, 56, 56);
            Delete.BackColor = IsDarkMode ? Color.FromArgb(180, 206, 17, 38) : Color.FromArgb(200, 206, 17, 38);
            Edit.BackColor = IsDarkMode ? Color.FromArgb(180, 0, 122, 204) : Color.FromArgb(200, 0, 122, 204);

        }
    }
}