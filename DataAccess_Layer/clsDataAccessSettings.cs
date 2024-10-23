using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer
{

    public class clsDataAccessSettings
    {



        public static string ConnectionString { get; set; } = "Server=.;Database=Bank;User Id=sa; Password=sa123456";
    }
}