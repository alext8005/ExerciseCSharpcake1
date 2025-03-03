namespace ExerciseCSharpcake;

class Program
{
    static void Main(string[] args)
    {
        string dessertName = "cake";
        int dessertSlices = 10;
        char cakeCode = 'C';
        bool cakeChocolate = true;
        double chocolatePrice = 10.50;
        decimal monthlyCakeSales = 1000.50m;
        
        Console.WriteLine($"The best dessert is {dessertName}.");
        Console.WriteLine($"They are best when cut in {dessertSlices} slices.");
        Console.WriteLine($"If it is a chocolate cake we use code {cakeCode}.");
        Console.WriteLine($"Each chocolate cake is sold for {chocolatePrice}.");
        Console.WriteLine($"Every month the bakery sells {monthlyCakeSales} in cakes.");
        
       if (cakeChocolate)
        {
            Console.WriteLine("It is made with organic chocolate");
        }
        else
        {
            Console.WriteLine("It's vanilla flavor.");
        }
    }
}