using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5._6
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            MouseClick += Form1_Click;
        }
        private void Form1_Click(object sender, MouseEventArgs e)
        {
            if (i % 2 == 0)
            {
                    Button b = new Button();
                    b.Location = new Point(e.X, e.Y);
                    b.Size = new Size(60, 25);
                    b.Text = "Button";
                    b.Parent = this;
            }
            else
            {
                TextBox b = new TextBox();
                b.Location = new Point(e.X-125, e.Y-20);
                b.Size = new Size(125, 20);
                b.Text = "Textbox";
                b.Parent = this;
            }
            i++;
        }
    }
    
}
