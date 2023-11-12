namespace P.I.A
{
    partial class WtblEjemplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WtblEjemplar));
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tblusuarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblusuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tblEjemplarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEjemplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Biblioteca2023DataSet = new P.I.A.DB_Biblioteca2023DataSet();
            this.tblusuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblusuarioTableAdapter = new P.I.A.DB_Biblioteca2023DataSetTableAdapters.tblusuarioTableAdapter();
            this.tableAdapterManager = new P.I.A.DB_Biblioteca2023DataSetTableAdapters.TableAdapterManager();
            this.tblEjemplarTableAdapter = new P.I.A.DB_Biblioteca2023DataSetTableAdapters.tblEjemplarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblusuarioBindingNavigator)).BeginInit();
            this.tblusuarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEjemplarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEjemplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Biblioteca2023DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(653, 405);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(104, 33);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // tblusuarioBindingNavigatorSaveItem
            // 
            this.tblusuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblusuarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblusuarioBindingNavigatorSaveItem.Image")));
            this.tblusuarioBindingNavigatorSaveItem.Name = "tblusuarioBindingNavigatorSaveItem";
            this.tblusuarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tblusuarioBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tblusuarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblusuarioBindingNavigatorSaveItem_Click);
            // 
            // tblusuarioBindingNavigator
            // 
            this.tblusuarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblusuarioBindingNavigator.BindingSource = this.tblusuarioBindingSource;
            this.tblusuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblusuarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblusuarioBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblusuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblusuarioBindingNavigatorSaveItem});
            this.tblusuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblusuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblusuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblusuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblusuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblusuarioBindingNavigator.Name = "tblusuarioBindingNavigator";
            this.tblusuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblusuarioBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.tblusuarioBindingNavigator.TabIndex = 0;
            this.tblusuarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // tblEjemplarDataGridView
            // 
            this.tblEjemplarDataGridView.AutoGenerateColumns = false;
            this.tblEjemplarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEjemplarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tblEjemplarDataGridView.DataSource = this.tblEjemplarBindingSource;
            this.tblEjemplarDataGridView.Location = new System.Drawing.Point(154, 86);
            this.tblEjemplarDataGridView.Name = "tblEjemplarDataGridView";
            this.tblEjemplarDataGridView.RowHeadersWidth = 51;
            this.tblEjemplarDataGridView.RowTemplate.Height = 24;
            this.tblEjemplarDataGridView.Size = new System.Drawing.Size(425, 277);
            this.tblEjemplarDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Num_Ejemplar";
            this.dataGridViewTextBoxColumn1.HeaderText = "Num_Ejemplar";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cod_Material";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cod_Material";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn3.HeaderText = "estado";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // tblEjemplarBindingSource
            // 
            this.tblEjemplarBindingSource.DataMember = "tblEjemplar";
            this.tblEjemplarBindingSource.DataSource = this.dB_Biblioteca2023DataSet;
            // 
            // dB_Biblioteca2023DataSet
            // 
            this.dB_Biblioteca2023DataSet.DataSetName = "DB_Biblioteca2023DataSet";
            this.dB_Biblioteca2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblusuarioBindingSource
            // 
            this.tblusuarioBindingSource.DataMember = "tblusuario";
            this.tblusuarioBindingSource.DataSource = this.dB_Biblioteca2023DataSet;
            // 
            // tblusuarioTableAdapter
            // 
            this.tblusuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbldependenciaTableAdapter = null;
            this.tableAdapterManager.tblDevolucionTableAdapter = null;
            this.tableAdapterManager.tblEjemplarTableAdapter = null;
            this.tableAdapterManager.tblMaterialTableAdapter = null;
            this.tableAdapterManager.tblPerteneceTableAdapter = null;
            this.tableAdapterManager.tblPrestamoTableAdapter = null;
            this.tableAdapterManager.tblReservaTableAdapter = null;
            this.tableAdapterManager.tblTipo_MaterialTableAdapter = null;
            this.tableAdapterManager.tblTipo_UsuarioTableAdapter = null;
            this.tableAdapterManager.tblusuarioTableAdapter = this.tblusuarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = P.I.A.DB_Biblioteca2023DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblEjemplarTableAdapter
            // 
            this.tblEjemplarTableAdapter.ClearBeforeFill = true;
            // 
            // WtblUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.tblEjemplarDataGridView);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.tblusuarioBindingNavigator);
            this.Name = "WtblUsuario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblusuarioBindingNavigator)).EndInit();
            this.tblusuarioBindingNavigator.ResumeLayout(false);
            this.tblusuarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEjemplarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEjemplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Biblioteca2023DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_Biblioteca2023DataSet dB_Biblioteca2023DataSet;
        private System.Windows.Forms.BindingSource tblusuarioBindingSource;
        private DB_Biblioteca2023DataSetTableAdapters.tblusuarioTableAdapter tblusuarioTableAdapter;
        private DB_Biblioteca2023DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton tblusuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator tblusuarioBindingNavigator;
        private System.Windows.Forms.BindingSource tblEjemplarBindingSource;
        private DB_Biblioteca2023DataSetTableAdapters.tblEjemplarTableAdapter tblEjemplarTableAdapter;
        private System.Windows.Forms.DataGridView tblEjemplarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}