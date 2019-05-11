using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex5._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MouseClick += Form1_Click;
        }
        private void Form1_Click(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            Button b = new Button();
            TextBox t = new TextBox();


            if (e.Button == MouseButtons.Left)
            {
                int k = r.Next(0, 2);
                if (k == 1)
                {
                    b.Location = e.Location;
                    b.Size = new Size(60, 25);
                    b.Text = "Button";
                    Controls.Add(b);
                }
                if (k == 0)
                {

                    t.Location = e.Location;
                    t.Size = new Size(100, 20);
                    t.Text = "Textbox";
                    Controls.Add(t);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                Controls.Clear();

            }
        }
    }
}
