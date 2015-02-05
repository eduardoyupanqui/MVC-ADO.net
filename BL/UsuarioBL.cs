using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UsuarioBL
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();

        public List<Usuario> Listar()
        {
            return usuarioDAL.Listar();
        }
        public Usuario Obtener(int id)
        {
            return usuarioDAL.Obtener(id);
        }

        public bool Actualizar(Usuario usuario)
        {
            return usuarioDAL.Actualizar(usuario);
        }

        public bool Registrar(Usuario usuario)
        {
            return usuarioDAL.Registrar(usuario);
        }

        public bool Eliminar(int id)
        {
            return usuarioDAL.Eliminar(id);
        }
    }
}
