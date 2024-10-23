using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer{

public class clsLoans { 



	public static int AddNewLoans(decimal Amount, DateTime StartDate, DateTime EndDate, int LoanTypeID, int Status, decimal AllPayments, DateTime LastUpdateDate, int ApplicationID) {
		int LoanID = -1;
		string query = $"INSERT INTO Loans (Amount, StartDate, EndDate, LoanTypeID, Status, AllPayments, LastUpdateDate, ApplicationID)VALUES (@Amount, @StartDate, @EndDate, @LoanTypeID, @Status, @AllPayments, @LastUpdateDate, @ApplicationID); SELECT SCOPE_IDENTITY();";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@Amount", Amount);

		Command.Parameters.AddWithValue("@StartDate", StartDate);

		Command.Parameters.AddWithValue("@EndDate", EndDate);

		Command.Parameters.AddWithValue("@LoanTypeID", LoanTypeID);

		Command.Parameters.AddWithValue("@Status", Status);

		Command.Parameters.AddWithValue("@AllPayments", AllPayments);

		Command.Parameters.AddWithValue("@LastUpdateDate", LastUpdateDate);

		Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);



				try
				{
					Connection.Open();
					object result = Command.ExecuteScalar();
						if (result != null && int.TryParse(result.ToString(), out int InsertedID))
						{
							LoanID = InsertedID;
						}
					}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while adding a new record.", ex);
					}
				}
			}

			return LoanID;
		}
public static bool UpdateLoans(int LoanID, decimal Amount, DateTime StartDate, DateTime EndDate, int LoanTypeID, int Status, decimal AllPayments, DateTime LastUpdateDate, int ApplicationID) {
		int RowsAffected = -1;
		string query = "UPDATE Loans SET Amount = @Amount, SET StartDate = @StartDate, SET EndDate = @EndDate, SET LoanTypeID = @LoanTypeID, SET Status = @Status, SET AllPayments = @AllPayments, SET LastUpdateDate = @LastUpdateDate, SET ApplicationID = @ApplicationID WHERE LoanID = @LoanID;"
;

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@Amount", Amount);

		Command.Parameters.AddWithValue("@StartDate", StartDate);

		Command.Parameters.AddWithValue("@EndDate", EndDate);

		Command.Parameters.AddWithValue("@LoanTypeID", LoanTypeID);

		Command.Parameters.AddWithValue("@Status", Status);

		Command.Parameters.AddWithValue("@AllPayments", AllPayments);

		Command.Parameters.AddWithValue("@LastUpdateDate", LastUpdateDate);

		Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);



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


	public static bool DeleteLoans(int LoanID) {

		int RowsAffected = -1;

		string query = " DELETE FROM Loans WHERE LoanID = @LoanID";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@LoanID", LoanID);
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


		public static bool Find(int LoanID,  ref decimal Amount,  ref DateTime StartDate,  ref DateTime EndDate,  ref int LoanTypeID,  ref int Status,  ref decimal AllPayments,  ref DateTime LastUpdateDate,  ref int ApplicationID) {
		bool IsFound= false;
		string query = "select * from Loans where LoanID = @LoanID";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			 Command.Parameters.AddWithValue("@LoanID", LoanID);
				try
				{
					Connection.Open();
					SqlDataReader Reader = Command.ExecuteReader();
					if (Reader.Read()) {

					IsFound = true;
								Amount = (decimal)Reader["Amount"];
			StartDate = (DateTime)Reader["StartDate"];
			EndDate = (DateTime)Reader["EndDate"];
			LoanTypeID = (int)Reader["LoanTypeID"];
			Status = (int)Reader["Status"];
			AllPayments = (decimal)Reader["AllPayments"];
			LastUpdateDate = (DateTime)Reader["LastUpdateDate"];
			ApplicationID = (int)Reader["ApplicationID"];

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


	public static bool DoesLoansExists(int LoanID) {

		bool IsFound = false;

		string query = " SELECT Found = 1 FROM Loans WHERE LoanID = @LoanID ";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@LoanID", LoanID);
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


	public static DataTable GetAllLoans(int LoanID) {

		DataTable dt = new DataTable();

		string query = " SELECT * FROM Loans";


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