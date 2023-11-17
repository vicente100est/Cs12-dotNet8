namespace _01_spread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] beers1 = ["Sol", "Corona"];
            string[] beers2 = ["Heinken", "Erdiger"];
            string[] beers3 = ["Guinnss", "Delifium"];

            string[] beers = [.. beers1, .. beers2, .. beers3];

            foreach (string beer in beers)
            {
                Console.WriteLine(beer + ", ");
            }
        }
    }
}
