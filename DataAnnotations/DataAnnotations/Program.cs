using System;

namespace DataAnnotations
{
    
    class Program
    {
        static void Main(string[] args) {

            #region Different Methods of Insertion
            /*
            ShopDbContext shopDbContext = new ShopDbContext();

            //insertion to authors table
            Author author = new Author()
                {
                    FirstName = "Jim",
                    LastName = "Rohn"
                };
                shopDbContext.Authors.Add(author);//insert operation
                //adds to the context, not to the memory until we call savechanges 
                shopDbContext.SaveChanges();


                //another way to do an insertion
                author = new Author()
                {
                    FirstName = "Tupac",
                    LastName = "Shakur"
                };
                shopDbContext.Add<Author>(author);
                shopDbContext.SaveChanges();
                */
            #endregion
            //implicit disposal of dbContext
            using (ShopDbContext shopDbContext=new ShopDbContext()) {
                
                Author author = shopDbContext.Authors.Find(); 

            }




        }

    }
}
