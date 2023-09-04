namespace Ucu.Poo.Expert
{
    public class ShelveBook //ShelveBook debería ser otra clase
      {
          public static void SendBookToShelve(Book libro, string sector, string shelve){
              libro.LibrarySector = sector;
              libro.LibraryShelve = shelve;
          }
          
      }
}

