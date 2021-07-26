using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace RazorFinanceLoginSystem
{
    class Authentication
    {
        Database database = new Database();
        public async Task<UserData> selectUserData(string email)
        {
            return database.UserData().FirstOrDefault(ud => ud.Email == email);
            
            /*var result = from data in database.UserData()
                         where data.Email.Equals(email)
                         select new UserData {Email = data.Email, Id = data.Id, UserName = data.UserName };*/           
        }
        
        public bool validateUser (string email, string password)
        {
            var isValidated = false;
            var result = from detail in database.LoginDetails()
                         where detail.Email.Equals(email)
                         where detail.Password.Equals(password)
                         select detail.ToString();
            if (result.Count() == 0 )
            {
                Console.WriteLine("User not found");
            }
            else
            {
                isValidated = true;
            }

            return isValidated;
        } 
    }

    
}
