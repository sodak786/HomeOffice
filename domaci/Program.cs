
namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        { 
            var pokemon1 = new Pokemon("earth", "second");
            Console.WriteLine(pokemon1.ChoosePokemon()); 
        }
    }
}