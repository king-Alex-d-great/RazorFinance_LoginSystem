using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace RazorFinanceLoginSystem
{
    class UserInfoHandler
    {
        Database database = new Database();
        public async Task<UserData> retrieveUserData(string email)
        {
            return database.UserData().FirstOrDefault(userdata => userdata.Email == email); 
        }
        
        public bool validateLoginDetails (string email, string password)
        {
            var isValidated = false;

            var result = database.LoginDetails().Where(x => x.Email.Equals(email)).Where(y => y.Password.Equals(password));

            if (result.Count() == 0 )
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your email or password is Incorrect\nor you aren't registered to this service\n");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Please run this program again to try again");  
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                isValidated = true;
            }
            return isValidated;
        } 
    }

    
}
