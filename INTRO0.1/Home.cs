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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LAPLACE laplace = new LAPLACE();
            laplace.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Matris_Inversa Matrizinversa = new Matris_Inversa();
            Matrizinversa.Show();
        }
    }
}
