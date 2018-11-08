using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.seriesTitle = "The Spider-man";
            ViewBag.issueNumber = 700;
            ViewBag.description = "<p>The Poem Below </P> ";
            ViewBag.artists = new string[]
            {
            "Tokyo to Hokkaido",
            "and an expensive",
            "Taxi to Niseko Tokyo",
            "to the Sapporo, now"
            };
            return View();

        }

    }
}