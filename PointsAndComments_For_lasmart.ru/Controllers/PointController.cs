using Microsoft.AspNetCore.Mvc;
using PointsAndComments_For_lasmart.ru.Models;

namespace PointsAndComments_For_lasmart.ru.Controllers
{
    public class PointController : Controller
    {
        IRepository repository;
        public PointController(IRepository repo)
        {
            repository = repo;
        }
        [HttpGet]
        public JsonResult GetAllPoint() {
            var jsonResult = Json(repository.GetAllPoints());
            return Json(jsonResult, JsonRequestBehavior.AllowGet); ;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
