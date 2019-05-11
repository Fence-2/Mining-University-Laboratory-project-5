using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MouseClick += Form1_MouseClick;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Location.X < (Size.Width / 2))
            {
                Button b = new Button();
                b.Size = new Size(60, 25);
                b.Text = "Button";
                b.Location = e.Location;
                b.Parent = this;
            }
            else
            {
                TextBox t = new TextBox();
                t.Size = new Size(120, 20);
                t.Text = "TextBox";
                t.Location = e.Location;
                t.Parent = this;
            }
        }
    }
}
