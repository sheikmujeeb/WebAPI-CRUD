using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;



namespace CRUD_WebAPIclasslibrary
{
    class BusRepos
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
                try
                {
                    var showall = $"select BusID,BusName,DriverMobilennumber,StartPoint,Destination,Fair,NoofPassenger from Busdetails ";
                    connection.open();
                    var match = connection.Query<Busdetails>(showall);
                    connection.close();
                    return match;
                }
                catch(Sqlexception ex)
                {
                    throw;
                }
                catch(Exception)
                {
                    throw;
                }

            }
            public void SPupdate(string start ,string end ,int far ,int ticket)
            {
                try
                {
                    var update = $"exec SPupdate '{start}''{end}''{far}''{ticket}';";
                    Console.WriteLine("Updated Successfully");
                    connection.open();
                    connection.execute(update);
                    connection.close();

                }
                catch (Sqlexception ex)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            public void SPremove(string busname)
            {
                try
                {
                    var delete = $"exec SPremove '{busname}'";
                    Console.WriteLine("Deleted Sucessfully");
                    connection.open();
                    connection.execute(delete);
                    connection.close();
                }
                catch (Sqlexception ex)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            public IEnumerable<Busdetails>SPsearch(string name)
            {
                try
                {
                    var search = $"exec SPsearch '{name}'";
                    connection.open();
                    var match = connection.Query<Busdetails>(search);
                    connection.close();
                    return match;

                }
                catch (Sqlexception ex)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        
    }
}
