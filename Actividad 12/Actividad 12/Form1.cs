using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_12
{
    public partial class forms : Form
    {

        public forms()
        {

            InitializeComponent();

            textBoxMayorVenta.Visible = false;
            textBoxMenorVenta.Visible = false;
            textBoxVentaPorDia.Visible = false;
            textBoxVentaTotal.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int filas = 12;
            int columnas = 7;

            Random random = new Random();
            tablaVentas.Rows.Clear();
            tablaVentas.Columns.Clear();
            tablaVentas.ColumnCount = columnas;

            List<int> numerosUnicos = new List<int>();

            for (int j = 0; j < columnas; j++)
            {
                tablaVentas.Columns.Add("Columna" + j, "Columna" + j);
            }

            for (int i = 0; i < filas; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                tablaVentas.Rows.Add(row);

                for (int j = 0; j < columnas; j++)
                {
                    int numeroAleatorio;
                    do
                    {
                        numeroAleatorio = random.Next(1, 501); // Números aleatorios entre 1 y 100 (puedes ajustar el rango)
                    } while (numerosUnicos.Contains(numeroAleatorio));

                    numerosUnicos.Add(numeroAleatorio);
                    tablaVentas.Rows[i].Cells[j].Value = numeroAleatorio.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            textBoxMayorVenta.Visible = true;
            textBoxMenorVenta.Visible = true;
            textBoxVentaPorDia.Visible = true;
            textBoxVentaTotal.Visible = true;

            venta.CalcularVentas(tablaVentas, textBoxMenorVenta, textBoxMayorVenta, textBoxVentaTotal, textBoxVentaPorDia);


        }
    }
}

public class Venta
{
    public void CalcularVentas(DataGridView tabla, TextBox txtMenorVenta, TextBox txtMayorVenta, TextBox txtVentaTotal, TextBox txtVentaPorDia)
    {
        decimal menorVenta = decimal.MaxValue;
        decimal mayorVenta = decimal.MinValue;
        decimal ventaTotal = 0;

        decimal[] ventaPorDia = new decimal[7];

        foreach (DataGridViewRow row in tabla.Rows)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value != null)
                {
                    decimal venta = Convert.ToDecimal(cell.Value);
                    if (venta < menorVenta)
                    {
                        menorVenta = venta;
                    }

                    if (venta > mayorVenta)
                    {
                        mayorVenta = venta;
                    }

                    ventaTotal += venta;

                    int dia = cell.ColumnIndex;
                    ventaPorDia[dia] += venta;
                }
            }
        }

        // Actualiza los TextBox con los resultados
        txtMenorVenta.Text = $"Menor Venta: {menorVenta:C}";
        txtMayorVenta.Text = $"Mayor Venta: {mayorVenta:C}";
        txtVentaTotal.Text = $"Venta Total: {ventaTotal:C}";

        string ventaPorDiaTexto = "";
        for (int i = 0; i < ventaPorDia.Length; i++)
        {
            string dia = ObtenerNombreDia(i);
            ventaPorDiaTexto += $"{dia}: {ventaPorDia[i]:C}\r\n";
        }
        txtVentaPorDia.Text = ventaPorDiaTexto;
    }

    public static string ObtenerNombreDia(int indiceDia)
    {
        string[] diasSemana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
        return diasSemana[indiceDia];
    }
}