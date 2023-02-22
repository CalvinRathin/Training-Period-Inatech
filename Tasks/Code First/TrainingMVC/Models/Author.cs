using System.ComponentModel.DataAnnotations;

namespace TrainingMVC.Models
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        [Required]
        public string? First_Name { get; set; }

        public string? Last_Name { get; set; }
        public string? Country { get; set; }

       public  ICollection<Book> Books { get; set; }

        //ICollection<BOOK> IS ADDED HERE TO AVOID REPETITION OF SAME AUTHOR ID
        //  ,bECAUSE WE DONT NEED MULTPLE AUTHOR ID FOR SAME author.so we add here
        //and not in books



        // check create.cshtml , line 27 of code
        //viewbag.AuthorID -> this line from create.cshtml
        //      refers to the first name of the author
    }
}