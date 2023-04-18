using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TALWebAPI.Controllers
{
    [ApiController]
    [Route("Calculate")]
    public class CalculateController : Controller
    {
        // GET: CalculateController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CalculateController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CalculateController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CalculateController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculateController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CalculateController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculateController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CalculateController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
