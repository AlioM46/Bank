using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccess_Layer
{
    public class clsCurrencies
    {

        public static DataTable GetAllCurrencies()
        {

            DataTable dt = new DataTable();

            string query = " SELECT * FROM Currencies";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    try
                    {
                        Connection.Open();
                        SqlDataReader Reader = Command.ExecuteReader();
                        if (Reader.HasRows)
                        {
                            dt.Load(Reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        throw new ApplicationException("An error occurred while Deleting a record.", ex);
                    }
                }
            }
            return dt;
        }

        public static bool Find(int CurrencyID, ref string CurrencyName, ref string CurrencySymbol, ref decimal ExchangeRateToUSD)
        {

            bool IsFound = false;
            string query = "select * from Currencies Where CurrencyID = @CurrencyID ";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {

                    Command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
                    try
                    {
                        Connection.Open();
                        SqlDataReader Reader = Command.ExecuteReader();


                        if (Reader.Read())
                        {

                            CurrencyName = (string)Reader["CurrencyName"];
                            CurrencySymbol = (string)Reader["CurrencySymbol"];
                            ExchangeRateToUSD = (decimal)Reader["ExchangeRateToUSD"];
                            IsFound = true;

                        }
                        Reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        IsFound = false;
                    }
                }
            }
            return IsFound;

        }
    }
}
