using System;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program : IAccount
    {
        static void Main(string[] args)
        {
            User user = new User("DSA ADS", "DASSD", "DASDASs8");
            user.ShowInfo();
        }

    }

    class User : IAccount
    {
        private string _FullName;
        private string _Email;
        private string _Password;

        public User(string fullname, string email, string password)
        {
            _FullName = fullname;
            _Email = email;
            Password = password;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Full Name: " + _FullName);
            Console.WriteLine("Email: " + _Email);
        }

        public string Password
        {
            get
            {
                return Password;
            }

            set
            {
                if (IAccount.PasswordChecker(value))
                {
                    _Password = value;
                }
                else
                {
                    throw new Exception("Wrong Password.");
                }
            }
        }
        
        
    }
}