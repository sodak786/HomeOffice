using System.Diagnostics;
namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        { 
            Pokemon pokemon1 = new Pokemon("fire", "second");
            Console.WriteLine(pokemon1.ChoosePokemon()); 
        }
    }
}