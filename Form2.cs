using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Xml.Linq;

namespace Practica
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void clearFind()
        {
            txtautor.Text=String.Empty;
            txtisbn.Text=String.Empty;
            txtpag.Text=String.Empty;
            txttitulo.Text=String.Empty;

            txtisbn.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string isbn, autor, titulo;
            string npag;

            isbn = txtisbn.Text;
            autor = txtautor.Text;
            titulo = txttitulo.Text;
            npag = txtpag.Text;

            string[] datos = new string[5];

            datos[0] = isbn;
            datos[1] = autor;
            datos[2] = titulo;
            datos[3] = npag;

            dataGridView1.Rows.Add(datos);
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            clearFind();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            /*foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                String strFila = Row.Index.ToString();
               string valor = Convert.ToString(Row.Cells["ISBN"].Value);

                if (valor == this.txtbuscar.Text)
                {
                    dataGridView1.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.Yellow;
                    
                    
                }
            }
            */
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                String strFila = Row.Index.ToString();
                string valor = Convert.ToString(Row.Cells["ISBN"].Value);

                if (valor == this.txtbuscar.Text)
                {
                    dataGridView1.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.Yellow;


                }
            }
        }
    }
}
