
namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is your name?");
        // var name = Console.ReadLine();
        // var currentDate = DateTime.Now;
        // Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
        // Console.Write($"{Environment.NewLine}Press Enter to exit...");
        // Console.Read();

        // Console.WriteLine("Hello David!");

        // var firstFriend = "     Maria   ";

        // firstFriend = firstFriend.TrimStart();
        // firstFriend = firstFriend.TrimEnd();

        // string secondFriend = "    Sotty    ";

        // string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}";

        // Console.WriteLine(friends);
        // friends = friends.Replace("Sotty", "Dammys");
        // Console.WriteLine(friends);
        // Console.WriteLine(friends.Contains("Sotty"));
        // Console.WriteLine(friends.ToUpper());
        // Console.WriteLine(friends.Length);


        //Numbers, Intergers
        // int a = 2100000000;
        // int b = 2100000000;
        // long c =  (long)a + (long)b;
        // Console.WriteLine(c);

        //Numbers, Precisions
        // double a = 42.1;
        // double b = 43.2;
        // double c = checked(a + b);
        // Console.WriteLine(c);

        // int a = 18;
        // int b = 6;
        // int c = a + b;
        // int d = (a + b) * c;
        // int e = (a + b) - d * c + (12 * 4) / 3 + 12;
        // Console.WriteLine(c);
        // Console.WriteLine(e);

        // int a = 7;
        // int b = 4;
        // int c = 3;
        // int d = (a + b) / c;
        // int e = (a + b) % c;
        // Console.WriteLine($"quotient: {d}");
        // Console.WriteLine($"remainder: {e}");

        // int max = int.MaxValue;
        // int min = int.MinValue;
        // Console.WriteLine($"The range of integers is {min} to {max}");

        // double a = 42.1; //neutral type
        // float b = 38.2F;
        // double c = a + b;
        // Console.WriteLine(c);

        // decimal a = 42.1M; // explicit type 
        // decimal b = 38.2M;
        // decimal c = a + b;
        // // Console.WriteLine(c);

        // bool myTest = a > b;
        // if (myTest)
        // {
        //     Console.WriteLine("a is greater than b");
        // }
        // else
        // {
        //     Console.WriteLine("b is greater than a");
        // }

        // int counter = 0;
        // while(counter < 5){
        //     Console.WriteLine($"Hello World! The counter is {counter}");
        //     counter++;
        // }

        // for (int i = 0; i < 5; i++)
        // {
        //     if (i == 3)
        //     {
        //         Console.WriteLine(i);
        //     }

        //     Console.WriteLine($"Hello World! The counter is {i}");
        // }

        // var names = new List<string>
        // {
        //     "David",
        //     "Maria",
        //     "Dammys",
        //     "Sotty",
        //     "Jacks"
        // };

        // names.Sort();

        // for (int i = 0; i < names.Count; i++)
        // {
        //     Console.WriteLine($"Hello {names[i].ToLowerInvariant()}");
        // }

        // List<int> fibonacciNumbers = [10, 20, 30, 40, 50, 60, 70, 80, 90, 100];
        // fibonacciNumbers.RemoveAt(3);
        // foreach(var item in fibonacciNumbers){
        //     Console.WriteLine(item);
        // }

        // var products = new string[]
        // {
        //     "TV",
        //     "Phone",
        //     "PC",
        // };

        // products = [..products, "Tablet"];

        // foreach (var product in products[1..4])
        // {
        //     Console.WriteLine($"The product is {product.ToUpper()}");
        // }

        // System.Console.WriteLine(products[0]);
        // System.Console.WriteLine(products[^1]);

        // var numbers = new List<int>{100, 50, 30, 40, 15, 20, 99, 150};
        // System.Console.WriteLine($"I found number 99 at index {numbers.IndexOf(99)}");
        // numbers.Sort();
        // System.Console.WriteLine($"I found number 99 at index {numbers.IndexOf(99)}");
        // foreach(var number in numbers){
        //     Console.WriteLine(number);
        // }



        /**************  LINQ *****************/

        //Define Datasources
        int[] scores = [2, 97, 92, 81, 60, 58, 95];

        Console.WriteLine("Scores greater than 60 by Imperative(Navie) Way");
        Console.WriteLine("------------------------------");
        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] > 60)
            {
                Console.WriteLine(scores[i] + " ");
            }
        }

        Console.WriteLine("Scores greater than 60 by Declarative Way");
        Console.WriteLine("------------------------------");
        //Define Query Expressions
        IEnumerable<string> scoreQuery = 
        from score in scores 
        where score > 60 
        orderby score descending
        select $"The score is {score}";

        //Execute Query
        foreach (var s in scoreQuery)
        {
            Console.WriteLine(s);
        }

        int scoreCount = scoreQuery.Count();
        Console.WriteLine($"Number of scores greater than 60: {scoreCount}");

    }
}