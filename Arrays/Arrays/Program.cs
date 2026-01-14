namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myarr = new int[] { 2, 5, 22, 39, 7, 18, 22, 52, 29, 10 };


            LNumber(myarr);
            SumAndAvg(myarr);
            EvenAndOdd(myarr);

            int n = 0;
            Console.WriteLine("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            if (myarr.Contains(n)) 
            { 
                Console.WriteLine($"your number is {n} and the index is {System.Array.IndexOf(myarr, n )}");
            }
            else 
            {
                Console.WriteLine("Vakue not found in the array");
            }

            


        }

        public static void LNumber(int[] array) 
        {

            int temp = 0;
            for (int write = 0; write < array.Length; write++)
            {
                for (int sort = 0; sort < array.Length - 1; sort++)
                {
                    if (array[sort] < array[sort + 1])
                    {
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
            }

            Console.WriteLine($"Second larget value:{array[1]}");

        }
        public static void SumAndAvg(int[] array)
        {
            Console.WriteLine($"The sum of the array is: {array.Sum()} \nThe average of the array is: {array.Average()}");
        }
        public static void EvenAndOdd(int[] array)
        {   
            int even = 0;
            int odd = 0;

            foreach (int num in array)
            { 
                if(num % 2 == 0)
                {
                    even++;
                }
                else 
                { 
                    odd++; 
                }
            }

            Console.WriteLine($"Number of EVEN numbers {even}");
            Console.WriteLine($"Number of ODD numbers {odd}");
        }
    }
}
