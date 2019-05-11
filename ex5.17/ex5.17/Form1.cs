using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5._17
{
    public partial class Form1 : Form
    {
        int x = 1, y = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (x <= Width-70)
            {
                Random rnd = new Random();
                int i = rnd.Next(1, 4);
                if (i == 1)
                {
                    Button b = new Button();
                    b.Location = new Point(x, y);
                    b.Size = new Size(60, 25);
                    b.Text = "Button";
                    Controls.Add(b);
                }
                if (i == 2)
                {
                    Label l = new Label();
                    l.Text = "Label";
                    l.Location = new Point(x, y);
                    l.Size = new Size(60, 25);
                    Controls.Add(l);
                }
                if (i == 3)
                {
                    TextBox t = new TextBox();
                    t.Location = new Point(x, y);
                    t.Text = "Textbox";
                    t.Size = new Size(60, 25);
                    Controls.Add(t);
                }
                x = x + 70;
            }
            else
            {
                x = 1;
                y = y + 50;
            }
        }
    }
}
