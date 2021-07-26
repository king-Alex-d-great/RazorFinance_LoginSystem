using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;


namespace RazorFinanceLoginSystem
{
    class Application
    {
        public async Task Run()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to Razor Finance");
            Console.WriteLine();
            try
            {
                var UserInfoHandler = new UserInfoHandler();
                Console.WriteLine("TO LOGIN");
                Console.WriteLine("Please enter email");
                var email = Console.ReadLine();

                var Userdata = (await UserInfoHandler.retrieveUserData(email));

                Console.WriteLine("Please enter password");
                var password = Console.ReadLine();
                var isValidated = UserInfoHandler.validateLoginDetails(email, password);
                    
                if (isValidated)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Hello {Userdata.UserName}");
                    Console.WriteLine($"You are logged in with the following details");
                    Console.WriteLine($"Name : {Userdata.UserName}");
                    Console.WriteLine($"Email : {Userdata.Email}");
                    Console.WriteLine($"ID : {Userdata.Id}");
                    Console.ForegroundColor = ConsoleColor.White;
                } 
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }          
           
        }
        
       
    }
}
