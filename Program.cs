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

        int counter = 0;
        while(counter < 5){
            Console.WriteLine($"Hello World! The counter is {counter}");
            counter++;
        }


    }
}