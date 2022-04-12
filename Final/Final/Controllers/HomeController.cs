using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Final.Models;
using Microsoft.EntityFrameworkCore;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        private IQuoteRepository repo;

        public HomeController(IQuoteRepository temp)
        {
            repo = temp;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var quotes = repo.Quotes
                .ToList();

            return View(quotes);
        }

        [HttpGet]
        public IActionResult Details(int quoteid)
        {
            var q = repo.Quotes
                .FirstOrDefault(x => x.QuoteID == quoteid);

            return View("Details", q);
        }

        [HttpGet]
        public IActionResult EnterQuote()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterQuote(Quotes q)
        {
            if (ModelState.IsValid)
            {
                repo.CreateQuote(q);
                return RedirectToAction("Index");
            }
            else
            {
                return View(q);
            }
        }

        [HttpGet]
        public IActionResult Edit(int quoteid)
        {
            var q = repo.Quotes.Single(x => x.QuoteID == quoteid);
            return View(q);
        }

        [HttpPost]
        public IActionResult Edit(Quotes q)
        {
            repo.SaveQuote(q);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int quoteid)
        {
            var q = repo.Quotes.Single(x => x.QuoteID == quoteid);
            return View(q);
        }

        [HttpPost]
        public IActionResult Delete(Quotes q)
        {
            repo.DeleteQuote(q);
            return RedirectToAction("Index");
        }

    }
}
