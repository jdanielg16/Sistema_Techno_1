
namespace Capa_Presentacion1
{
    partial class frmCategorias
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvListadCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListadCategorias
            // 
            this.DgvListadCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadCategorias.Location = new System.Drawing.Point(227, 121);
            this.DgvListadCategorias.Name = "DgvListadCategorias";
            this.DgvListadCategorias.RowHeadersWidth = 62;
            this.DgvListadCategorias.RowTemplate.Height = 28;
            this.DgvListadCategorias.Size = new System.Drawing.Size(478, 291);
            this.DgvListadCategorias.TabIndex = 0;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 521);
            this.Controls.Add(this.DgvListadCategorias);
            this.Name = "frmCategorias";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListadCategorias;
    }
}

