using System;

namespace Ucu.Poo.Expert
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibrarySector { get ; set;}
        public string LibraryShelve { get ; set;}
        

        /*No cumple con el principio de responsabilidad única porque además de los datos intrínsecos del libro, 
        la clase Book maneja el lugar de la librería que ocupa el libro, y contiene un método para colocar al 
        libro en un lugar de la librería, si este método cambia la clase cambiaría, por esta razón no cumple con el SRP. */

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

       

    }

    
    
}
