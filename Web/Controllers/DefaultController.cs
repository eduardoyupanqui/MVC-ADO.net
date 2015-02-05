using BL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class DefaultController : Controller
    {
        private UsuarioBL usuarioBL = new UsuarioBL();
        private RolBL rolBL = new RolBL();

        public ActionResult Index()
        {
            return View(usuarioBL.Listar());
        }

        public ActionResult Editar(int id = 0) 
        {
            ViewBag.Roles = rolBL.Listar();
            return View(id == 0 ? new Usuario() : usuarioBL.Obtener(id));
        }

        public ActionResult Guardar(Usuario usuario)
        {
            var r = usuario.id > 0 ? 
                    usuarioBL.Actualizar(usuario) : 
                    usuarioBL.Registrar(usuario);

            if (!r) 
            {
                // Podemos validar para mostrar un mensaje personalizado, por ahora el aplicativo se caera por el throw que hay en nuestra capa DAL
                ViewBag.Mensaje = "Ocurrio un error inesperado";
                return View("~/Views/Shared/_Mensajes.cshtml");
            }

            return Redirect("~/");
        }

        public ActionResult Eliminar(int id)
        {
            var r = usuarioBL.Eliminar(id);

            if (!r)
            {
                // Podemos validar para mostrar un mensaje personalizado, por ahora el aplicativo se caera por el throw que hay en nuestra capa DAL
                ViewBag.Mensaje = "Ocurrio un error inesperado";
                return View("~/Views/Shared/_Mensajes.cshtml");
            }

            return Redirect("~/");
        }
    }
}
