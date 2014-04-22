using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment2_7.Models;
namespace Assignment2_7.Controllers
{
    public class BookController : Controller
    {
        //
        // GET: /Book/

        BookContext db = new BookContext();
        public ActionResult Index(int? id, string topicname)
        {
            
            List<Book> fill= db.Books.Where(p => p.TopicID ==id).ToList();

            ViewBag.topicname = topicname;
            return View(fill);
        }

    }
}
