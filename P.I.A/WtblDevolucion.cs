using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.I.A
{
    public partial class WtblDevolucion : Form
    {
        public WtblDevolucion()
        {
            InitializeComponent();
        }

        private void tblDevolucionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblDevolucionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_Biblioteca2023DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_Biblioteca2023DataSet.tblDevolucion' Puede moverla o quitarla según sea necesario.
            this.tblDevolucionTableAdapter.Fill(this.dB_Biblioteca2023DataSet.tblDevolucion);

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Wesclava newform = new Wesclava();
            newform.Show();
            this.Hide();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            WtblPrestamo newform = new WtblPrestamo();
            newform.Show();
            this.Hide();
        }
    }
}
