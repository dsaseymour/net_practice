using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace DataAnnotations
{
    [Table("Author")]
    class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [MaxLength(15),Required]
        public string FirstName { get; set; }
        [MaxLength(15),Required]        
        public string LastName { get; set; }
        [NotMapped]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public List<Book> Books { get; set; }
    }
}
