using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer{

public class clsCustomers { 



	public static int AddNewCustomers(int PersonID, string CustomerName, string Password, bool IsActive, DateTime CreatedDate) {
		int CustomerID = -1;
		string query = $"INSERT INTO Customers (PersonID, CustomerName, Password, IsActive, CreatedDate)VALUES (@PersonID, @CustomerName, @Password, @IsActive, @CreatedDate); SELECT SCOPE_IDENTITY();";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@PersonID", PersonID);

		Command.Parameters.AddWithValue("@CustomerName", CustomerName);

		Command.Parameters.AddWithValue("@Password", Password);

		Command.Parameters.AddWithValue("@IsActive", IsActive);

		Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);



				try
				{
					Connection.Open();
					object result = Command.ExecuteScalar();
						if (result != null && int.TryParse(result.ToString(), out int InsertedID))
						{
							CustomerID = InsertedID;
						}
					}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while adding a new record.", ex);
					}
				}
			}

			return CustomerID;
		}
public static bool UpdateCustomers(int CustomerID, int PersonID, string CustomerName, string Password, bool IsActive, DateTime CreatedDate) {
		int RowsAffected = -1;
		string query = "UPDATE Customers SET PersonID = @PersonID, SET CustomerName = @CustomerName, SET Password = @Password, SET IsActive = @IsActive, SET CreatedDate = @CreatedDate WHERE CustomerID = @CustomerID;"
;

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@PersonID", PersonID);

		Command.Parameters.AddWithValue("@CustomerName", CustomerName);

		Command.Parameters.AddWithValue("@Password", Password);

		Command.Parameters.AddWithValue("@IsActive", IsActive);

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


	public static bool DeleteCustomers(int CustomerID) {

		int RowsAffected = -1;

		string query = " DELETE FROM Customers WHERE CustomerID = @CustomerID";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@CustomerID", CustomerID);
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


		public static bool Find(int CustomerID,  ref int PersonID,  ref string CustomerName,  ref string Password,  ref bool IsActive,  ref DateTime CreatedDate) {
		bool IsFound= false;
		string query = "select * from Customers where CustomerID = @CustomerID";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			 Command.Parameters.AddWithValue("@CustomerID", CustomerID);
				try
				{
					Connection.Open();
					SqlDataReader Reader = Command.ExecuteReader();
					if (Reader.Read()) {

					IsFound = true;
								PersonID = (int)Reader["PersonID"];
			CustomerName = (string)Reader["CustomerName"];
			Password = (string)Reader["Password"];
			IsActive = (bool)Reader["IsActive"];
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


	public static bool DoesCustomersExists(int CustomerID) {

		bool IsFound = false;

		string query = " SELECT Found = 1 FROM Customers WHERE CustomerID = @CustomerID ";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@CustomerID", CustomerID);
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


	public static DataTable GetAllCustomers(int CustomerID) {

		DataTable dt = new DataTable();

		string query = " SELECT * FROM Customers";


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