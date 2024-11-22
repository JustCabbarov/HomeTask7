using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMETASK11_
{
    public class User : IAccount
    {
        private string _password;
        public static int Counter;
        public int Id { get; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password
        {
            get => _password;
            set
            {
                if (PasswordChecker(value))
                {
                    value = _password;
                }
                else
                {

                    Console.WriteLine("");
                    
                }   
                
            }


        }
        public User()
        {
            
        }
        public User(string fullname, string email, string password)
        {
            Counter++;
            Id = Counter;
            FullName = fullname;
            Email = email;
            Password = password;
        }

        public bool PasswordChecker(string password)
        {
         
            if (password.Length < 8)
            {
                Console.WriteLine("Password must contain at least 8 characters.");
                return false;
            }

         
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;


            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpper = true;
                else if (char.IsLower(c))
                    hasLower = true;
                else if (char.IsDigit(c))
                    hasDigit = true;

                if (hasUpper && hasLower && hasDigit)
                    break;
            }

           
            if (!hasUpper)
            {
                Console.WriteLine("Password must contain at least one uppercase letter.");
                return false;
               
            }
            if (!hasLower)
            {
                Console.WriteLine("Password must contain at least one lowercase letter.");
                return false;
            }
            if (!hasDigit)
            {
                Console.WriteLine("Password must contain at least one digit.");
                return false;
            }

         
            return true;
            
        }

        public void ShowInfo()
        {

            Console.WriteLine($"Id: {Id},  FullName: {FullName},  Email:  {Email}");
        }
    }

}

