using System;

namespace Password_Checker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*()-_=+[]{};:',./<>?";
            string userPassword;
            int score = 0;

            Console.WriteLine("Please create a new password here: \n");
            userPassword = Console.ReadLine();

            int passwordLength = userPassword.Length;

            if (passwordLength >= minLength)
            {
                score++;
            }

            if (Tools.Contains(userPassword, uppercase))
            {
                score++;
            }

            if (Tools.Contains(userPassword, lowercase))
            {
                score++;
            }

            if (Tools.Contains(userPassword, digits))
            {
                score++;
            }

            if (Tools.Contains(userPassword, specialChars))
            {
                score++;
            }

            switch (score)
            {
                case 1:
                    Console.WriteLine("Your pasword is weak");
                    break;

                case 2:
                    Console.WriteLine("Your pasword has medium strength");
                    break;

                case 3:
                    Console.WriteLine("Your pasword is strong");
                    break;

                case 4:
                    Console.WriteLine("Your pasword is extremely strong");
                    break;

                case 5:
                    Console.WriteLine("Your pasword is extremely strong");
                    break;

                default:
                    Console.WriteLine("Password does not meet any of the requierments");
                    break;
            }

        }
    }
}
