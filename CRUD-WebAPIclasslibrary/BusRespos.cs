using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;
using DataAccessLayer;



namespace CRUD_WebAPIclasslibrary
{
    public class BusRepos
    {
        string connectionstring = "Data Source=DESKTOP-BLBGEHJ\\SQLEXPRESS;Initial Catalog=CRUD Operation;User Id=sa;Password=Anaiyaan@123;";
        SqlConnection con;


        public  BusRepos()
            {
               con = new SqlConnection(connectionstring);
            }
            public void SPlogin(Busdetails reg)
            {
                try
                {
                    var signup =( $"exec SPlogin '{reg.BusName}',{reg.DriverMobilenumber},'{reg.StartPoint}','{reg.Destination}',{reg.Fair},{reg.NoofPassenger}");
                    con.Open();
                    con.Execute(signup);
                    con.Close();
                }
                catch (SqlException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            public IEnumerable<Busdetails> SPselectall()
            {
                try
                {
                    var showall = $"exec SPselectall ";
                    con.Open();
                    var match = con.Query<Busdetails>(showall);
                    con.Close();
                    return match;
                }
                catch (SqlException ex)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }

            }
            public void SPupdate(int id,string start, string end, int far, int ticket)
            {
                try
                {
                    var update = $"exec SPupdate {id},'{start}','{end}',{far},{ticket};";
                    Console.WriteLine("Updated Successfully");
                    con.Open();
                    con.Execute(update);
                    con.Close();

                }
                catch (SqlException ex)
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
                    con.Open();
                    con.Execute(delete);
                    con.Close();
                }
                catch (SqlException ex)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            public IEnumerable<Busdetails> SPsearch(string name)
            {
                try
                {
                    var search = $"exec SPsearch '{name}'";
                    con.Open();
                    var match = con.Query<Busdetails>(search);
                    con.Close();
                    return match;

                }
                catch (SqlException ex)
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


