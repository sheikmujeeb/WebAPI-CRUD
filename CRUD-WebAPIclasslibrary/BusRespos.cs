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
            public void SPsignup(Busdetails reg)
            {
                try
                {
                    var signup = $"insert into Busdetails values ('{reg.BusID}'),'{reg.BusName}','{reg.DriverMobilenumber}','{reg.StartPoint}','{reg.Destination}','{reg.Fair}','{reg.NoofPassenger}')";
                    connection.open();
                    connection.execute(signup);
                    connection.close();
                }
                catch(SqlException ex)
                {
                    throw;
                }
                catch(Exception)
                {
                    throw;
                }
            }
            public IEnumerable<Busdetails>SPshowall()
            {

            }
        }
        
    }
}
