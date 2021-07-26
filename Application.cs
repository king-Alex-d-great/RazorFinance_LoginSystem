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
            try
            {
                var newaut = new Authentication();
                Console.WriteLine("Please enter email");
                var email = Console.ReadLine();

                var Userdata = (await newaut.selectUserData(email));

                Console.WriteLine("Please enter password");
                var password = Console.ReadLine();
                var validateinfo = newaut.validateUser(email, password);
                    
                if (validateinfo)
                {
                       Console.WriteLine(Userdata.Email);
                       Console.WriteLine(Userdata.Id); 
                } 
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }          
           
        }
        
       
    }
}
