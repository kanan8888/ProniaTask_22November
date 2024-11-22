using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication_Pronia_AB107_22November.DAL;
using WebApplication_Pronia_AB107_22November.Models;

namespace WebApplication_Pronia_AB107_22November.Controllers
{
    public class HomeController : Controller
    {

        AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            this._db = db;
        }

        public IActionResult Index()
        {
            List<Product> products = _db.Products.Include(p=> p.ProductImages).ToList();




            return View(products);
        }
    }
}
