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
    public partial class Matris_Inversa : Form
    {
        public Matris_Inversa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n11 = Convert.ToInt32(x11.Text);
            int n12 = Convert.ToInt32(x21.Text);
            int n13 = Convert.ToInt32(x31.Text);

            int n21 = Convert.ToInt32(y12.Text);
            int n22 = Convert.ToInt32(y22.Text);
            int n23 = Convert.ToInt32(y32.Text);

            int n31 = Convert.ToInt32(z13.Text);
            int n32 = Convert.ToInt32(z23.Text);
            int n33 = Convert.ToInt32(z33.Text);

            int det1 = 0;
            //int det2 = 0;
            //int det3 = 0;

            int inversa1 = 1;
            int inversa2 = -1;
            int inversa3 = 1;
            int inversa4 =-1;
            int inversa5 = 1;
            int inversa6 = -1;
            int inversa7 = 1;
            int inversa8 = -1;
            int inversa9 = 1;

            int r1 = 0;
            int r2 = 0;
            int r3 = 0;
            int r4 = 0;
            int r5 = 0;
            int r6 = 0;
            int r7 = 0;
            int r8 = 0;
            int r9 = 0;

            // Calcular determinante de matriz general inversa 

            int d1 = sarrus(n11, n22, n33);
            int d2 = sarrus(n12, n23, n31);
            int d3 = sarrus(n13, n21, n32);
            int s = Suma(d1, d2, d3);
            int d4 = sarrus(n31, n22, n13);
            int d5 = sarrus(n32, n23, n11);
            int d6 = sarrus(n33, n21, n12);
            int i = Suma(d4, d5, d6);
            det1 = s - i;

            decimal iv = det1 * inversa1;
            lb_2.Text = iv.ToString();

            // Matriz adjunta (^t) traspuesta.

            // First fila 
            int m1 = dosx(n22, n33);
            int m2 = dosx(n32, n23);
            r1 = m1 - m2;

            int m3 = dosx(n21, n33);
            int m4 = dosx(n31, n23);
            r2 = m3 - m4;

            int m5 = dosx(n21, n32);
            int m6 = dosx(n31, n22);
            r3 = m5 - m6;

            // Second fila 
            m1 = dosx(n12, n33);
            m2 = dosx(n32, n13);
            r4 = m1 - m2;

            m3 = dosx(n11, n33);
            m4 = dosx(n31, n13);
            r5 = m3 - m4;

            m5 = dosx(n11, n32);
            m6 = dosx(n31, n12);
            r6 = m5 - m6;

            // Third fila
            m1 = dosx(n12, n23);
            m2 = dosx(n22, n13);
            r7 = m1 - m2;

            m3 = dosx(n11, n23);
            m4 = dosx(n21, n13);
            r8 = m3 - m4;

            m5 = dosx(n11, n22);
            m6 = dosx(n21, n12);
            r9 = m5 - m6;

        }
        private int sarrus(int num11, int num12, int num13)
        {
            int cal = num11 * num12 * num13;
            return cal;
        }
        private int Suma(int num11, int num12, int num13)
        {
            int suma = num11 + num12 + num13;
            return suma;
        }
        private int dosx(int num11, int num12)
        {
            int cal = num11 * num12;
            return cal;
        }
    }
}
