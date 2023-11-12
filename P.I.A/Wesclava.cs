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
    public partial class Wesclava : Form
    {
        public Wesclava()
        {
            InitializeComponent();
        }

        private void tblusuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblusuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_Biblioteca2023DataSet);

        }

        private void Wesclava_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_Biblioteca2023DataSet.tblReserva' Puede moverla o quitarla según sea necesario.
            this.tblReservaTableAdapter.Fill(this.dB_Biblioteca2023DataSet.tblReserva);
            // TODO: esta línea de código carga datos en la tabla 'dB_Biblioteca2023DataSet.tblusuario' Puede moverla o quitarla según sea necesario.
            this.tblusuarioTableAdapter.Fill(this.dB_Biblioteca2023DataSet.tblusuario);

        }
    }
}
