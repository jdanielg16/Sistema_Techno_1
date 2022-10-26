
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTotalCategorias = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Label();
            this.DgvListadCategorias = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBuscarCategorias = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscarCategorias = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadCategorias)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabPage1);
            this.tabGeneral.Controls.Add(this.tabPage2);
            this.tabGeneral.Location = new System.Drawing.Point(0, -1);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(1383, 771);
            this.tabGeneral.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuscarCategorias);
            this.tabPage1.Controls.Add(this.lblTotalCategorias);
            this.tabPage1.Controls.Add(this.Buscar);
            this.tabPage1.Controls.Add(this.DgvListadCategorias);
            this.tabPage1.Controls.Add(this.txtBuscarCategorias);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1375, 738);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista Categorias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTotalCategorias
            // 
            this.lblTotalCategorias.AutoSize = true;
            this.lblTotalCategorias.Location = new System.Drawing.Point(1009, 539);
            this.lblTotalCategorias.Name = "lblTotalCategorias";
            this.lblTotalCategorias.Size = new System.Drawing.Size(57, 20);
            this.lblTotalCategorias.TabIndex = 3;
            this.lblTotalCategorias.Text = "label2";
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = true;
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(42, 88);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(93, 29);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar";
            // 
            // DgvListadCategorias
            // 
            this.DgvListadCategorias.AllowUserToAddRows = false;
            this.DgvListadCategorias.AllowUserToDeleteRows = false;
            this.DgvListadCategorias.AllowUserToOrderColumns = true;
            this.DgvListadCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListadCategorias.Location = new System.Drawing.Point(30, 162);
            this.DgvListadCategorias.Name = "DgvListadCategorias";
            this.DgvListadCategorias.ReadOnly = true;
            this.DgvListadCategorias.RowHeadersWidth = 62;
            this.DgvListadCategorias.RowTemplate.Height = 28;
            this.DgvListadCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadCategorias.Size = new System.Drawing.Size(1109, 351);
            this.DgvListadCategorias.TabIndex = 1;
            this.DgvListadCategorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadCategorias_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 8;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 150;
            // 
            // txtBuscarCategorias
            // 
            this.txtBuscarCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCategorias.Location = new System.Drawing.Point(174, 88);
            this.txtBuscarCategorias.Name = "txtBuscarCategorias";
            this.txtBuscarCategorias.Size = new System.Drawing.Size(623, 26);
            this.txtBuscarCategorias.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnActualizar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnInsertar);
            this.tabPage2.Controls.Add(this.txtDescripcion);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1375, 738);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Guardar Categorias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(126)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.ImageKey = "Cancelar.png";
            this.btnCancelar.ImageList = this.imageList1;
            this.btnCancelar.Location = new System.Drawing.Point(593, 489);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(215, 62);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "(*) Indica que el dato es obligatorio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre (*)";
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.LightBlue;
            this.btnInsertar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.ImageKey = "Guardado1.png";
            this.btnInsertar.ImageList = this.imageList1;
            this.btnInsertar.Location = new System.Drawing.Point(256, 489);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(215, 62);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(256, 221);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(552, 116);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(256, 120);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(552, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(649, 56);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(159, 26);
            this.txtId.TabIndex = 0;
            this.txtId.Visible = false;
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // btnBuscarCategorias
            // 
            this.btnBuscarCategorias.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscarCategorias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscarCategorias.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCategorias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCategorias.ImageKey = "Buscar.png";
            this.btnBuscarCategorias.ImageList = this.imageList1;
            this.btnBuscarCategorias.Location = new System.Drawing.Point(839, 68);
            this.btnBuscarCategorias.Name = "btnBuscarCategorias";
            this.btnBuscarCategorias.Size = new System.Drawing.Size(227, 67);
            this.btnBuscarCategorias.TabIndex = 4;
            this.btnBuscarCategorias.Text = "Buscar";
            this.btnBuscarCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarCategorias.UseVisualStyleBackColor = false;
            this.btnBuscarCategorias.Click += new System.EventHandler(this.btnBuscarCategorias_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Buscar.png");
            this.imageList1.Images.SetKeyName(1, "Guardado.png");
            this.imageList1.Images.SetKeyName(2, "Guardado1.png");
            this.imageList1.Images.SetKeyName(3, "Cancelar.png");
            this.imageList1.Images.SetKeyName(4, "Actualizar.png");
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.LightBlue;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.ImageKey = "Actualizar.png";
            this.btnActualizar.ImageList = this.imageList1;
            this.btnActualizar.Location = new System.Drawing.Point(256, 490);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(215, 62);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 776);
            this.Controls.Add(this.tabGeneral);
            this.Name = "frmCategorias";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            this.tabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadCategorias)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DgvListadCategorias;
        private System.Windows.Forms.TextBox txtBuscarCategorias;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTotalCategorias;
        private System.Windows.Forms.Label Buscar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider erroricono;
        private System.Windows.Forms.Button btnBuscarCategorias;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnActualizar;
    }
}

