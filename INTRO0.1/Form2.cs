using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTRO0._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void calcSuma(object sender, EventArgs e)
        {
            int num2 = Convert.ToInt32(lb_1.Text);
            int num1 = Convert.ToInt32(lb_2.Text);

            int suma = num1 + num2;

            lb_text.Text = suma.ToString();
        }
        private void calcResta(object sender, EventArgs e)
        {
            int num2 = Convert.ToInt32(lb_1.Text);
            int num1 = Convert.ToInt32(lb_2.Text);

            int resta = num1 - num2;

            lb_text.Text = resta.ToString();
        }
        private void calcMulti(object sender, EventArgs e)
        {
            int num2 = Convert.ToInt32(lb_1.Text);
            int num1 = Convert.ToInt32(lb_2.Text);

            int multi = num1 * num2;

            lb_text.Text = multi.ToString();
        }
        private void calcDivision(object sender, EventArgs e)
        {
            decimal num2 = Convert.ToInt32(lb_1.Text);
            decimal num1 = Convert.ToInt32(lb_2.Text);

            decimal division = num1 / num2;

            lb_text.Text = division.ToString();
        }
    }
}