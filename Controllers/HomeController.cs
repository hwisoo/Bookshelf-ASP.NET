using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bookshelf.Models;

namespace Bookshelf.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BookDetail()
        {
            var book = new Book()
            {
                BookTitle = "War and Peace",
                Year = 1869,
                Author = new Author() { FirstName = "Leo", LastName = "Tolstoy" },
                Description = "Often called the greatest novel ever written, War and Peace is at once an epic of the Napoleonic wars, a philosophical study, and a celebration of the Russian spirit. Tolstoy's genius is clearly seen in the multitude of characters in this massive chronicle, all of them fully realized and equally memorable. Out of this complex narrative emerges a profound examination of the individual's place in the historical process, one that makes it clear why Thomas Mann praised Tolstoy for his Homeric powers and placed War and Peace in the same category as The Iliad.",
                Image = "https://images-na.ssl-images-amazon.com/images/I/51fyqN7woLL._SY346_.jpg"
            };

            return View(book);
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
