using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer{

public class clsPayments { 



	public static int AddNewPayments(int ApplicationID, int TransactionID, decimal Amount, string Description, DateTime CreatedDate) {
		int PaymentID = -1;
		string query = $"INSERT INTO Payments (ApplicationID, TransactionID, Amount, Description, CreatedDate)VALUES (@ApplicationID, @TransactionID, @Amount, @Description, @CreatedDate); SELECT SCOPE_IDENTITY();";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

		if (TransactionID != -1 && TransactionID != null) {	 

			Command.Parameters.AddWithValue("@TransactionID", TransactionID);
		}
		else {

			Command.Parameters.AddWithValue("@TransactionID", DBNull.Value);
		}

		Command.Parameters.AddWithValue("@Amount", Amount);

		if (Description != "" && Description != null) {	 

			Command.Parameters.AddWithValue("@Description", Description);
		}
		else {

			Command.Parameters.AddWithValue("@Description", DBNull.Value);
		}

		Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);



				try
				{
					Connection.Open();
					object result = Command.ExecuteScalar();
						if (result != null && int.TryParse(result.ToString(), out int InsertedID))
						{
							PaymentID = InsertedID;
						}
					}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while adding a new record.", ex);
					}
				}
			}

			return PaymentID;
		}
public static bool UpdatePayments(int PaymentID, int ApplicationID, int TransactionID, decimal Amount, string Description, DateTime CreatedDate) {
		int RowsAffected = -1;
		string query = "UPDATE Payments SET ApplicationID = @ApplicationID, SET TransactionID = @TransactionID, SET Amount = @Amount, SET Description = @Description, SET CreatedDate = @CreatedDate WHERE PaymentID = @PaymentID;"
;

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

		if (TransactionID != -1 && TransactionID != null) {	 

			Command.Parameters.AddWithValue("@TransactionID", TransactionID);
		}
		else {

			Command.Parameters.AddWithValue("@TransactionID", DBNull.Value);
		}

		Command.Parameters.AddWithValue("@Amount", Amount);

		if (Description != "" && Description != null) {	 

			Command.Parameters.AddWithValue("@Description", Description);
		}
		else {

			Command.Parameters.AddWithValue("@Description", DBNull.Value);
		}

		Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);



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


	public static bool DeletePayments(int PaymentID) {

		int RowsAffected = -1;

		string query = " DELETE FROM Payments WHERE PaymentID = @PaymentID";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@PaymentID", PaymentID);
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


		public static bool Find(int PaymentID,  ref int ApplicationID,  ref int TransactionID,  ref decimal Amount,  ref string Description,  ref DateTime CreatedDate) {
		bool IsFound= false;
		string query = "select * from Payments where PaymentID = @PaymentID";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			 Command.Parameters.AddWithValue("@PaymentID", PaymentID);
				try
				{
					Connection.Open();
					SqlDataReader Reader = Command.ExecuteReader();
					if (Reader.Read()) {

					IsFound = true;
								ApplicationID = (int)Reader["ApplicationID"];
		if (Reader["TransactionID"] != DBNull.Value) { 
		TransactionID = (int)Reader[TransactionID];
		}
		else {
		TransactionID = -1;
		}
			Amount = (decimal)Reader["Amount"];
		if (Reader["Description"] != DBNull.Value) { 
		Description = (string)Reader[Description];
		}
		else {
		Description = "";
		}
			CreatedDate = (DateTime)Reader["CreatedDate"];

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


	public static bool DoesPaymentsExists(int PaymentID) {

		bool IsFound = false;

		string query = " SELECT Found = 1 FROM Payments WHERE PaymentID = @PaymentID ";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@PaymentID", PaymentID);
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


	public static DataTable GetAllPayments(int PaymentID) {

		DataTable dt = new DataTable();

		string query = " SELECT * FROM Payments";


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