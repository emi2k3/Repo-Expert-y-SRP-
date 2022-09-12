using System;

namespace SRP
{
    public class Book
    {
        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
       //Para crear un libro se necesita conocer el título el autor y el código del mismo. La clase solo se encarga de crear el mismo

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

   

    }

    public class Shelve{
         public string LibrarySector { get; }
         public string LibraryShelve { get; }
         // Se conoce el sector y el número donde se guardara el libro y luego se crea el estante.

             public Shelve(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
    }

    public class BookinShelve{
        public Book SavedBook{ get; }
        public Shelve SavedShelve{ get;}
        // Al conocer el libro y el estante donde se va a guardar, se crea el objeto con el libro y la estanteria dentro.
            public BookinShelve(Book SavedBook, Shelve SavedShelve){
                this.SavedBook=SavedBook;
                this.SavedShelve=SavedShelve;
            }

    }
}
