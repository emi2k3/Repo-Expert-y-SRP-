using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            // Se crean libros.
            Shelve shelve1 = new Shelve("A","7");
            Shelve shelve2 = new Shelve("B","3");
            // Se crean estanterias.
            BookinShelve newbookinshelve = new BookinShelve(book1,shelve1);
            BookinShelve newbookinshelve2 = new BookinShelve(book2,shelve2);
            // Se crea las estanterias con los libros dentro.

        }
    }
}