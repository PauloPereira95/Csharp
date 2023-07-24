//using FirstMVCApp.Views;
using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private List<DogViewModel> dogs = new List<DogViewModel>();
        // usa a view que tem o mesmo nome que o metodo
        // dentro da pasta com o mesmo nome da class (ublic class HelloWorldController)
        // sem o controller
        public IActionResult Index()
        {
            return View(dogs);
        }
        // criar com o mesmo nome da view
        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("Index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index)); // encaminha para o index
        }
        public string Hello()
        {
            return "whos there ?";
        }
    }
}
