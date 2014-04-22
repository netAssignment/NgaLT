using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment2_7.Models
{
    
        [Table("Topic")]
        public class Topic
        {
            [Key]
            public int TopicID { get; set; }
            [StringLength(250)]
            public string TopicName { get; set; }
            public virtual ICollection<Book> Books { get; set; } //virtual cho phép kéo hết dữ liệu qua lại
        }

        [Table("Book")]
      public class Book
      {
            [Key]
            public int BookID { get; set; }
            public string BookName { get; set; }
             [StringLength(250)]
            public string Discription { get; set; }
            public string Image { get; set; }

          
            public int TopicID { get; set; }
             [ForeignKey("TopicID")]
            public virtual Topic Topic { get; set; }

            public int AuthorID { get; set; }
               [ForeignKey("AuthorID")]
            public virtual Author Author { get; set; }
        }
        [Table("Author")]
        public class Author
        {
            [Key]
            public int AuthorID { get; set; }
            public string AuthorName { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        [Table("User")]
        public class User
        {
            [Key]
            public int UserID { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }

            public virtual ICollection<Roles> Roles { get; set; }
            public virtual ICollection<Comment> Comments { get; set; }
        }

        [Table("Roles")]
        public class Roles
        {
            [Key]
            public int RoleID { get; set; }
            public string Role { get; set; }

            public virtual ICollection<User> Users { get; set; }
        }

        [Table("Comment")]
        public class Comment
        {
            [Key]
            public int CommentID { get; set; }
            public string CommentContent { get; set; }

            public int UserID { get; set; }
            public virtual User User { get; set; }

        }
    
}