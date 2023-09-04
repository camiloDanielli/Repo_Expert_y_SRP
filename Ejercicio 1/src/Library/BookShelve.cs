namespace Ucu.Poo.Expert
{
    public class ShelveBook(Book libro) //ShelveBook debería ser otra clase
      {
          public static void SendBookToShelve(string sector, string shelve){
              libro.LibrarySector = sector;
              libro.LibraryShelve = shelve;
          }
          
      }
}

