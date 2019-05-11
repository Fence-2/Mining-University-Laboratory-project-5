using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.MouseClick += panel1_MouseClick;
            panel2.MouseClick += panel2_MouseClick;
            panel3.MouseClick += panel3_MouseClick;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.LightBlue;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.LightPink;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.LightGreen;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = 4;
            int y = 13;
            int r = 66;
            for (int i = 0; i < x * y; i++)
            {
                Button b = new Button();
                b.Location = new Point(((i % x + 1) * r)-56, ((i / x + 1) * (r - 30)) - 24);
                b.Size = new Size(60, 25);
                b.Parent = panel2;
            }
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            int x = 4;
            int y = 13;
            int r = 66;
            for (int i = 0; i < x * y; i++)
            {
                TextBox b = new TextBox();
                b.Location = new Point(((i % x + 1) * r)-56, ((i / x + 1) * (r-30))-24);
                b.Size = new Size(60, 25);
                b.Parent = panel3;
            }
        }
        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            int x = 4;
            int y = 13;
            int r = 66;
            for (int i = 0; i < x * y; i++)
            {
                Label b = new Label();
                b.Location = new Point(((i % x + 1) * r) - 56, ((i / x + 1) * (r - 30)) - 24);
                b.Size = new Size(60, 25);
                b.Text = "Label";
                b.Parent = panel1;
            }

        }
        /* Button b = new Button();
b.Size = new Size(60, 25);
b.Text = "Button";
if (x % 6 == 0) { y1 = y1 + 26; f = 0; }
x++;
b.Location = new Point(f, y1 + 5);
b.Parent = panel1;
f = f + 60; */
    }
}
