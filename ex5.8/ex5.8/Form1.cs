using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5._8
{
    public partial class Form1 : Form
    {
        int a1 = 0;
        int a2 = 0;
        int a3 = 0;
        int all = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                int j = r.Next(1, 4);

                if (j == 1)
                {
                    Button b = new Button();
                    int l = r.Next(1, 400);
                    b.Size = new Size(l, 25);
                    b.Text = "Button";
                    int x = r.Next(0, 720);
                    int y = i / 3;
                    b.Location = new Point(x, (y * 30) + 30);
                    b.Parent = this;
                    a1++;
                }
                if (j == 2)
                {
                    TextBox b = new TextBox();
                    int l = r.Next(1, 400);
                    b.Size = new Size(l, 25);
                    b.Text = "Textbox";
                    int x = r.Next(0, 720);
                    int y = i / 3;
                    b.Location = new Point(x, (y * 30) + 30);
                    b.Parent = this;
                    a2++;
                }
                if (j == 3)
                {
                    Label b = new Label();
                    int l = r.Next(1, 400);
                    b.Size = new Size(l, 25);
                    b.BackColor = Color.LightGray;
                    b.Text = "Label";
                    int x = r.Next(0, 720);
                    int y = i / 3;
                    b.Location = new Point(x, (y * 30) + 30);
                    b.Parent = this;
                    a3++;
                }


            }
            all = all + 20;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Количество всех элементов: " + all + Environment.NewLine + Environment.NewLine+ "Количество кнопок: " + a1 + Environment.NewLine + "Количество текстовых полей: " + a2 + Environment.NewLine + "Количество надписей: " + a3);

        }
    }
}
