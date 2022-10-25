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

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            this.ListarCategorias();
        }

        private void btnBuscarCategorias_Click(object sender, EventArgs e)
        {
            this.BuscarCategorias();

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }
    }
}
