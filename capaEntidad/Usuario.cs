using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Usuario
    {
        public int id {  get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }
    }
}
