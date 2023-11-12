namespace P.I.A
{
    partial class Wesclava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wesclava));
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label dirLabel;
            System.Windows.Forms.Label cod_TipoLabel;
            System.Windows.Forms.Label estadoLabel;
            this.dB_Biblioteca2023DataSet = new P.I.A.DB_Biblioteca2023DataSet();
            this.tblusuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblusuarioTableAdapter = new P.I.A.DB_Biblioteca2023DataSetTableAdapters.tblusuarioTableAdapter();
            this.tableAdapterManager = new P.I.A.DB_Biblioteca2023DataSetTableAdapters.TableAdapterManager();
            this.tblusuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.dirTextBox = new System.Windows.Forms.TextBox();
            this.cod_TipoTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.tblReservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblReservaTableAdapter = new P.I.A.DB_Biblioteca2023DataSetTableAdapters.tblReservaTableAdapter();
            this.tblReservaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            cedulaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            dirLabel = new System.Windows.Forms.Label();
            cod_TipoLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Biblioteca2023DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusuarioBindingNavigator)).BeginInit();
            this.tblusuarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblReservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReservaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
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
            this.tableAdapterManager.tblReservaTableAdapter = this.tblReservaTableAdapter;
            this.tableAdapterManager.tblTipo_MaterialTableAdapter = null;
            this.tableAdapterManager.tblTipo_UsuarioTableAdapter = null;
            this.tableAdapterManager.tblusuarioTableAdapter = this.tblusuarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = P.I.A.DB_Biblioteca2023DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.tblusuarioBindingNavigator.Size = new System.Drawing.Size(989, 31);
            this.tblusuarioBindingNavigator.TabIndex = 0;
            this.tblusuarioBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
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
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cedulaLabel.Location = new System.Drawing.Point(3, 81);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(58, 18);
            cedulaLabel.TabIndex = 1;
            cedulaLabel.Text = "Cedula:";
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblusuarioBindingSource, "Cedula", true));
            this.cedulaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaTextBox.Location = new System.Drawing.Point(67, 73);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(100, 24);
            this.cedulaTextBox.TabIndex = 2;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(173, 79);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(66, 18);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblusuarioBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(244, 76);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 24);
            this.nombreTextBox.TabIndex = 4;
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telLabel.Location = new System.Drawing.Point(350, 79);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(27, 18);
            telLabel.TabIndex = 5;
            telLabel.Text = "tel:";
            // 
            // telTextBox
            // 
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblusuarioBindingSource, "tel", true));
            this.telTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telTextBox.Location = new System.Drawing.Point(383, 76);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(100, 24);
            this.telTextBox.TabIndex = 6;
            // 
            // dirLabel
            // 
            dirLabel.AutoSize = true;
            dirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dirLabel.Location = new System.Drawing.Point(489, 81);
            dirLabel.Name = "dirLabel";
            dirLabel.Size = new System.Drawing.Size(31, 18);
            dirLabel.TabIndex = 7;
            dirLabel.Text = "Dir:";
            // 
            // dirTextBox
            // 
            this.dirTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblusuarioBindingSource, "Dir", true));
            this.dirTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirTextBox.Location = new System.Drawing.Point(526, 78);
            this.dirTextBox.Name = "dirTextBox";
            this.dirTextBox.Size = new System.Drawing.Size(100, 24);
            this.dirTextBox.TabIndex = 8;
            // 
            // cod_TipoLabel
            // 
            cod_TipoLabel.AutoSize = true;
            cod_TipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_TipoLabel.Location = new System.Drawing.Point(632, 83);
            cod_TipoLabel.Name = "cod_TipoLabel";
            cod_TipoLabel.Size = new System.Drawing.Size(73, 18);
            cod_TipoLabel.TabIndex = 9;
            cod_TipoLabel.Text = "Cod Tipo:";
            // 
            // cod_TipoTextBox
            // 
            this.cod_TipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblusuarioBindingSource, "Cod_Tipo", true));
            this.cod_TipoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_TipoTextBox.Location = new System.Drawing.Point(711, 78);
            this.cod_TipoTextBox.Name = "cod_TipoTextBox";
            this.cod_TipoTextBox.Size = new System.Drawing.Size(100, 24);
            this.cod_TipoTextBox.TabIndex = 10;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.Location = new System.Drawing.Point(817, 81);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(59, 18);
            estadoLabel.TabIndex = 11;
            estadoLabel.Text = "Estado:";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblusuarioBindingSource, "Estado", true));
            this.estadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoTextBox.Location = new System.Drawing.Point(889, 78);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 24);
            this.estadoTextBox.TabIndex = 12;
            // 
            // tblReservaBindingSource
            // 
            this.tblReservaBindingSource.DataMember = "FK__tblReserv__Cedul__534D60F1";
            this.tblReservaBindingSource.DataSource = this.tblusuarioBindingSource;
            // 
            // tblReservaTableAdapter
            // 
            this.tblReservaTableAdapter.ClearBeforeFill = true;
            // 
            // tblReservaDataGridView
            // 
            this.tblReservaDataGridView.AutoGenerateColumns = false;
            this.tblReservaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblReservaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tblReservaDataGridView.DataSource = this.tblReservaBindingSource;
            this.tblReservaDataGridView.Location = new System.Drawing.Point(176, 174);
            this.tblReservaDataGridView.Name = "tblReservaDataGridView";
            this.tblReservaDataGridView.RowHeadersWidth = 51;
            this.tblReservaDataGridView.RowTemplate.Height = 24;
            this.tblReservaDataGridView.Size = new System.Drawing.Size(555, 272);
            this.tblReservaDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_reserva";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cod_reserva";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cedula";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cedula";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cod_Material";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cod_Material";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.tblReservaBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator1.Location = new System.Drawing.Point(333, 144);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(344, 31);
            this.bindingNavigator1.TabIndex = 14;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem1.Text = "de {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Mover último";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem1.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem1.Text = "Eliminar";
            // 
            // Wesclava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 512);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tblReservaDataGridView);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(this.cedulaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(telLabel);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(dirLabel);
            this.Controls.Add(this.dirTextBox);
            this.Controls.Add(cod_TipoLabel);
            this.Controls.Add(this.cod_TipoTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.tblusuarioBindingNavigator);
            this.Name = "Wesclava";
            this.Text = "Wesclava";
            this.Load += new System.EventHandler(this.Wesclava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_Biblioteca2023DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusuarioBindingNavigator)).EndInit();
            this.tblusuarioBindingNavigator.ResumeLayout(false);
            this.tblusuarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblReservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReservaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_Biblioteca2023DataSet dB_Biblioteca2023DataSet;
        private System.Windows.Forms.BindingSource tblusuarioBindingSource;
        private DB_Biblioteca2023DataSetTableAdapters.tblusuarioTableAdapter tblusuarioTableAdapter;
        private DB_Biblioteca2023DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblusuarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblusuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.TextBox dirTextBox;
        private System.Windows.Forms.TextBox cod_TipoTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private DB_Biblioteca2023DataSetTableAdapters.tblReservaTableAdapter tblReservaTableAdapter;
        private System.Windows.Forms.BindingSource tblReservaBindingSource;
        private System.Windows.Forms.DataGridView tblReservaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
    }
}