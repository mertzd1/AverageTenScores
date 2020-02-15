using System;

namespace AverageTenScores

{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int end = 10;
            int sum = 0;
            sum = get_sum(start, end, sum);      
            Console.WriteLine($"The avg is {sum}");
            
            if ((sum >= 0) && (sum <= 59))
                Console.WriteLine("Your grade is an F");

            if ((sum > 59) && (sum <= 69))
                Console.WriteLine("Your grade is a D");
            if ((sum > 69) && (sum <= 79))
                Console.WriteLine("Your grade is a C");
            if ((sum > 79) && (sum <= 89))
                Console.WriteLine("Your grade is a B");
            if ((sum > 89))
                Console.WriteLine("Your grade is an A");
           




        }
       
        private static int get_sum(int start, int end, int sum)
        {
            Console.WriteLine($"get_sum({start}, {end}, {sum})");
            int UserInput = int.Parse(Console.ReadLine());
            start = start + 1;
            sum = sum + UserInput;
            if (start < end)
                return (get_sum(start, end, sum));
            else
                return (sum/end);
            
           
        }
       

}
}
