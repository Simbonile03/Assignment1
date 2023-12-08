namespace BottlesOfBeers 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beersLeft = 99;
            while (beersLeft > 2)
            {
                Console.WriteLine(beersLeft + " bottles of beer on the wall," + beersLeft + " bottles of beer.");
                beersLeft--;

                Console.WriteLine("Take one down and pass it around," + beersLeft + " bottles of beer on the wall.");
            } 
            Console.WriteLine(beersLeft + " bottles of beer on the wall," + beersLeft + " bottles of beer."); beersLeft--;



            Console.WriteLine("Take one down and pass it around," + beersLeft + " bottle of beer on the wall.");


            Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer");
          
        }
    }
}
