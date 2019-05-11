using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex5._15
{
    public partial class Form1 : Form
    {
        private Random randGen;

        public Form1()
        {
            InitializeComponent();
            randGen = new Random();
        }

        private bool IsHaveCollisions(Control ctrl, int x, int y)
        {
            foreach (Control c in this.Controls)
            {
                if ((Enumerable.Range(c.Location.X, c.Width)
                      .Intersect(Enumerable.Range(x, ctrl.Width)).Count() != 0) &&
                    (Enumerable.Range(c.Location.Y, c.Height)
                      .Intersect(Enumerable.Range(y, ctrl.Height)).Count() != 0))
                {
                    return true;
                }
            }
            return false;
        }

        private void DropNextControl()
        {
            Control ctrl;
            if (randGen.Next(0, 11) > 5)
                ctrl = new Button { Text = "Button" };
            else
                ctrl = new Label { Text = "Label", AutoSize = true };
            int x = randGen.Next(0, Size.Width - ctrl.Width);
            int y = randGen.Next(0, Size.Height - ctrl.Height);

            int displacmentTries = 4000;  // количество проверок
            while (IsHaveCollisions(ctrl, x, y) && --displacmentTries > 0)
            {
                x = randGen.Next(0, Size.Width - ctrl.Width);
                y = randGen.Next(0, Size.Height - ctrl.Height);
            }

            if (displacmentTries == 0)
            {
                MessageBox.Show("Больше нет места.");
                return;
            }

            ctrl.Location = new Point(x, y);
            Controls.Add(ctrl);
            Text = "Количество попыток: " +
                (4001 - displacmentTries).ToString();
        }          
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            DropNextControl();
        }
    }
}
