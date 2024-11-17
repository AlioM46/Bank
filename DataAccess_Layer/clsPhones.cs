using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer{

public class clsPhones { 



	public static int AddNewPhones(string PhoneNumber, int PersonID) {
		int PhoneID = -1;
		string query = $"INSERT INTO Phones (PhoneNumber, PersonID)VALUES (@PhoneNumber, @PersonID); SELECT SCOPE_IDENTITY();";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

		Command.Parameters.AddWithValue("@PersonID", PersonID);



				try
				{
					Connection.Open();
					object result = Command.ExecuteScalar();
						if (result != null && int.TryParse(result.ToString(), out int InsertedID))
						{
							PhoneID = InsertedID;
						}
					}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while adding a new record.", ex);
					}
				}
			}

			return PhoneID;
		}
public static bool UpdatePhones(int PhoneID, string PhoneNumber, int PersonID) {
		int RowsAffected = -1;
		string query = "UPDATE Phones SET PhoneNumber = @PhoneNumber, SET PersonID = @PersonID WHERE PhoneID = @PhoneID;"
;

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

		Command.Parameters.AddWithValue("@PersonID", PersonID);



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


	public static bool DeletePhones(int PhoneID) {

		int RowsAffected = -1;

		string query = " DELETE FROM Phones WHERE PhoneID = @PhoneID";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@PhoneID", PhoneID);
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


		public static bool Find(int PhoneID,  ref string PhoneNumber,  ref int PersonID) {
		bool IsFound= false;
		string query = "select * from Phones where PhoneID = @PhoneID";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			 Command.Parameters.AddWithValue("@PhoneID", PhoneID);
				try
				{
					Connection.Open();
					SqlDataReader Reader = Command.ExecuteReader();
					if (Reader.Read()) {

					IsFound = true;
								PhoneNumber = (string)Reader["PhoneNumber"];
			PersonID = (int)Reader["PersonID"];

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


	public static bool DoesPhonesExists(int PhoneID) {

		bool IsFound = false;

		string query = " SELECT Found = 1 FROM Phones WHERE PhoneID = @PhoneID ";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@PhoneID", PhoneID);
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


	public static DataTable GetAllPhones() {

		DataTable dt = new DataTable();

		string query = " SELECT * FROM Phones";


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