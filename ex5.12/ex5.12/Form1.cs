using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex5._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBox2.Text);
            int y = Convert.ToInt16 (textBox3.Text);
            if (textBox1.Text == "К")
            {
                Button b = new Button();
                b.Location = new Point(x, y);
                b.Text = "Кнопка";
                Controls.Add(b);
            }
            if (textBox1.Text == "П")
            {
                TextBox t = new TextBox();
                t.Location = new Point(x, y);
                t.Text = "Поле ввода";
                Controls.Add(t);
            }
            if (textBox1.Text == "М")
            {
                Label l = new Label();
                l.Location = new Point(x, y);
                l.Text = "Метка";
                Controls.Add(l);
            }
        }
    }
}
