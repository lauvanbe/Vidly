using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Die Hard"};

            var customers = new List<Customer>
            {
                new Customer() {Name = "Customer 1"},
                new Customer() {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

//          return Content("Hello World!");
//          return HttpNotFound();
//          return new EmptyResult();
//          return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});
        }

        public ActionResult ViewMovies()
        {
            var listMovies = new List<Movie>()
            {
                new Movie(){ Name = "Die Hard"},
                new Movie(){ Name = "Seigneur des anneaux"}
            };

            var viewModel = new MoviesMovieViewModel()
            {
                ListMovies = listMovies
            };
            return View(viewModel);
        }
/*        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(string.Format("pageIndex={0}&sortBy{1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}:range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        } */
    }
}