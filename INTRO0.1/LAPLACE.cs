using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace INTRO0._1
{
    public partial class LAPLACE : Form
    {
        public LAPLACE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PENDIENTEEEEE NO DA BIEN LOS RESULTADOS 
            int num11 = Convert.ToInt32(box11.Text);
            int num12 = Convert.ToInt32(box21.Text);
            int num13 = Convert.ToInt32(box31.Text);
            int num14 = Convert.ToInt32(box41.Text);

            int num21 = Convert.ToInt32(box12.Text);
            int num22 = Convert.ToInt32(box22.Text);
            int num23 = Convert.ToInt32(box32.Text);
            int num24 = Convert.ToInt32(box42.Text);

            int num31 = Convert.ToInt32(box13.Text);
            int num32 = Convert.ToInt32(box23.Text);
            int num33 = Convert.ToInt32(box33.Text);
            int num34 = Convert.ToInt32(box43.Text);

            int num41 = Convert.ToInt32(box14.Text);
            int num42 = Convert.ToInt32(box24.Text);
            int num43 = Convert.ToInt32(box34.Text);
            int num44 = Convert.ToInt32(box44.Text);

            int determinante1 = 0;
            int determinante2 = 0;
            int determinante3 = 0;
            int determinante4 = 0;

            int adj11 = 1;
            int adj12 = -1;
            int adj13 = 1;
            int adj14 = -1;

            int adj21 = -1;
            int adj22 = 1;
            int adj23 = -1;
            int adj24 = 1;

            int adj31 = 1;
            int adj32 = -1;
            int adj33 = 1;
            int adj34 = -1;

            int adj41 = -1;
            int adj42 = 1;
            int adj43 = -1;
            int adj44 = 1;

            // Elegir fila a eliminr →
            // Eliminar la columna ↓

            // Calcular Sarrus 
            // Determinante 1 dia. superior
            int d1 = calDiagonal(num22, num33, num44);
            int d2 = calDiagonal(num23, num34, num41);
            int d3 = calDiagonal(num24, num32, num43);
            int ds = calsum(d1, d2, d3);
            // DIagonal inferior
            int d4 = calDiagonal(num42, num33, num24);
            int d5 = calDiagonal(num43, num34, num22);
            int d6 = calDiagonal(num44, num32, num23);
            int di = calsum(d4, d5, d6);
            //Calcular determinante
            determinante1 = ds - di;

            // Determinante 2 Diagonal superior
            d1 = calDiagonal(num12, num33, num44);
            d2 = calDiagonal(num13, num34, num42);
            d1 = calDiagonal(num14, num32, num43);
            d1 = calsum(d1, d2, d3);
            // DIagonal inferior
            d4 = calDiagonal(num42, num33, num14);
            d5 = calDiagonal(num43, num34, num12);
            d6 = calDiagonal(num44, num32, num13);
            di = calsum(d4, d5, d6);
            //Calcular determinante
            determinante2 = ds - di;

            // Determinante 3 Diagonal Superior 
            d1 = calDiagonal(num12, num23, num44);
            d2 = calDiagonal(num13, num24, num42);
            d1 = calDiagonal(num14, num22, num43);
            d1 = calsum(d1, d2, d3);
            // DIagonal inferior
            d4 = calDiagonal(num42, num23, num14);
            d5 = calDiagonal(num43, num24, num12);
            d6 = calDiagonal(num44, num22, num13);
            di = calsum(d4, d5, d6);
            //Calcular determinante
            determinante3 = ds - di;

            // Determinate 4 Diagonal superior 
            d1 = calDiagonal(num12, num23, num34);
            d2 = calDiagonal(num13, num24, num32);
            d1 = calDiagonal(num14, num22, num33);
            d1 = calsum(d1, d2, d3);
            // DIagonal inferior
            d4 = calDiagonal(num32, num23, num14);
            d5 = calDiagonal(num33, num24, num12);
            d6 = calDiagonal(num34, num22, num13);
            di = calsum(d4, d5, d6);
            //Calcular dterminante
            determinante4 = ds - di;

            int det = (num11 * (determinante1 * adj11)) + (num21 * (determinante2 * adj21)) +
                (num31 * (determinante3 * adj31)) + (num41 * (determinante4 * adj41));
            resultado.Text = det.ToString();

            Det_1.Text = determinante1.ToString();
            Det_2.Text = determinante2.ToString();
            Det_3.Text = determinante3.ToString();
            Det_4.Text = determinante4.ToString();
        }
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
        private int multi_suma_res(int val1, int val2, int val3, int val4)
        {
            int val = val1 - val2 + val3 - val4;
            int valor = val;
            return valor;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            box11.Clear();
            box12.Clear();
            box13.Clear();
            box14.Clear();
            box21.Clear();
            box22.Clear();
            box23.Clear();
            box24.Clear();
            box31.Clear();
            box32.Clear();
            box33.Clear();
            box34.Clear();
            box41.Clear();
            box42.Clear();
            box43.Clear();
            box44.Clear();

            //FALTA MEJORAS EN EL CALCULO 
        }
    }
}
