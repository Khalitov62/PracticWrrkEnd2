using System;
using System.Collections.Generic;
using System.Text;

namespace PracticEndWeek2
{
    interface IAccount
    {
        public bool PasswordChecker(string password);
        public void ShowInfo();
    }
}
