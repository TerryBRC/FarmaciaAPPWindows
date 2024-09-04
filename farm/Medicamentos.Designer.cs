namespace farm
{
    partial class Medicamentos
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpMedicamentos = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompoundKey1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura_id_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xplaboratorios = new DevExpress.Xpo.XPCollection(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.searchLookUpEditLab = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId_laboratorios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xplaboratorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditLab.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpMedicamentos;
            this.gridControl1.Location = new System.Drawing.Point(149, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(694, 358);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpMedicamentos
            // 
            this.xpMedicamentos.ObjectType = typeof(farm.el_porvenir.Medicamento);
            this.xpMedicamentos.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompoundKey1,
            this.gridColumn1,
            this.gridColumn2,
            this.colNombre,
            this.colCategoria,
            this.colPrecio,
            this.colStock,
            this.colFactura_id_factura,
            this.colFecha_vencimiento});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colCompoundKey1
            // 
            this.colCompoundKey1.FieldName = "CompoundKey1";
            this.colCompoundKey1.Name = "colCompoundKey1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "CompoundKey1.Id_med";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "CompoundKey1.Laboratorios_id_laboratorios";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            // 
            // colCategoria
            // 
            this.colCategoria.FieldName = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Visible = true;
            this.colCategoria.VisibleIndex = 1;
            // 
            // colPrecio
            // 
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 2;
            // 
            // colStock
            // 
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 3;
            // 
            // colFactura_id_factura
            // 
            this.colFactura_id_factura.FieldName = "Factura_id_factura";
            this.colFactura_id_factura.Name = "colFactura_id_factura";
            // 
            // colFecha_vencimiento
            // 
            this.colFecha_vencimiento.FieldName = "Fecha_vencimiento";
            this.colFecha_vencimiento.Name = "colFecha_vencimiento";
            this.colFecha_vencimiento.Visible = true;
            this.colFecha_vencimiento.VisibleIndex = 4;
            // 
            // xplaboratorios
            // 
            this.xplaboratorios.ObjectType = typeof(farm.el_porvenir.Laboratorios);
            this.xplaboratorios.Session = this.unitOfWork1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(13, 40);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(13, 69);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(13, 99);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // searchLookUpEditLab
            // 
            this.searchLookUpEditLab.Location = new System.Drawing.Point(13, 13);
            this.searchLookUpEditLab.Name = "searchLookUpEditLab";
            this.searchLookUpEditLab.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEditLab.Properties.DataSource = this.xplaboratorios;
            this.searchLookUpEditLab.Properties.DisplayMember = "Nombre";
            this.searchLookUpEditLab.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEditLab.Properties.ValueMember = "Id_laboratorios";
            this.searchLookUpEditLab.Size = new System.Drawing.Size(100, 20);
            this.searchLookUpEditLab.TabIndex = 5;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_laboratorios,
            this.colNombre1,
            this.colDireccion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colId_laboratorios
            // 
            this.colId_laboratorios.FieldName = "Id_laboratorios";
            this.colId_laboratorios.Name = "colId_laboratorios";
            // 
            // colNombre1
            // 
            this.colNombre1.FieldName = "Nombre";
            this.colNombre1.Name = "colNombre1";
            this.colNombre1.Visible = true;
            this.colNombre1.VisibleIndex = 0;
            // 
            // colDireccion
            // 
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 1;
            // 
            // Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 561);
            this.Controls.Add(this.searchLookUpEditLab);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gridControl1);
            this.Name = "Medicamentos";
            this.Text = "FormMedicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xplaboratorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditLab.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.Xpo.XPCollection xpMedicamentos;
        private DevExpress.XtraGrid.Columns.GridColumn colCompoundKey1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura_id_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_vencimiento;
        private DevExpress.Xpo.XPCollection xplaboratorios;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditLab;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colId_laboratorios;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre1;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
    }
}

