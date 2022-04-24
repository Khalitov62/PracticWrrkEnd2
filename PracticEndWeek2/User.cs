using System;
using System.Collections.Generic;
using System.Text;

namespace PracticEndWeek2
{
    class User : IAccount
    {
        public static int Id=0;

        private  int _id ;
        public string FullName { get; set; }
        public string Email { get; set; }
        private string _password;
        public string Password { get; set; }

        public User( string fullName, string email)
        {
            Id = ++_id;
            FullName = fullName;
            Email = email;

        }
        public bool PasswordChecker(string password)
        {

            if (password.Length >= 8)
            {
                bool hasDigit = false;
                bool hasUpper = false;
                bool hasLower = false;

                foreach (char letter in password)
                {
                    if (char.IsDigit(letter))
                    {
                        hasDigit = true;
                        continue;
                    }
                    if (char.IsUpper(letter))
                    {
                        hasUpper = true;
                        continue;
                    }
                    if (char.IsLower(letter))
                    {
                        hasLower = true;
                        bool result = hasDigit && hasUpper && hasLower;
                    }
                    return true;
                }
                
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($" Id : {Id}, FullName : {FullName}, Email : {Email}");
        }
    }
}
