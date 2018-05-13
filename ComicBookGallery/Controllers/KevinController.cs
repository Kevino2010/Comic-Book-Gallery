using System;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
	public class ComicBooksController : Controller
    {
        public string Details()
		{
			return "Hello From the Comic Books Controller";

        }
    }
}
