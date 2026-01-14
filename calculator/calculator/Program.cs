namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            double num1 = 0, num2 = 0;

            //Console.WriteLine(isValidPass("Angel1234"));

            //countVowelConst("mondongo");

            Console.WriteLine("Enter first number");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = double.Parse(Console.ReadLine());

            

            do
            {
                

                Console.WriteLine("Calculator Menu");
                Console.WriteLine("1 . ADD ");
                Console.WriteLine("2 . Sub");
                Console.WriteLine("3. Mult");
                Console.WriteLine("4. Div");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Give me your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ADD(num1, num2);
                        break;
                    case 2:
                        SUB(num1, num2);
                        break;
                    case 3:
                        MULT(num1, num2);
                        break;
                    case 4:
                        DIV(num1, num2);
                        break;         
                }

                } while (choice != 5);

        }

        //methods

        public static void ADD(double num1, double num2)
        {
            Console.WriteLine($"The result is: " + (num1 + num2));      
        }

        static void SUB(double num1, double num2)
        {
            Console.WriteLine($"The result is: " + (num1 - num2));
        }

        static void MULT(double num1, double num2)
        {
            Console.WriteLine($"The result is: " + (num1 * num2));
        }

        static void DIV(double num1, double num2)
        {

            Console.WriteLine($"The result is: " + (num1 / num2));
        }

        public static bool isValidPass(string pass)
        { //checklength
            if (pass.Length < 0) 
            { 
                return false;
            }
            int digitcount = 0;
            int uppercount = 0;

            foreach (char ch in pass)
            {
                if (char.IsDigit(ch))
                { digitcount++; }
                if (char.IsUpper(ch))
                { uppercount++; }
            }

            if (digitcount > 0 && uppercount > 0)
            { return true; }

            return false;  
        }

        public static void countVowelConst(string text)
        {
            int vow = 0;
            int conts = 0;

            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                {
                    if ("aeiou".Contains(ch))
                    {
                        vow++;
                    }
                    else
                    {
                        conts++;
                    }
                }
            }

            Console.WriteLine($"The number of vowel is: {vow}");
            Console.WriteLine($"The number of constant is: {conts}");
        }
    }
}
