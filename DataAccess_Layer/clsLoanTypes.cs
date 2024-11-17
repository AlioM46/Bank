using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer{

public class clsLoanTypes { 



	public static int AddNewLoanTypes(decimal MinimumBalance, string LoanType, int MaxMonthsDuration, decimal MinAmount, decimal MaxAmount) {
		int LoanTypeID = -1;
		string query = $"INSERT INTO LoanTypes (MinimumBalance, LoanType, MaxMonthsDuration, MinAmount, MaxAmount)VALUES (@MinimumBalance, @LoanType, @MaxMonthsDuration, @MinAmount, @MaxAmount); SELECT SCOPE_IDENTITY();";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@MinimumBalance", MinimumBalance);

		Command.Parameters.AddWithValue("@LoanType", LoanType);

		Command.Parameters.AddWithValue("@MaxMonthsDuration", MaxMonthsDuration);

		Command.Parameters.AddWithValue("@MinAmount", MinAmount);

		Command.Parameters.AddWithValue("@MaxAmount", MaxAmount);



				try
				{
					Connection.Open();
					object result = Command.ExecuteScalar();
						if (result != null && int.TryParse(result.ToString(), out int InsertedID))
						{
							LoanTypeID = InsertedID;
						}
					}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while adding a new record.", ex);
					}
				}
			}

			return LoanTypeID;
		}
public static bool UpdateLoanTypes(int LoanTypeID, decimal MinimumBalance, string LoanType, int MaxMonthsDuration, decimal MinAmount, decimal MaxAmount) {
		int RowsAffected = -1;
		string query = "UPDATE LoanTypes SET MinimumBalance = @MinimumBalance, SET LoanType = @LoanType, SET MaxMonthsDuration = @MaxMonthsDuration, SET MinAmount = @MinAmount, SET MaxAmount = @MaxAmount WHERE LoanTypeID = @LoanTypeID;"
;

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@MinimumBalance", MinimumBalance);

		Command.Parameters.AddWithValue("@LoanType", LoanType);

		Command.Parameters.AddWithValue("@MaxMonthsDuration", MaxMonthsDuration);

		Command.Parameters.AddWithValue("@MinAmount", MinAmount);

		Command.Parameters.AddWithValue("@MaxAmount", MaxAmount);



				try
				{
					Connection.Open();
					RowsAffected = Command.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while Updating a record.", ex);
					}
				}
			}
		 return (RowsAffected > 0);
	}


	public static bool DeleteLoanTypes(int LoanTypeID) {

		int RowsAffected = -1;

		string query = " DELETE FROM LoanTypes WHERE LoanTypeID = @LoanTypeID";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@LoanTypeID", LoanTypeID);
				try
				{
					Connection.Open();
					RowsAffected = Command.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while Deleting a record.", ex);
					}
				}
			}
		 return (RowsAffected > 0);
	}


		public static bool Find(int LoanTypeID,  ref decimal MinimumBalance,  ref string LoanType,  ref int MaxMonthsDuration,  ref decimal MinAmount,  ref decimal MaxAmount) {
		bool IsFound= false;
		string query = "select * from LoanTypes where LoanTypeID = @LoanTypeID";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			 Command.Parameters.AddWithValue("@LoanTypeID", LoanTypeID);
				try
				{
					Connection.Open();
					SqlDataReader Reader = Command.ExecuteReader();
					if (Reader.Read()) {

					IsFound = true;
								MinimumBalance = (decimal)Reader["MinimumBalance"];
			LoanType = (string)Reader["LoanType"];
			MaxMonthsDuration = (int)Reader["MaxMonthsDuration"];
			MinAmount = (decimal)Reader["MinAmount"];
			MaxAmount = (decimal)Reader["MaxAmount"];

					}
				Reader.Close();					}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while Find a record.", ex);
					}
				}
			}
		 return IsFound;
	}


	public static bool DoesLoanTypesExists(int LoanTypeID) {

		bool IsFound = false;

		string query = " SELECT Found = 1 FROM LoanTypes WHERE LoanTypeID = @LoanTypeID ";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@LoanTypeID", LoanTypeID);
				try
				{
					Connection.Open();
					object result = Command.ExecuteScalar();
					if (result != null) {
				IsFound = true;
					}
					}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while Deleting a record.", ex);
					}
				}
			}
		 return IsFound;
	}


	public static DataTable GetAllLoanTypes() {

		DataTable dt = new DataTable();

		string query = " SELECT * FROM LoanTypes";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
				try
				{
					Connection.Open();
					SqlDataReader Reader = Command.ExecuteReader();
					if (Reader.HasRows) {
					dt.Load(Reader);					}
				}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while Deleting a record.", ex);
					}
				}
			}
		 return dt;
	}		}
	}