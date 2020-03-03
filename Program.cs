using System;

namespace UsernamePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string sysUsername = "bob";
            string sysPassword = "Password";

            string username;
            string password;

            System.Console.WriteLine("Please enter username");
            username = Console.ReadLine();


            if (username == sysUsername)
            {
                System.Console.WriteLine("Please enter your password");
                password = Console.ReadLine();

                if (password == sysPassword)
                {
                    System.Console.WriteLine("Login Successful");
                }
                else
                {
                    System.Console.WriteLine("Login Unsuccessful");
                }

            }
            else
            {
                System.Console.WriteLine("Login Unsuccessful");
            }
        }
    }
}
