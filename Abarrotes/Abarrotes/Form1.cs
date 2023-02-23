using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abarrotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDato.Columns.Add("producto", "Producto");
            dgvDato.Columns.Add("precio", "Precio");
            dgvDato.Columns.Add("cantidad", "Cantidad de Compra");
            dgvDato.Columns.Add("total", "Total");

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvDato.Rows.Add(cmbProducto.Text, txtPrecio.Text, txtCantidad.Text, txtTotal.Text);
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (cmbProducto.Text == "Café")
            {
                txtPrecio.Text = "100";
            }
            else if (cmbProducto.Text == "Azúcar")
            {
                txtPrecio.Text = "28";
            }
            else if (cmbProducto.Text == "Jabón")
            {
                txtPrecio.Text = "38";
            }
            else if (cmbProducto.Text == "Arroz")
            {
                txtPrecio.Text = "30";
            }
            else if (cmbProducto.Text == "Cereal")
            {
                txtPrecio.Text = "46";
            }
            else if (cmbProducto.Text == "Avena")
            {
                txtPrecio.Text = "25";
            }
            else if (cmbProducto.Text == null)
            {
                txtPrecio.Text = "";
            }

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(txtCantidad.Text);
            n2 = Convert.ToInt32(txtPrecio.Text);
            r = n1 * n2;
            txtTotal.Text = Convert.ToString(r);
            //txtTotal.Text = r;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtPrecio.Text = "";
            txtTotal.Text = "";
            cmbProducto.Text = "";
        }

        private void dgvDato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDato.Rows.Remove(dgvDato.CurrentRow);
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try {
                dgvDato.Rows.Remove(dgvDato.CurrentRow);
            }
            catch
            {
                MessageBox.Show("Error en la ejecución de su solicitud ");
            }
        }
    

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                    Application.Exit();
                }
                else
                {
                    this.cmbProducto.Focus();
                }
            }
        
    }
    }
