using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public int factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * factorial(i - 1);
        }

        public Form2(DataTable tabla)
        {
            InitializeComponent();
            //Sacar los datos del dataset
            DataRowCollection filas = tabla.Rows;

            //Crear la matriz
            int cantidadFilas = tabla.Rows.Count;
            int cantidadColumnas = cantidadFilas + 1;
            int[,] diferenciasProgresivas = new int[cantidadFilas, cantidadColumnas];

            // Llenar la matriz con ceros
            int a, b;
            for (a = 0; a < cantidadFilas; a++)
            {
                for (b = 0; b < cantidadColumnas; b++)
                {
                    diferenciasProgresivas[a, b] = 0;
                }
            }

            //Copiar la datatable en las dos primeras columnas
            int i = 0;
            foreach (DataRow fila in filas)
            {
                diferenciasProgresivas[i, 0] = fila.Field<int>(0);
                diferenciasProgresivas[i, 1] = fila.Field<int>(1);
                i++;
            }

            //Calcular las diferencias
            int orden, f;
            int filasRestantes = cantidadFilas;

            for (orden = 1; orden < (cantidadColumnas + 1); orden++)
            {
                for (f = 0; f < (filasRestantes - orden); f++)
                {
                    diferenciasProgresivas[f, orden + 1] = diferenciasProgresivas[f + 1, orden] - diferenciasProgresivas[f, orden];
                }
            }

            //Imprimir polinomio progresivo
            richTextBox1.Text = "Prog(x) = " + diferenciasProgresivas[0, 1].ToString() + " + ";
            int e, h, k;
            int g = 0;
            for (e = 2, h = 0; e < cantidadColumnas; e++, h++)
            {
                if (diferenciasProgresivas[0, e] != 0)
                {
                    richTextBox1.AppendText("[ (" + (diferenciasProgresivas[0, e] / (factorial(e - 1) * Math.Pow((diferenciasProgresivas[1 + h, 0] - diferenciasProgresivas[0 + h, 0]), e - 1))).ToString() + ")");
                    g++;
                    for (k = 1; k <= g; k++)
                    {
                        richTextBox1.AppendText(" . (x - " + k.ToString() + ")");
                    }
                    if ((e + 1) != cantidadColumnas)
                    {
                        richTextBox1.AppendText(" ] + ");
                    }
                    else
                    {
                        richTextBox1.AppendText(" ]");
                    }
                }
                else
                {
                    g++;
                }
            }



            //DataTable tabla = datos.Tables["tablaDatos"] as BindingList<Coordenada>; ;

            /*
          //MessageBox.Show(tabla.Rows.ToString());
              foreach (DataRow row 

            MessageBox.Show(tabla.Rows[1].ToString());
 tabla)
              {
                   
                    
                  
                  data.Add(new Client()
                  {
                      Id = int.Parse(row["ID"].ToString()),
                      Name = row["Name"].ToString(),
                      Address = row["Address"].ToString(),
                  });
                   * 
              }
                  
          }
            * */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Agarrar los datos del textbox
            //Agarrar el polinomio
            //reemplazar valor
            MessageBox.Show("Resultado: ");
        }
    }
}
