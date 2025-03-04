using Microsoft.AspNetCore.Mvc;
using WebApplication2.database;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CatorgoryController : Controller
    {
        private readonly DbClass _db;


        public CatorgoryController(DbClass db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Catorgory> objCategoryList = _db.Catorgory.ToList();        
                return View();
        }
    }
}
