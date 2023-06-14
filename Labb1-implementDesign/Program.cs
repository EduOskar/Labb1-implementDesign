namespace Labb1_implementDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singleton använt för att instansiera programmets körning 
            //
            LoginMenu login = LoginMenu.Instance;
            login.Run();
            



        }
    }
}