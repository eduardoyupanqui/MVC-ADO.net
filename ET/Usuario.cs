using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class Usuario
    {
        public int id { get; set;}
        public string Nombre{ get; set; }
        public string Apellido { get; set; }
        public int Rol_id { get; set; }

        public Rol Rol { get; set; }

        public Usuario() 
        {
            Rol = new Rol();
        }
    }
}
