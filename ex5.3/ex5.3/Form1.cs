using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5._3
{
    public partial class Form1 : Form
    {
        int f = 0;
        int p = 372;
        int x = 0;
        int z = 0;
        int y1 = -26;
        int y2 = -21;

        public Form1()
        {
            InitializeComponent();
            MouseClick += Form1_Click;
            panel1.MouseClick += panel1_Click;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.LightBlue;
        }

        private void Form1_Click(object sender, MouseEventArgs e)
        {
            TextBox b = new TextBox();
            b.Size = new Size(125, 20);
            b.Text = "Textbox";
            if (z % 3 == 0) { y2 = y2 + 26; p = 372; };
            z++;
            b.Location = new Point(p, y2 + 5);
            b.Parent = this;
            p = p + 125;
            
        }
        private void panel1_Click(object sender, MouseEventArgs e)
        {
            Button b = new Button();
            b.Size = new Size(60, 25);
            b.Text = "Button";
            if (x % 6 == 0) { y1 = y1 + 26; f = 0; }
            x++;
            b.Location = new Point(f, y1 + 5);
            b.Parent = panel1;
            f = f + 60;
        }

        
    }
}
