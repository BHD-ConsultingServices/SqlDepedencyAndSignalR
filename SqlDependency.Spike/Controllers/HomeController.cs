
namespace SqlDependency.Spike.Controllers
{
    using System.Web.Mvc;
    using SqlDependency.Spike.Repository;
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetLatestSchedules()
        {
            var repository = new SqlDependencyRepository();
            var outcome = repository.SqlListener();
            var mappedViewModel = outcome.Data.Map();

            return this.PartialView("_RaceSchedulesTable", mappedViewModel);
        }
    }
}