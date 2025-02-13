using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTRO0._1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num11 = Convert.ToInt32(lb_x1.Text);
            int num12 = Convert.ToInt32(lb_x2.Text);
            int num13 = Convert.ToInt32(lb_x3.Text);

            int num21 = Convert.ToInt32(lb_y1.Text);
            int num22 = Convert.ToInt32(lb_y2.Text);
            int num23 = Convert.ToInt32(lb_y3.Text);

            int num31 = Convert.ToInt32(lb_z1.Text);
            int num32 = Convert.ToInt32(lb_z2.Text);
            int num33 = Convert.ToInt32(lb_z3.Text);

            int num41 = Convert.ToInt32(lb_i1.Text);
            int num42 = Convert.ToInt32(lb_i2.Text);
            int num43 = Convert.ToInt32(lb_i3.Text);

            int d1 = calDiagonal(num11, num22, num33);
            int d2 = calDiagonal(num12, num23, num31);
            int d3 = calDiagonal(num13, num21, num32);
            int ds = calsum(d1, d2, d3);

            int d4 = calDiagonal(num31, num22, num13);
            int d5 = calDiagonal(num32, num23, num11);
            int d6 = calDiagonal(num33, num21, num12);
            int di = calsum(d4, d5, d6);
            decimal det = ds - di;

            //CALCULAR X
            //Det. Superior
            d1 = calDiagonal(num41, num22, num33);
            d2 = calDiagonal(num42, num23, num31);
            d3 = calDiagonal(num43, num21, num32);
            ds = calsum(d1, d2, d3);
            //Det. Inferior
            d4 = calDiagonal(num31, num22, num43);
            d5 = calDiagonal(num32, num23, num41);
            d6 = calDiagonal(num33, num21, num42);
            di = calsum(d4, d5, d6);
            //calcular determinante
            decimal Det_x = ds - di;
            decimal x = Det_x / det;
            ////////////////////////////////////////////////////////////////////////////////////////////
            //CALCULAR Y
            //Det. Superior 
            d1 = calDiagonal(num11, num42, num33);
            d2 = calDiagonal(num12, num43, num31);
            d3 = calDiagonal(num13, num41, num32);
            ds = calsum(d1, d2, d3);

            //Det. Inferior
            d4 = calDiagonal(num31, num42, num13);
            d5 = calDiagonal(num32, num43, num11);
            d6 = calDiagonal(num33, num41, num12);
            di = calsum(d4, d5, d6);
            //calcular determinante 
            decimal Det_y = ds - di;
            decimal y = Det_y / det;
            ///////////////////////////////////////////////////////////////////////////////////////////
            //CALCULAR Z
            //Det. Superior
            d1 = calDiagonal(num11, num22, num43);
            d2 = calDiagonal(num12, num23, num41);
            d3 = calDiagonal(num13, num21, num42);
            ds = calsum(d1, d2, d3);

            // Def. Inferior 
            d4 = calDiagonal(num41, num22, num13);
            d5 = calDiagonal(num42, num23, num11);
            d6 = calDiagonal(num43, num21, num12);
            di = calsum(d4, d5, d6);
            //Calcular determinante
            decimal Det_z = ds - di;
            decimal z = Det_z / det;

            //calcular la sumatoria de la determinate superior.
            // int ds = (num11 * num22 * num33) +
            //   (num21 * num32 * num13) + (num31 * num12 * num23);


            //calcular sumatoria de la determinate intefior.
            //  int di = (num31 * num22 * num13) +
            //    (num32 * num23 * num11) + (num21 * num12 * num33);

            //resta del resultado, determunante superior menos la determinante inferior
            // int det = ds - di;

            label1.Text = det.ToString();
            Det_X.Text = x.ToString();
            Det_Y.Text = y.ToString();
            Det_Z.Text = z.ToString();
            //limpiar las casillas.
        }
         //ESTO ES SOLO UN COMENTARIO DE PUEBA 
        // Calcular la sumatoria de diagonales
        private int calDiagonal(int num1, int num2, int num3)
        {
            int diagonal = num1 * num2 * num3;
            return diagonal;
        }
        private int calsum(int diagonal1, int diagonal2, int diagonal3)
        {
            int sumatoria = diagonal1 + diagonal2 + diagonal3;
            return sumatoria;
        }
        private void limpiar_Click(object sender, EventArgs e)
        {
            lb_x1.Clear();
            lb_x2.Clear();
            lb_x3.Clear();
            lb_y1.Clear();
            lb_y2.Clear();
            lb_y3.Clear();
            lb_z1.Clear();
            lb_z2.Clear();
            lb_z3.Clear();
            lb_i1.Clear();
            lb_i2.Clear();
            lb_i3.Clear();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
