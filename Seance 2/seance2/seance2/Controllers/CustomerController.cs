using Microsoft.AspNetCore.Mvc;
using seance2.Models;
using seance2.Views.ViewModels;

namespace seance2.Controllers
{
	public class CustomerController : Controller
	{

		//get
		public IActionResult Index()
		{
			Movie movies = new Movie(1,"Movie 1",true,new DateTime(2000));


			CustomerMovieVM customerVM = new CustomerMovieVM()
			{
				movie = movies,
				customers = GetAll()
			
			
			};

			return View(customerVM);
		}

		private List<Customer> GetAll()
		{
			List<Customer> customer = new List<Customer>();
			customer.Add(new Customer(1, "ahmed"));
			customer.Add(new Customer(2, "ali"));
			customer.Add(new Customer(3, "oussama"));

			return customer;



		}


		public IActionResult show(int? id) {

			if (id == null) return NotFound();

			var c = GetAll().FirstOrDefault(customer => customer.Id == id);


			return View(c);
		}
	}
}
