namespace P.I.A
{
    partial class WtblDevolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WtblDevolucion));
            this.dB_Biblioteca2023DataSet = new P.I.A.DB_Biblioteca2023DataSet();
            this.tblDevolucionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDevolucionTableAdapter = new P.I.A.DB_Biblioteca2023DataSetTableAdapters.tblDevolucionTableAdapter();
            this.tableAdapterManager = new P.I.A.DB_Biblioteca2023DataSetTableAdapters.TableAdapterManager();
            this.tblDevolucionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblDevolucionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblDevolucionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Biblioteca2023DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevolucionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevolucionBindingNavigator)).BeginInit();
            this.tblDevolucionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevolucionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_Biblioteca2023DataSet
            // 
            this.dB_Biblioteca2023DataSet.DataSetName = "DB_Biblioteca2023DataSet";
            this.dB_Biblioteca2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDevolucionBindingSource
            // 
            this.tblDevolucionBindingSource.DataMember = "tblDevolucion";
            this.tblDevolucionBindingSource.DataSource = this.dB_Biblioteca2023DataSet;
            // 
            // tblDevolucionTableAdapter
            // 
            this.tblDevolucionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbldependenciaTableAdapter = null;
            this.tableAdapterManager.tblDevolucionTableAdapter = this.tblDevolucionTableAdapter;
            this.tableAdapterManager.tblEjemplarTableAdapter = null;
            this.tableAdapterManager.tblMaterialTableAdapter = null;
            this.tableAdapterManager.tblPerteneceTableAdapter = null;
            this.tableAdapterManager.tblPrestamoTableAdapter = null;
            this.tableAdapterManager.tblReservaTableAdapter = null;
            this.tableAdapterManager.tblTipo_MaterialTableAdapter = null;
            this.tableAdapterManager.tblTipo_UsuarioTableAdapter = null;
            this.tableAdapterManager.tblusuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = P.I.A.DB_Biblioteca2023DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblDevolucionBindingNavigator
            // 
            this.tblDevolucionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblDevolucionBindingNavigator.BindingSource = this.tblDevolucionBindingSource;
            this.tblDevolucionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblDevolucionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblDevolucionBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblDevolucionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblDevolucionBindingNavigatorSaveItem});
            this.tblDevolucionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblDevolucionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblDevolucionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblDevolucionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblDevolucionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblDevolucionBindingNavigator.Name = "tblDevolucionBindingNavigator";
            this.tblDevolucionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblDevolucionBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.tblDevolucionBindingNavigator.TabIndex = 0;
            this.tblDevolucionBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
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
            // tblDevolucionBindingNavigatorSaveItem
            // 
            this.tblDevolucionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblDevolucionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblDevolucionBindingNavigatorSaveItem.Image")));
            this.tblDevolucionBindingNavigatorSaveItem.Name = "tblDevolucionBindingNavigatorSaveItem";
            this.tblDevolucionBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tblDevolucionBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tblDevolucionBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblDevolucionBindingNavigatorSaveItem_Click);
            // 
            // tblDevolucionDataGridView
            // 
            this.tblDevolucionDataGridView.AutoGenerateColumns = false;
            this.tblDevolucionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDevolucionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tblDevolucionDataGridView.DataSource = this.tblDevolucionBindingSource;
            this.tblDevolucionDataGridView.Location = new System.Drawing.Point(149, 117);
            this.tblDevolucionDataGridView.Name = "tblDevolucionDataGridView";
            this.tblDevolucionDataGridView.RowHeadersWidth = 51;
            this.tblDevolucionDataGridView.RowTemplate.Height = 24;
            this.tblDevolucionDataGridView.Size = new System.Drawing.Size(426, 214);
            this.tblDevolucionDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Devolucion";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cod_Devolucion";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha_Devolucion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha_Devolucion";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Num_Prestamo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Num_Prestamo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(652, 363);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(111, 33);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(546, 363);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(89, 33);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // WtblDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.tblDevolucionDataGridView);
            this.Controls.Add(this.tblDevolucionBindingNavigator);
            this.Name = "WtblDevolucion";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_Biblioteca2023DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevolucionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevolucionBindingNavigator)).EndInit();
            this.tblDevolucionBindingNavigator.ResumeLayout(false);
            this.tblDevolucionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevolucionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_Biblioteca2023DataSet dB_Biblioteca2023DataSet;
        private System.Windows.Forms.BindingSource tblDevolucionBindingSource;
        private DB_Biblioteca2023DataSetTableAdapters.tblDevolucionTableAdapter tblDevolucionTableAdapter;
        private DB_Biblioteca2023DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblDevolucionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblDevolucionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblDevolucionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
    }
}