using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5._9
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
            Label l = new Label();


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

                    l.Location = e.Location;
                    l.Size = new Size(50, 20);
                    l.Text = "label";
                    Controls.Add(l);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < 10; i++)
                {
                    foreach (Control c in Controls)
                        if (c is Button)
                            Controls.Remove(c as Button);
                }
            }



        }
    }
}
