using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5._7
{
    public partial class Form1 : Form
    {
        int a1 = 0;
        int a2 = 0;
        int a3 = 0;
        int a4 = 0;
        int a5 = 0;
        int panel = 0;
        int form = 0;
        int all = 0;
        public Form1()
        {
            InitializeComponent();
           /* MouseClick += Form1_Click; */
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.LightBlue;
        }
         /* private void Form1_Click(object sender, MouseEventArgs e)
        {
            Button b = new Button();
            b.Size = new Size(60, 25);
            b.Location = new Point(e.X, e.Y);
            b.Text = e.X.ToString() + "," + e.Y.ToString();                 Для определения координат
            b.Parent = this;

        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {

                int j = r.Next(1, 6);
                int k = r.Next(0, 10);

                if (j == 1)
                {
                    Button b = new Button();
                    b.Size = new Size(60, 25);
                    b.Text = "Button";
                    int x = r.Next(0, 720);
                    int y = r.Next(0, 235);
                    b.Location = new Point(x, y);
                    if (k % 2 == 0)
                    {
                        b.Parent = this;
                        form++;
                    }
                    else
                    {
                        b.Parent = panel1;
                        panel++;
                    }
                    a1++;
                }
                if (j == 2)
                {
                    TextBox b = new TextBox();
                    b.Size = new Size(125, 20);
                    b.Text = "Textbox";
                    int x = r.Next(0, 720);
                    int y = r.Next(0, 235);
                    b.Location = new Point(x, y);
                    if (k % 2 == 0)
                    {
                        b.Parent = this;
                        form++;
                    }
                    else
                    {
                        b.Parent = panel1;
                        panel++;
                    }
                    a2++;
                }
                if (j == 3)
                {
                    Label b = new Label();
                    b.Size = new Size(50, 20);
                    b.Text = "Label";
                    int x = r.Next(0, 720);
                    int y = r.Next(0, 235);
                    b.Location = new Point(x, y);
                    if (k % 2 == 0)
                    {
                        b.Parent = this;
                        form++;
                    }
                    else
                    {
                        b.Parent = panel1;
                        panel++;
                    }
                    a3++;
                }
                if (j == 4)
                {
                    CheckBox b = new CheckBox();
                    int x = r.Next(0, 720);
                    int y = r.Next(0, 235);
                    b.Location = new Point(x, y);
                    if (k % 2 == 0)
                    {
                        b.Parent = this;
                        form++;
                    }
                    else
                    {
                        b.Parent = panel1;
                        panel++;
                    }
                    a4++;
                }
                if (j == 5)
                {
                    RadioButton b = new RadioButton();
                    int x = r.Next(0, 720);
                    int y = r.Next(0, 235);
                    b.Location = new Point(x, y);
                    if (k % 2 == 0)
                    {
                        b.Parent = this;
                        form++;
                    }
                    else
                    {
                        b.Parent = panel1;
                        panel++;
                    }
                    a5++;
                }

            }
            all = all + 20;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Количество всех элементов: " + all + Environment.NewLine + Environment.NewLine + "Количество элементов на форме: " + form + Environment.NewLine + "Количество элементов на панели: " + panel + Environment.NewLine + Environment.NewLine + "Количество кнопок: " + a1 + Environment.NewLine + "Количество текстовых полей: " + a2 + Environment.NewLine + "Количество надписей: " + a3 + Environment.NewLine + "Количество флажков: " + a4 + Environment.NewLine + "Количество радиокнопок: " + a5 + Environment.NewLine);
        }
    }
}
