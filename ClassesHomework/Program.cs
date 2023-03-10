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

        static public int Sum(int num)
        {
            
            if (num == 0)
                return 0;

            return num + Sum(num -1);
        }


        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine(n); // 10

            n++;
            Console.WriteLine(n); // 11
            
            n += ++n;
            Console.WriteLine(n); // 11 + 12 = 23
            Console.WriteLine(n++); // 23
            Console.WriteLine(n);  // 24
                                 //Console.WriteLine(Sum(100));
                                 ////Console.WriteLine(Factorial(5));\
                                 //Random random= new Random();
                                 //Struct1 struct1= new Struct1();

            //Console.Write("Input length: ");
            //int length = Convert.ToInt32(Console.ReadLine());
            //int[] nums = new int[length];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = random.Next(10, 100);
            //}

            //string[] numsStr = struct1.Change(nums);

            ////for (int i = 0; i < numsStr.Length; i++)
            ////{
            ////    Console.Write($" {numsStr[i]} ");
            ////}
            ////Console.WriteLine();

            //int a  7;
            //Console.WriteLine();

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
    struct Struct1
    {
        public string[] Change(int[] numbers)
        {
            string[] result = new string[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                //result[i] = Convert.ToString(numbers[i]);
                result[i] = numbers[i].ToString();
            }
            
            return result;
        }
    }
}