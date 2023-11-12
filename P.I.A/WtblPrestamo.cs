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
    public partial class WtblPrestamo : Form
    {
        public WtblPrestamo()
        {
            InitializeComponent();
        }

        private void tblPrestamoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblPrestamoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_Biblioteca2023DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_Biblioteca2023DataSet.tblPrestamo' Puede moverla o quitarla según sea necesario.
            this.tblPrestamoTableAdapter.Fill(this.dB_Biblioteca2023DataSet.tblPrestamo);

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            WtblDevolucion newform = new WtblDevolucion();
            newform.Show();
            this.Hide();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            WtblEjemplar newform = new WtblEjemplar();
            newform.Show();
            this.Hide();
        }
    }
}
