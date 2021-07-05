using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NodeListForm
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        public FormEdit(string Caption, string MainText, string Date)
        {
            InitializeComponent();

            this.Load += Form1_Load;
            this.ResizeRedraw = true;
            this.DoubleBuffered = true;

            this.Date.Text = Date;
            this.Caption.Text = Caption;
            this.MainText.Text = MainText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Region = new Region(RoundedRect(new Rectangle(0, 0, this.Width, this.Height), 10));
            AppStartAnim.Start();
        }

        public GraphicsPath RoundedRect(Rectangle baseRect, int radius)
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
