namespace ClassesHomework
{
    internal class Program
    {
        static public int? Nul1()
        {
            int? n = 5;
            int? x = 6;
            int? y = 7;
            int? z = 8;

            return n * x * y * z;
        }
        static public int Factorial(int num)
        {
            if (num == 1) 
                return 1;
            //Factorial(num);
            return num * Factorial(num-1);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Factorial(5));
            Human human = new Human();
            Console.WriteLine(human.Validation("fdsfj12dsjflkf"));
            Console.WriteLine("...");
            //Human human = new Human(); // human class homework
            //string name, surname, nameSurname;
            //bool validation;

            //do
            //{
            //    Console.Write("Input name: ");
            //    name = Console.ReadLine();

            //    Console.Write("Input surname: ");
            //    surname = Console.ReadLine();

            //    nameSurname = name + surname;

            //    validation = human.Validation(nameSurname);   

            //} while (validation == false);

            //Console.Write("Input letter: ");
            //char letter = char.Parse(Console.ReadLine());

            //Console.WriteLine(human.Check(in nameSurname,letter));
            //Console.WriteLine("Done;]");

            //Restaurant restaurant = new Restaurant();
            //Restaurant restaurant1 = new Restaurant( 5);
            //restaurant.MakeSushi(2);

            //Console.WriteLine(restaurant.sushi);
            //Console.WriteLine(restaurant.hotdog);

        }
    }
}