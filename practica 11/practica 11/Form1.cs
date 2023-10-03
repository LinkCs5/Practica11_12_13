using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_11
{
    public partial class Form1 : Form
    {
        private int[,] matriz;
        private int[] sumaFila;
        private double[] promedioFila;
        private int[] sumaColumna;
        private double[] promedioColumna;
        public Form1()
        {
            InitializeComponent();
            matriz = new int[5, 10];
            sumaFila = new int[5];
            promedioFila = new double[5];
            sumaColumna = new int[10];
            promedioColumna = new double[10];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    int numero;
                    do
                    {
                        numero = random.Next(100);
                    } while (NumeroRepetidoEnMatriz(numero, i, j));

                    matriz[i, j] = numero;
                }
            }

                // Calcular la suma y el promedio de cada fila
                for (int i = 0; i < matriz.GetLength(0); i++)
            {
                sumaFila[i] = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    sumaFila[i] += matriz[i, j];
                }
                promedioFila[i] = sumaFila[i] / matriz.GetLength(1);
            }

            // Calcular la suma y el promedio de cada columna
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                sumaColumna[j] = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    sumaColumna[j] += matriz[i, j];
                }
                promedioColumna[j] = sumaColumna[j] / matriz.GetLength(0);
            }

            // Imprimir la matriz
            label1.Text = "";
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    label1.Text += matriz[i, j].ToString() + " ";
                }
                label1.Text += "\n";
            }

            // Imprimir la suma y el promedio de cada fila
            label2.Text = "";
            for (int i = 0; i < sumaFila.Length; i++)
            {
                label2.Text += "Fila " + i + ": Suma = " + sumaFila[i] + " Promedio = " + promedioFila[i].ToString("0.0") + "\n";
            }

            // Imprimir la suma y el promedio de cada columna
            label3.Text = "";
            for (int i = 0; i < sumaColumna.Length; i++)
            {
                label3.Text += "Columna " + i + ": Suma = " + sumaColumna[i] + " Promedio = " + promedioColumna[i].ToString("0.0") + "\n";
            }
        }
        private bool NumeroRepetidoEnMatriz(int numero, int fila, int columna)
        {
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == numero)
                    {
                        return true; // El número ya existe en la matriz
                    }
                }
            }

            for (int j = 0; j < columna; j++)
            {
                if (matriz[fila, j] == numero)
                {
                    return true; // El número ya existe en la matriz
                }
            }
            return false;
        }
    }
}
