using System.Web.Mvc;
using WebRazor.Models;

namespace WebRazor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            MantenimientoArticulo ma = new MantenimientoArticulo();
            return View(ma.Listar());
        }
        public ActionResult Alta()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Alta(FormCollection collection)
        {
            Articulo art = new Articulo();
            //art.Codigo = int.Parse(collection["codigo"]);
            art.Descripcion = collection["descripcion"];
            art.Precio = float.Parse(collection["precio"]);
            MantenimientoArticulo man = new MantenimientoArticulo();
            man.Alta(art);
            return RedirectToAction("Index"); ;
        }


    }
}