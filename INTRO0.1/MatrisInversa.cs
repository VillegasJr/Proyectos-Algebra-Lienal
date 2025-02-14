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
            r1 = (m1 - m2) * inversa1;
            A11.Text = r1.ToString();

            int m3 = dosx(n21, n33);
            int m4 = dosx(n31, n23);
            r2 = (m3 - m4) * inversa2;
            A12.Text = r2.ToString();

            int m5 = dosx(n21, n32);
            int m6 = dosx(n31, n22);
            r3 = (m5 - m6) * inversa3;
            A13.Text = r3.ToString();

            // Second fila 
            m1 = dosx(n12, n33);
            m2 = dosx(n32, n13);
            r4 = (m1 - m2) * inversa4;
            A21.Text = r4.ToString();

            m3 = dosx(n11, n33);
            m4 = dosx(n31, n13);
            r5 = (m3 - m4) * inversa5;
            A22.Text = r5.ToString();

            m5 = dosx(n11, n32);
            m6 = dosx(n31, n12);
            r6 = (m5 - m6) * inversa6;
            A23.Text = r6.ToString();

            // Third fila
            m1 = dosx(n12, n23);
            m2 = dosx(n22, n13);
            r7 = (m1 - m2) * inversa7;
            A31.Text = r7.ToString();

            m3 = dosx(n11, n23);
            m4 = dosx(n21, n13);
            r8 = (m3 - m4) * inversa8;
            A32.Text = r8.ToString();

            m5 = dosx(n11, n22);
            m6 = dosx(n21, n12);
            r9 = (m5 - m6) * inversa9;
            A33.Text = r9.ToString();

            // Matriz inversa 
            decimal div1 = r1 / det1;
            r_1.Text = div1.ToString();
            decimal div2 = r2 / det1;
            r_2.Text = div2.ToString();
            decimal div3 = r3 / det1;
            r_3.Text = div3.ToString();
            decimal div4 = r4 / det1;
            r_4.Text = div4.ToString();
            decimal div5 = r5 / det1;
            r_5.Text = div5.ToString();
            decimal div6 = r6 / det1;
            r_6.Text = div6.ToString();
            decimal div7 = r7 / det1;
            r_7.Text = div7.ToString();
            decimal div8 = r8 / det1;
            r_8.Text = div8.ToString();
            decimal div9 = r9 / det1;
            r_9.Text = div9.ToString();
           // if (div1 || div2 || div3 || div4 || div5 || div6 || div7 || div8|| div9 )
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
