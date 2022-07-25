using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SshriyaPieShop.Models;
namespace SshriyaPieShop.Controllers
{   
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepostiory;
        private readonly ICategoryRepository categoryRepostiory;
        public PieController(IPieRepository pieRepostior)
        {
            this._pieRepostiory = pieRepostior;
        }

        public ViewResult List()
        {
            var pies = _pieRepostiory.AllPies;
            return View(pies);
        }

        public ViewResult Details(int id)
        {
            var pie = _pieRepostiory.AllPies.FirstOrDefault(pie => pie.PieId == id);
            return View(pie);

        }

        public ViewResult PiesOfTheWeek()
        {
            var pie = _pieRepostiory.PiesOfTheWeek();
            return View(pie);
        }
        public ViewResult FruitsPies()
        {
            // var categoryid = categoryRepostiory.AllCategories.Select(category => category.CategoryName == "Fruit pies");
            var pie = _pieRepostiory.FruitsPies();
            return View(pie);

        }
        public ViewResult CheeseCakes()
        {

            var pie = _pieRepostiory.Cheesecakes();
            return View(pie);

        }
        public ViewResult SeasonalPies()
        {
            /* var category = categoryRepostiory.AllCategories.Where(category => category.CategoryName == "Seasonal pies");*/
            var pie = _pieRepostiory.Seasonalpies();
            return View(pie);

        }
        public ViewResult AddToCart(int id)
        {
            var pie = _pieRepostiory.AllPies.FirstOrDefault(pie => pie.PieId == id);
            return View(pie);
           

        }
        public ViewResult GetPieById(int id)
        {
            /* var category = categoryRepostiory.AllCategories.Where(category => category.CategoryName == "Seasonal pies");*/
            var pie = _pieRepostiory.GetPieById(id);
            return View(pie);

        }
        

    }

}


