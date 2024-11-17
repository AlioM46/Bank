using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer{

public class clsGuarantees { 



	public static int AddNewGuarantees(string GuaranteeItem, int LoanID, decimal EstimatedValue, string GuaranteeDescription) {
		int GuaranteeID = -1;
		string query = $"INSERT INTO Guarantees (GuaranteeItem, LoanID, EstimatedValue, GuaranteeDescription)VALUES (@GuaranteeItem, @LoanID, @EstimatedValue, @GuaranteeDescription); SELECT SCOPE_IDENTITY();";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@GuaranteeItem", GuaranteeItem);

		Command.Parameters.AddWithValue("@LoanID", LoanID);

		Command.Parameters.AddWithValue("@EstimatedValue", EstimatedValue);

		if (GuaranteeDescription != "" && GuaranteeDescription != null) {	 

			Command.Parameters.AddWithValue("@GuaranteeDescription", GuaranteeDescription);
		}
		else {

			Command.Parameters.AddWithValue("@GuaranteeDescription", DBNull.Value);
		}



				try
				{
					Connection.Open();
					object result = Command.ExecuteScalar();
						if (result != null && int.TryParse(result.ToString(), out int InsertedID))
						{
							GuaranteeID = InsertedID;
						}
					}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while adding a new record.", ex);
					}
				}
			}

			return GuaranteeID;
		}
public static bool UpdateGuarantees(int GuaranteeID, string GuaranteeItem, int LoanID, decimal EstimatedValue, string GuaranteeDescription) {
		int RowsAffected = -1;
		string query = "UPDATE Guarantees SET GuaranteeItem = @GuaranteeItem, SET LoanID = @LoanID, SET EstimatedValue = @EstimatedValue, SET GuaranteeDescription = @GuaranteeDescription WHERE GuaranteeID = @GuaranteeID;"
;

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@GuaranteeItem", GuaranteeItem);

		Command.Parameters.AddWithValue("@LoanID", LoanID);

		Command.Parameters.AddWithValue("@EstimatedValue", EstimatedValue);

		if (GuaranteeDescription != "" && GuaranteeDescription != null) {	 

			Command.Parameters.AddWithValue("@GuaranteeDescription", GuaranteeDescription);
		}
		else {

			Command.Parameters.AddWithValue("@GuaranteeDescription", DBNull.Value);
		}



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


	public static bool DeleteGuarantees(int GuaranteeID) {

		int RowsAffected = -1;

		string query = " DELETE FROM Guarantees WHERE GuaranteeID = @GuaranteeID";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@GuaranteeID", GuaranteeID);
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


		public static bool Find(int GuaranteeID,  ref string GuaranteeItem,  ref int LoanID,  ref decimal EstimatedValue,  ref string GuaranteeDescription) {
		bool IsFound= false;
		string query = "select * from Guarantees where GuaranteeID = @GuaranteeID";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			 Command.Parameters.AddWithValue("@GuaranteeID", GuaranteeID);
				try
				{
					Connection.Open();
					SqlDataReader Reader = Command.ExecuteReader();
					if (Reader.Read()) {

					IsFound = true;
								GuaranteeItem = (string)Reader["GuaranteeItem"];
			LoanID = (int)Reader["LoanID"];
			EstimatedValue = (decimal)Reader["EstimatedValue"];
		if (Reader["GuaranteeDescription"] != DBNull.Value) { 
		GuaranteeDescription = (string)Reader["GuaranteeDescription"];
		}
		else {
		GuaranteeDescription = "";
		}

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


	public static bool DoesGuaranteesExists(int GuaranteeID) {

		bool IsFound = false;

		string query = " SELECT Found = 1 FROM Guarantees WHERE GuaranteeID = @GuaranteeID ";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@GuaranteeID", GuaranteeID);
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


	public static DataTable GetAllGuarantees() {

		DataTable dt = new DataTable();

		string query = " SELECT * FROM Guarantees";


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