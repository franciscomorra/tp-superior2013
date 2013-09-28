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
        public Form2(DataTable tabla)
        {
            InitializeComponent();
            //Sacar los datos del dataset
            int cantidadFilas = tabla.Rows.Count;
            DataRowCollection filas = tabla.Rows;
            
            foreach(DataRow fila in filas){
                //Generar los polinomios
                int valorX = fila.Field<int>(0);
                int valorY = fila.Field<int>(1);
                

                //MessageBox.Show("X: " + fila.Field<int>(0).ToString() + "      Y: " + fila.Field<int>(1).ToString());    
            
            }


            //Rellenar el texto
            richTextBox1.Text = "asdsad";
           

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
