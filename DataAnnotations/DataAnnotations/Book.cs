using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAnnotations
{
    [Table("Book")]
    class Book
    {
        [Key,Column(Order =0)]
        public int BookId { get; set; }
        [Column(Order =1)]
        public string BookName { get; set; }
        //whenever we are updating price, check the old price
        //if the old price is the same then update else while I was trying to update it the value changed so don't update
        [ConcurrencyCheck, Column(Order =2),Required]
        public double PricePerUnit { get; set; }
        [Column(Order =3),DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedOn { get; set; }
        //the foreign key is already being done by default convention but this is stating it explicitly
        [ForeignKey("Author")]
        public int AuthorId { get; set;}
        public Author Author { get; set; }

    }
}
