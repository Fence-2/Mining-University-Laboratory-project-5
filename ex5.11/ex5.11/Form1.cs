using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex5._11
{

    public partial class Form1 : Form
    {
        Control b = new Control();
        Control t = new Control();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int i = r.Next(0, 2);
            if (i == 0)
            {
                Button b = new Button();
                b.Size = new Size(60, 25);
                int x = r.Next(0, 800);
                int y = r.Next(0, 600);
                b.Location = new Point(x, y);
                b.Text = "Button";
                Controls.Add(b);
            }
            else
            {
                TextBox t = new TextBox();
                t.Size = new Size(120, 20);
                int x = r.Next(0, 800);
                int y = r.Next(0, 600);
                t.Location = new Point(x, y);
                t.Text = "TextBox";
                t.Multiline = true;
                Controls.Add(t);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is TextBox)
                {
                    (c as TextBox).Height *= 2;
                }
        }
    }
}
