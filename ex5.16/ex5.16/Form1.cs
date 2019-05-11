using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex5._16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int j = 0; j < 40; j++)
            {
                int i = r.Next(0, 2);
                if (i == 0)
                {
                    Button b = new Button();
                    b.Size = new Size(60, 25);
                    int x = r.Next(0, Size.Width);
                    int y = r.Next(0, Size.Width);
                    b.Location = new Point(x, y);
                    b.Text = "Button";
                    Controls.Add(b);
                    b.MouseMove += Buttonb_MouseEnter;

                }
                else
                {
                    TextBox t = new TextBox();
                    t.Size = new Size(120, 20);
                    int x = r.Next(0, Size.Width);
                    int y = r.Next(0, Size.Width);
                    t.Location = new Point(x, y);
                    t.Text = "TextBox";
                    t.Multiline = true;
                    Controls.Add(t);
                    t.MouseMove += Textboxt_MouseEnter;
                }
            }
        }
        
        private void Buttonb_MouseEnter(Object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            b.Dispose();

        }
        private void Textboxt_MouseEnter(Object sender, MouseEventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Dispose();
        }

        
    }
}
