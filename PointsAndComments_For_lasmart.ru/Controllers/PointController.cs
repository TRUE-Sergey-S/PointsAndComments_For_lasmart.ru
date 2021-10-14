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
        public ActionResult GetAllPoint() {
            var jsonResult = Json(repository.GetAllPoints());
            return jsonResult;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
