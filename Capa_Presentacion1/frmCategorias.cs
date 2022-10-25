using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
namespace Capa_Presentacion1
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void ListarCategorias() // Cargamos la tabla Categorias de la BD de sql 
        {
            try
            {
                DgvListadCategorias.DataSource = NCategoria.Listar();
                this.FormatoDgvCategoria();
                lblTotalCategorias.Text = "Total registros: " + Convert.ToString(DgvListadCategorias.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void BuscarCategorias()
        {
            try
            {
                DgvListadCategorias.DataSource = NCategoria.Buscar(txtBuscarCategorias.Text);
                this.FormatoDgvCategoria();
                lblTotalCategorias.Text = "Total registros: " + Convert.ToString(DgvListadCategorias.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void FormatoDgvCategoria()
        {
            DgvListadCategorias.Columns[0].Visible = false;
            DgvListadCategorias.Columns[1].Visible = false;
            DgvListadCategorias.Columns[2].Width = 150;
            DgvListadCategorias.Columns[3].Width = 300;
            DgvListadCategorias.Columns[3].HeaderText = "Descripción";
            DgvListadCategorias.Columns[4].Width = 250;
        }
        private void Limpir()
        {
            txtBuscarCategorias.Clear();
            txtNombre.Clear();
            txtId.Clear();
            txtDescripcion.Clear();
            btnInsertar.Visible = true;
            erroricono.Clear();
        }

        private void MensajeError(string mensaje) // funcion para cargar los error de las validaciones en el sistema
        {
            MessageBox.Show(mensaje, "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje) // funcion para mandar mensaje si no ocurrio problema en la carga de datos
        {
            MessageBox.Show(mensaje, "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            this.ListarCategorias();
        }
        private void btnInsertar_Click(object sender, EventArgs e)
            {
                try
                {
                    string Rpta = "";
                    if (txtNombre.Text == string.Empty)
                    {
                        this.MensajeError("Falta ingresar ingresar algunos datos,  seran remarcados");
                        erroricono.SetError(txtNombre, "Ingrese un nombre");// erroricono es nuestro Errorprovider(Interfaz en el formulario) indicando el lugar del error

                    }
                     else
                     {
                          Rpta = NCategoria.Insertar(txtNombre.Text.Trim(), txtDescripcion.Text.Trim());// llamamos ala funcion Insertar de la clase NCategoria
                         if (Rpta.Equals("OK"))
                         {
                           this.MensajeOk("Datos Guardados Correctamente");
                           this.Limpir();//Limpiamos las casillas
                           this.ListarCategorias();// cargamos el data
                         }
                         else
                          {
                                 this.MensajeError(Rpta);
                          }
                     }                                                                                 

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + ex.StackTrace);

                }
            }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpir();
            tabGeneral.SelectedIndex = 0;

        }
        private void btnBuscarCategorias_Click(object sender, EventArgs e)
        {
            this.BuscarCategorias();
        }
    }
}

