using System;
using System.Collections.Generic;
using System.Text;

namespace RazorFinanceLoginSystem
{
    class Database
    {
        public IEnumerable<UserData> UserData()
        {
            return new List<UserData>
            {
                new UserData {Id = 1 , UserName="Samuel", Password="Samuel1234", Email ="sakinbarnessamuel@gmail.com"},
                new UserData {Id = 2 , UserName="Kachi", Password="Kachi1234", Email ="ugwu_kennedy@yahoo.com"},
                new UserData {Id = 3 , UserName="Alex", Password="Alex1234", Email ="ogubuikealex@gmail.com"},
                new UserData {Id = 4 , UserName="Loveth", Password="Loveth1234", Email ="lovethanosike1@gmail.com"},
                new UserData {Id = 5 , UserName="Sholzz", Password="Sholzz1234", Email ="sholanejo@live.com"},
                new UserData {Id = 6 , UserName="Sunday", Password="Sunday1234", Email ="slimake01 @gmail.com"},
                new UserData {Id = 7 , UserName="Chikki", Password="Chikki1234", Email ="chiagudike@gmail.com"},
                new UserData {Id = 8 , UserName="Tochukwu", Password="Tochukwu1234", Email ="tochukwusage4@gmail.com"},
                new UserData {Id = 9 , UserName="Uriel", Password="Uriel1234", Email ="X3meuriel@gmail.com"},
                new UserData {Id = 10 , UserName="Kaycee", Password="Kaycee1234", Email ="egwunwokekc@gmail.com"},
                new UserData {Id = 11 , UserName="Sammy", Password="Sammy1234", Email ="ehuerikenbaba@gmail.com"},
                new UserData {Id = 12 , UserName="Dara", Password="Dara1234", Email ="johnoluwadara@gmail.com"},
                new UserData {Id = 13 , UserName="Obinna", Password="Obinna1234", Email ="obynomagic@gmail.com"},
                new UserData {Id = 14 , UserName="Francis", Password="Francis1234", Email ="francisogbonna24@gmail.com"},
                new UserData {Id = 15 , UserName="Chinedu", Password="Chinedu1234", Email ="Chinedu.mbah.g20 @gmail.com"},
                new UserData {Id = 16 , UserName="Gideon", Password="Gideon1234", Email ="akunanagideon@gmail.com"},                
            };
        }

        public IEnumerable<LoginDetails> LoginDetails()
        {
            return new List<LoginDetails>
            {
                new LoginDetails {Password="Samuel1234", Email ="sakinbarnessamuel@gmail.com" },
                new LoginDetails {Password="Kachi1234", Email ="ugwu_kennedy@yahoo.com" },
                new LoginDetails {Password="Alex1234", Email ="ogubuikealex@gmail.com" },
                new LoginDetails {Password="Loveth1234", Email ="lovethanosike1@gmail.com"},
                new LoginDetails {Password="Sholzz1234", Email ="sholanejo@live.com" },
                new LoginDetails {Password="Sunday1234", Email ="slimake01 @gmail.com" },
                new LoginDetails {Password="Chikki1234", Email ="chiagudike@gmail.com" },
                new LoginDetails {Password="Tochukwu1234", Email ="tochukwusage4@gmail.com" },
                new LoginDetails {Password="Uriel1234", Email ="X3meuriel@gmail.com" },
                new LoginDetails {Password="Kaycee1234", Email ="egwunwokekc@gmail.com" },
                new LoginDetails {Password="Sammy1234", Email ="ehuerikenbaba@gmail.com" },
                new LoginDetails {Password="Dara1234", Email ="johnoluwadara@gmail.com" },
                new LoginDetails {Password="Obinna1234", Email ="obynomagic@gmail.com"},
                new LoginDetails {Password="Francis1234", Email ="francisogbonna24@gmail.com" },
                new LoginDetails {Password="Chinedu1234", Email ="Chinedu.mbah.g20 @gmail.com" },
                new LoginDetails {Password="Gideon1234", Email ="akunanagideon@gmail.com" },
            };
        }
    }
}
