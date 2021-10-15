using Microsoft.AspNetCore.Mvc;
using PointsAndComments_For_lasmart.ru.Models;
using System.Threading.Tasks;

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
        public async Task<JsonResult> GetAllPoint()
        {
            return Json(await repository.GetAllPoints());
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> RemovePoint(int Id)
        {
            if (await repository.DeletePointByID(Id))
            {
                return Json(true);
            }
            return Json(false);
        }
    }
}
