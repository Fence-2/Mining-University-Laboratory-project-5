using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MouseClick += Form1_Click;
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Click(object sender, MouseEventArgs e)
        {
            Button b = new Button();
            b.Location = e.Location;
            b.Size = new Size(60, 25);
            b.Text = e.X.ToString() + "," + e.Y.ToString();
            b.Parent = this;
        }
    }
}
