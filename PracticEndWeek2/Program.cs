
using System;

namespace PracticEndWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Menu********");
            int check;
            Group group = null;
            
            do
            {
                
                Console.WriteLine("Please enter Name and Surname");
                string fullName = Console.ReadLine();
                Console.WriteLine("Please enter Email");
                string email = Console.ReadLine();
                Console.WriteLine("Please enter Password");
                string password;
                User user = new User(fullName, email);

                do
                {
                    password = Console.ReadLine();

                } while (user.PasswordChecker(password));
                Console.Clear();
                
                bool checkFirst = true;
                do
                {
                    Console.WriteLine("1. Show All Students");
                    Console.WriteLine("2. Create new Group");
                    Console.WriteLine("3. Add Student");
                    Console.WriteLine("0. Quit");
                    Group group1 = new Group(204,"Islam Xalitov", 100, 13);
                    string choose = Console.ReadLine();
                    switch (choose)
                    {
                        case "1":
                            user.ShowInfo();
                            break;
                        case "2":
                            group.GetAllStudents();
                            break;
                        case "3":

                        default:
                            break;
                    }
                } while (!checkFirst);

            } while (!check);
            

        }
    }
}
