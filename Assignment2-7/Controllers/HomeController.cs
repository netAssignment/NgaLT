using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment2_7.Models;


namespace Assignment2_7.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        private BookContext dbb = new BookContext();

        public ActionResult Index()
        {
            var j = dbb.Authors.ToList();
            using (var db = new BookContext())
            {


                var author1 = new Author { AuthorName = "Nguyễn A", Phone = "1234567", Address = "Quận 1" };
                var author2 = new Author { AuthorName = "Lê Nga", Phone = "1234567", Address = "Thủ Đức" };
                var author3 = new Author { AuthorName = "Phan Anh", Phone = "1234567", Address = "Quận 3" };
                var author4 = new Author { AuthorName = "Lê Văn", Phone = "1234567", Address = "Quận 2" };

                var au1 = db.Authors.Find(1);
                if (au1 == null) db.Authors.Add(author1);

                var au2 = db.Authors.Find(2);
                if (au2 == null) db.Authors.Add(author2);

                var au3 = db.Authors.Find(3);
                if (au3 == null) db.Authors.Add(author3);

                var au4 = db.Authors.Find(4);
                if (au4 == null) db.Authors.Add(author4);
                db.SaveChanges();

                ////---------------------------------------------------------------
                var topic1 = new Topic { TopicName = "Lập trình C++" };
                var topic2 = new Topic { TopicName = "Lập trình C#" };
                var topic3 = new Topic { TopicName = "Lập trình PHP" };
                var topic4= new Topic { TopicName = "Lập trình Java" };
                var topic5 = new Topic { TopicName = "Lập trình Di Động" };

                var tp1 = db.Topics.Find(1);
                if (tp1 == null) db.Topics.Add(topic1);

                var tp2 = db.Topics.Find(2);
                if (tp2 == null) db.Topics.Add(topic2);

                var tp3 = db.Topics.Find(3);
                if (tp3 == null) db.Topics.Add(topic3);

                var tp4 = db.Topics.Find(4);
                if (tp4 == null) db.Topics.Add(topic4);

                db.SaveChanges();

                ////------------------------------------------------------------------------------------------------------------
                var book1 = new Book { BookName = "Lập trình Căn Bản", Discription = "Hay", Image = "", TopicID = topic1.TopicID, AuthorID = author1.AuthorID };
                var book2 = new Book { BookName = "Xử lí ảnh", Discription = "Hay", Image = "", TopicID = topic1.TopicID, AuthorID = author1.AuthorID };
                var book3 = new Book { BookName = "Lập trình Nâng cao", Discription = "Hay", Image = "", TopicID = topic1.TopicID, AuthorID = author2.AuthorID };
                var book4 = new Book { BookName = "Đồ họa", Discription = "Hay", Image = "", TopicID = topic1.TopicID, AuthorID = author2.AuthorID };
                var book5 = new Book { BookName = "ASP.Net", Discription = "Hay", Image = "", TopicID = topic2.TopicID, AuthorID = author3.AuthorID };
                var book6 = new Book { BookName = "Lập trình Căn Bản", Discription = "Hay", Image = "", TopicID = topic2.TopicID, AuthorID = author3.AuthorID };
                var book7 = new Book { BookName = "Lập trình Nâng Cap", Discription = "Hay", Image = "", TopicID = topic2.TopicID, AuthorID = author4.AuthorID };
                var book8 = new Book { BookName = "ASP.MVC4", Discription = "Hay", Image = "", TopicID = topic2.TopicID, AuthorID = author4.AuthorID };

                var b1 = db.Books.Find(1);
                if (b1 == null) db.Books.Add(book1);

                var b2 = db.Books.Find(2);
                if (b2 == null) db.Books.Add(book2);

                var b3 = db.Books.Find(3);
                if (b3 == null) db.Books.Add(book3);

                var b4 = db.Books.Find(4);
                if (b4 == null) db.Books.Add(book4);

                var b5 = db.Books.Find(5);
                if (b5 == null) db.Books.Add(book5);

                var b6 = db.Books.Find(6);
                if (b6 == null) db.Books.Add(book6);

                var b7 = db.Books.Find(7);
                if (b7 == null) db.Books.Add(book7);

                var b8 = db.Books.Find(8);
                if (b8 == null) db.Books.Add(book8);


                db.SaveChanges();
            }



            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }
        public PartialViewResult _TopicBookPartial()
        {
   
            
                         
               
            return PartialView(dbb.Topics.ToList());


        }

        
       public ActionResult text()
        {
            return View();
       }
    
           
            
        
    }
}
