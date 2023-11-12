/*
 * Marlon Trujillo Jaramillo
 * cc: 1017151834
 * 17/808/2023
 */
using capaEntidad;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace P.I.A
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        static readonly string connectionString = "server=DESKTOP-0TA4RKL;database=Conexion;integrated security=true";
        byte cont = 0;

        private void btnOk_Click(object sender, EventArgs e)
        {
            string qry = "select * from usuario";
            using (SqlConnection Conex = new SqlConnection(connectionString))
            {
                SqlCommand Comando = new SqlCommand(qry, Conex);
                try
                {
                    Conex.Open();

                    SqlDataReader miLector = Comando.ExecuteReader();

                    if (validar(txtUsuario.Text, txtContraseña.Text) == true)
                    {
                        bool bandera = false;
                        while (miLector.HasRows)
                        {
                            miLector.Read();
                            Usuario usuario = new Usuario();
                            usuario.usuario = (string)miLector.GetString(1);
                            usuario.contrasenia = (string)miLector.GetString(2);

                            if (txtUsuario.Text == usuario.usuario || txtContraseña.Text == usuario.contrasenia)
                            {
                                bandera = true;
                                break;
                            }
                        }
                        if (bandera == true)
                        {
                            WtblEjemplar newform = new WtblEjemplar();
                            newform.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Inténtelo otra vez");
                            LimpiarCampos();
                            cont++;
                            if (cont == 3)
                            {
                                Application.Exit();
                                MessageBox.Show("Bloqueado por intentos fallidos");
                            }
                        }
                    }else
                    {
                        MessageBox.Show("Llene ambos campos por favor");
                        LimpiarCampos();
                    }
                    Conex.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validar(txtUsuario.Text,txtContraseña.Text) == true)
            {
                try
                {
                    using (SqlConnection Conex = new SqlConnection(connectionString))
                    {
                        Conex.Open();

                        string insertQuery = "INSERT INTO usuario (usuario, contrasenia) VALUES (@usuario, @contrasenia)";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, Conex);
                        insertCommand.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                        insertCommand.Parameters.AddWithValue("@contrasenia", txtContraseña.Text);

                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("Usuario registrado :)");
                        Conex.Close();
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Llene ambos campos, por favor");
            }
        }
        private void LimpiarCampos()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }
        private bool validar(string usuario, string contrasenia)
        {
            bool bandera;
            if (usuario != "" && contrasenia != "") return bandera = true;
            else return bandera = false;
        }
    }
}

