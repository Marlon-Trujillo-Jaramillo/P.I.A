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
    public partial class WtblEjemplar : Form
    {
        public WtblEjemplar()
        {
            InitializeComponent();
        }

        private void tblusuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblusuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_Biblioteca2023DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_Biblioteca2023DataSet.tblEjemplar' Puede moverla o quitarla según sea necesario.
            this.tblEjemplarTableAdapter.Fill(this.dB_Biblioteca2023DataSet.tblEjemplar);
            // TODO: esta línea de código carga datos en la tabla 'dB_Biblioteca2023DataSet.tblEjemplar' Puede moverla o quitarla según sea necesario.
            this.tblEjemplarTableAdapter.Fill(this.dB_Biblioteca2023DataSet.tblEjemplar);
            // TODO: esta línea de código carga datos en la tabla 'dB_Biblioteca2023DataSet.tblusuario' Puede moverla o quitarla según sea necesario.
            this.tblusuarioTableAdapter.Fill(this.dB_Biblioteca2023DataSet.tblusuario);

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            WtblPrestamo newform = new WtblPrestamo();
            newform.Show();
            this.Hide();
        }
    }
}
