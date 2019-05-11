using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5._18
{
    public partial class Form1 : Form
    {
        int x = 1, y = 1;
        public Form1()
        {
            InitializeComponent();
            MouseClick += Form1_MouseClick;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Controls.Clear();
            x = y = 1;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TextBox t = new TextBox();
                t.Text = "T";
                t.Size = new Size(30, 30);
                t.Location = new Point(x, y);
                t.Multiline = true;
                Controls.Add(t);
            }
            else
            {
                Button b = new Button();
                b.Text = "B";
                b.Size = new Size(30, 30);
                b.Location = new Point(x, y);
                Controls.Add(b);
            }
            x = x + 30;
            y = y + 30;
        }
    }
}
