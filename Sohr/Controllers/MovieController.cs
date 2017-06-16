using Sohr.Models;
using System.Web.Mvc;
using System.Collections.Generic;
using Sohr.ViewModels;

namespace Sohr.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Wonder!" };

            // instead of using ViewData or ViewBag, just pass the parameter to View
            var customers = new List<Customer> {
                new Customer { Name = "Customer 1", Id = 1},
                new Customer { Name = "Customer 2", Id = 2}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            // The 3rd argument is anonymous object
            //return RedirectToAction("Index", "Home", new { page = 1, SortBy = "name" });
        }

        // Default Route, the name of parameter is id
        public ActionResult Edit(int id = 1)
        {
            return Content("id=" + id);
        }


        // ? represents nullable
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 10)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}