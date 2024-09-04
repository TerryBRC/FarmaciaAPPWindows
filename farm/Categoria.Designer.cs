namespace farm
{
    partial class Categoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridViewCategoria = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.unitOfWorkCategoria = new DevExpress.Xpo.UnitOfWork(this.components);
            this.xpCollectionCategoria = new DevExpress.Xpo.XPCollection(this.components);
            this.colId_categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpCollectionCategoria;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridViewCategoria;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(646, 394);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCategoria});
            // 
            // gridViewCategoria
            // 
            this.gridViewCategoria.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_categoria,
            this.colNombre,
            this.colDescripcion});
            this.gridViewCategoria.GridControl = this.gridControl1;
            this.gridViewCategoria.Name = "gridViewCategoria";
            // 
            // xpCollectionCategoria
            // 
            this.xpCollectionCategoria.ObjectType = typeof(farm.el_porvenir.Categoria);
            this.xpCollectionCategoria.Session = this.unitOfWorkCategoria;
            // 
            // colId_categoria
            // 
            this.colId_categoria.FieldName = "Id_categoria";
            this.colId_categoria.Name = "colId_categoria";
            this.colId_categoria.Visible = true;
            this.colId_categoria.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 417);
            this.Controls.Add(this.gridControl1);
            this.Name = "Categoria";
            this.Text = "Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCategoria;
        private DevExpress.Xpo.UnitOfWork unitOfWorkCategoria;
        private DevExpress.Xpo.XPCollection xpCollectionCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colId_categoria;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
    }
}