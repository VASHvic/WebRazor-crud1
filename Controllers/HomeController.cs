using System.Web.Mvc;
using WebRazor.Models;

namespace WebRazor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection coleccion)
        {
            MantenimientoArticulo ma = new MantenimientoArticulo();
            Articulo art = ma.Recuperar(int.Parse(coleccion["Codigo"].ToString()));
            if (art != null)
                return View("ModificacionArticulo", art);
            else
                return View("ArticuloNoExistente");
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult ModificacionArticulo(FormCollection collection)
        {
            MantenimientoArticulo ma = new MantenimientoArticulo();
            Articulo art = new Articulo();
            art.Codigo = int.Parse(collection["Codigo"].ToString());
            art.Descripcion = collection["Descripcion"].ToString();
            art.Precio = float.Parse(collection["Precio"].ToString());
            ma.Modificar(art);
            return RedirectToAction("Index");

        }
    }
}