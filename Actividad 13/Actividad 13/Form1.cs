using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_13
{
    public partial class Form1 : Form
    {
        private Calificaciones calificaciones;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumeroAlumnos.Text, out int numeroAlumnos) &&
                int.TryParse(txtNumeroParciales.Text, out int numeroParciales))
            {
                // Crear una instancia de la clase Calificaciones con el número de alumnos y parciales
                 calificaciones = new Calificaciones(numeroAlumnos, numeroParciales);

                // Generar calificaciones aleatorias
                calificaciones.GenerarCalificacionesAleatorias();

                // Calcular la información requerida
                double[] promediosPorAlumno = new double[numeroAlumnos];
                for(int alumno = 0; alumno < numeroAlumnos;alumno ++)
                {
                    promediosPorAlumno[alumno]= calificaciones.CalcularPromedioAlumno(alumno);

                }
                double promedioMaximo = calificaciones.CalcularPromedioMaximo();
                double promedioMinimo = calificaciones.CalcularPromedioMinimo();
                int cantidadReprobados = calificaciones.ContarReprobados(7.0);
                int[] distribucionCalificaciones = calificaciones.CalcularDistribucionCalificaciones();

                // Mostrar los resultados en el Label
                lblResultados.Text = "a) Promedio de cada alumno:\n";
                for (int i = 0; i < promediosPorAlumno.Length; i++)
                {
                    lblResultados.Text += $"Alumno {i + 1}: {promediosPorAlumno[i]:F2}\n";
                }

                lblResultados.Text += $"\nb) Promedio más alto: {promedioMaximo:F2}\n";
                lblResultados.Text += $"c) Promedio más bajo: {promedioMinimo:F2}\n";
                lblResultados.Text += $"d) Cuantos parciales fueron reprobados (menores a 7.0): {cantidadReprobados}\n";
                lblResultados.Text += "e) Distribución de calificaciones finales:\n";
                for (int i = 0; i < distribucionCalificaciones.Length; i++)
                {
                    lblResultados.Text += $"{i * 10} - {i * 10 + 9}: {distribucionCalificaciones[i]} Alumnos\n";
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos para el número de alumnos y parciales.");
            }
        }

    }

    public class Calificaciones
    {
        private double[,] matrizCalificaciones;
        private Random random = new Random();
        private HashSet<double> calificacionesGeneradas = new HashSet<double>();

        public Calificaciones(int numeroAlumnos, int numeroParciales)
        {
            matrizCalificaciones = new double[numeroAlumnos, numeroParciales];
        }

        public void GenerarCalificacionesAleatorias()
        {
            int numeroAlumnos = matrizCalificaciones.GetLength(0);
            int numeroParciales = matrizCalificaciones.GetLength(1);

            for (int alumno = 0; alumno < numeroAlumnos; alumno++)
            {
                for (int parcial = 0; parcial < numeroParciales; parcial++)
                {
                    double calificacionAleatoria;
                    do
                    {
                        calificacionAleatoria = Math.Round(random.NextDouble() * 5 + 5, 1); // Genera calificaciones entre 0 y 10 con un decimal
                    } while (!calificacionesGeneradas.Add(calificacionAleatoria)); // Asegura que las calificaciones no se repitan

                    matrizCalificaciones[alumno, parcial] = calificacionAleatoria;
                }
            }
        }
        public double CalcularPromedioAlumno(int alumno)
        {
            int numeroParciales = matrizCalificaciones.GetLength(1);
            double suma = 0;

            for (int parcial = 0; parcial < numeroParciales; parcial++)
            {
                suma += matrizCalificaciones[alumno, parcial];
            }

            return suma / numeroParciales; // Dividir por el número de parciales, no por 10
        }


        public double CalcularPromedioMaximo()
        {
            int numeroAlumnos = matrizCalificaciones.GetLength(0);
            double maximo = double.MinValue;

            for (int alumno = 0; alumno < numeroAlumnos; alumno++)
            {
                double promedioAlumno = CalcularPromedioAlumno(alumno);
                if (promedioAlumno > maximo)
                {
                    maximo = promedioAlumno;
                }
            }

            return maximo;
        }
        public double CalcularPromedioMinimo()
        {
            int numeroAlumnos = matrizCalificaciones.GetLength(0);
            double minimo = double.MaxValue;

            for (int alumno = 0; alumno < numeroAlumnos; alumno++)
            {
                double promedioAlumno = CalcularPromedioAlumno(alumno);
                if (promedioAlumno < minimo)
                {
                    minimo = promedioAlumno;
                }
            }

            return minimo;
        }
        public int ContarReprobados(double notaMinima = 7.0)
        {
            int numeroAlumnos = matrizCalificaciones.GetLength(0);
            int numeroParciales = matrizCalificaciones.GetLength(1);
            int contadorReprobados = 0;

            for (int alumno = 0; alumno < numeroAlumnos; alumno++)
            {
                for (int parcial = 0; parcial < numeroParciales; parcial++)
                {
                    if (matrizCalificaciones[alumno, parcial] < notaMinima)
                    {
                        contadorReprobados++;
                        break;
                    }
                }
            }

            return contadorReprobados;
        }
        public int[] CalcularDistribucionCalificaciones()
        {
            int[] distribucion = new int[11];

            int numeroAlumnos = matrizCalificaciones.GetLength(0);
            int numeroParciales = matrizCalificaciones.GetLength(1);

            for (int alumno = 0; alumno < numeroAlumnos; alumno++)
            {
                double promedioAlumno = CalcularPromedioAlumno(alumno);
                int indice = (int)Math.Floor(promedioAlumno);
                distribucion[indice]++;
            }

            return distribucion;
        }
        public double CalcularPromedioTotal()
        {
            int numeroAlumnos = matrizCalificaciones.GetLength(0);
            int numeroParciales = matrizCalificaciones.GetLength(1);
            double sumaTotal = 0;

            for (int alumno = 0; alumno < numeroAlumnos; alumno++)
            {
                for (int parcial = 0; parcial < numeroParciales; parcial++)
                {
                    sumaTotal += matrizCalificaciones[alumno, parcial];
                }
            }

            // Calcular el promedio total dividiendo la suma total entre el número total de calificaciones
            return sumaTotal / (numeroAlumnos * numeroParciales);
        }

    }

}

