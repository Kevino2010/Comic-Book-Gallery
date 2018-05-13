using System;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
	public class ComicBooksController : Controller
    {
        public ActionResult Details()
		{
			if(DateTime.Now.DayOfWeek == DayOfWeek.Monday){

				return Redirect("/");
			}


			return Content( "Hello From the Comic Books Controller");

        }
    }
}
