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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void frmCategorias_Load(object sender, EventArgs e)
        {
            this.ListarCategorias();
        }
    }
}
