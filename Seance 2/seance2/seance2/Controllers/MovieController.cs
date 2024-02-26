using Microsoft.AspNetCore.Mvc;
using seance2.Models;
using System.Diagnostics.CodeAnalysis;

namespace seance2.Controllers
{
    public class MovieController : Controller
    {

        private readonly AppDbContext _db;

        public MovieController(AppDbContext _db) { this._db = _db; }
        //Get 
        public IActionResult Index()
        {
            

          /*  List<Movie> ListMovie = new List<Movie>();

            ListMovie.Add(new Movie(1, "The100"));
            ListMovie.Add(new Movie(2, "choufli 7al"));
            ListMovie.Add(new Movie(3, "nsibti la3ziza"));
            ListMovie.Add(new Movie(4, "peaky blinders"));
            Console.WriteLine(ListMovie);*/
          

            var ListMovie=_db.movies.ToList();
			return View(ListMovie);
        }

		public IActionResult Index2()
		{


			/*  List<Movie> ListMovie = new List<Movie>();

			  ListMovie.Add(new Movie(1, "The100"));
			  ListMovie.Add(new Movie(2, "choufli 7al"));
			  ListMovie.Add(new Movie(3, "nsibti la3ziza"));
			  ListMovie.Add(new Movie(4, "peaky blinders"));
			  Console.WriteLine(ListMovie);*/


			var ListMovie = _db.movies.ToList();
			return View(ListMovie);
		}

		public IActionResult Edit(int id)
           
        {

             
            return Content("Test Id : " +id);
        }
    }
}
