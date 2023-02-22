using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingMVC.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        [ForeignKey("Author")]
        public int AuthorID { get; set; }
        public Author? Authors { get; set; } //THE CLASS CONTAINING THE FOREIGN KEY
                                           //HAS THIS LINE , 

        //public Author (author)--this is user defined

        //this line is used for mapping
        //without this line the code wont work (The migration part)
    }
}
