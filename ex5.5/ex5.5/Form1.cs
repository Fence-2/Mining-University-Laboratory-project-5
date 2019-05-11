using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int x = 11;
            int y = 8;
            int r = 60;
            for (int i = 0; i < x * y; i++)
            {
                Button b = new Button();
                b.Location = new Point( ((i % x + 1) * (r+30)) - 55, ((i / x + 1) * (r-5)) - 30 );
                //(((i % x + 1) * r) - 56, ((i / x + 1) * (r - 30)) - 24); - для красивой расстановки
                b.Size = new Size(60, 25);
                b.Text = "Button";
                b.Parent = this;
            }
        }
    }
}
