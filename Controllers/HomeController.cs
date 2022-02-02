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
    }
}