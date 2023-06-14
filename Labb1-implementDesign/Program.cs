using Labb1_implementDesign.RunInterface;

namespace Labb1_implementDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singleton använt för att instansiera programmets körning 
            //Factory method för att skapa objekten i programmet åt användaren
            //Abstract Factory då Interfaces är använda för att skapa hela grupper av objekten
            
            IRun login = LoginMenu.Instance;
            login.Run();
        }
    }
}