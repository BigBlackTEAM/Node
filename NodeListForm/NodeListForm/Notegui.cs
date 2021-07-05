﻿using System;
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
        public Panel Panel;
        public Label Caption;
        public Label MainText;
        public Button Delete;
        public Button Edit;
        public int Page;

        public Notegui(int Num)
        {
            Page = Num / 35;
            Panel = new Panel()
            {
                Size = new Size(87, 65),
                Cursor = Cursors.Hand,
                Location = new Point(0 + 96 * (Num % 7), 0 + 76 * ((Num % 35) / 7)),
                BackColor = Color.FromArgb(255, 45, 45, 45),
                Name = Num.ToString()
            };
            Caption = new Label()
            {
                Parent = Panel,
                Name = Panel.Name,
                Cursor = Cursors.Hand,
                ForeColor = Color.FromArgb(255, 240, 240, 240),
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
                ForeColor = Color.FromArgb(255, 200, 200, 200),
                Location = new Point(5, 35),
                Size = new Size(77, 30),
                //Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Text = "Основной текст записки",
                Font = new Font("Consolas", 7)
            };
            Delete = new Button()
            {
                ForeColor = Color.White,
                BackColor = Color.FromArgb(180, 206, 17, 38),
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
                BackColor = Color.FromArgb(180, 0, 122, 204),
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
        public Notegui(int Num, string Caption, string MainText) : this(Num)
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
        public void ChangeColor(Color color)
        {
            this.Panel.BackColor = color;
        }
    }
}