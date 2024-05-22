using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CRUD_WebAPIclasslibrary
{
    class BusRespos
    {
       public class Repostory
        {
            IConfiguration config;
            public Repostory(IConfiguration config)
            {
                var connection = config.GetConnectionString("Dbconnection");

            }
            public void SPsignup()
            {
                var signup = $"insert into ";
            }
        }
        
    }
}
