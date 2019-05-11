using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex5._13
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox2.Text);
            int y = Convert.ToInt32(textBox3.Text);
            int h = Convert.ToInt32(textBox1.Text);
            int w = Convert.ToInt32(textBox4.Text);
            Label t = new Label();
            t.Location = new Point(x, y);
            t.Text = "Метка";
            t.Size = new Size(h, w);
            Controls.Add(t);
            if (h<50 || w<50)
            {
                count++;
                Text = ($"Количество маленьких меток: {count}");
            }
        }
    }
}
