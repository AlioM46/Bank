using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer{

public class clsUsers { 



	public static int AddNewUsers(int PersonID, string Username, string Password, bool IsActive, bool Role, DateTime CreatedDate) {
		int UserID = -1;
		string query = $"INSERT INTO Users (PersonID, Username, Password, IsActive, Role, CreatedDate)VALUES (@PersonID, @Username, @Password, @IsActive, @Role, @CreatedDate); SELECT SCOPE_IDENTITY();";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@PersonID", PersonID);

		Command.Parameters.AddWithValue("@Username", Username);

		Command.Parameters.AddWithValue("@Password", Password);

		Command.Parameters.AddWithValue("@IsActive", IsActive);

		Command.Parameters.AddWithValue("@Role", Role);

		Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);



				try
				{
					Connection.Open();
					object result = Command.ExecuteScalar();
						if (result != null && int.TryParse(result.ToString(), out int InsertedID))
						{
							UserID = InsertedID;
						}
					}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while adding a new record.", ex);
					}
				}
			}

			return UserID;
		}
public static bool UpdateUsers(int UserID, int PersonID, string Username, string Password, bool IsActive, bool Role, DateTime CreatedDate) {
		int RowsAffected = -1;
		string query = "UPDATE Users SET PersonID = @PersonID, SET Username = @Username, SET Password = @Password, SET IsActive = @IsActive, SET Role = @Role, SET CreatedDate = @CreatedDate WHERE UserID = @UserID;"
;

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@PersonID", PersonID);

		Command.Parameters.AddWithValue("@Username", Username);

		Command.Parameters.AddWithValue("@Password", Password);

		Command.Parameters.AddWithValue("@IsActive", IsActive);

		Command.Parameters.AddWithValue("@Role", Role);

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


	public static bool DeleteUsers(int UserID) {

		int RowsAffected = -1;

		string query = " DELETE FROM Users WHERE UserID = @UserID";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@UserID", UserID);
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


		public static bool Find(int UserID,  ref int PersonID,  ref string Username,  ref string Password,  ref bool IsActive,  ref bool Role,  ref DateTime CreatedDate) {
		bool IsFound= false;
		string query = "select * from Users where UserID = @UserID";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			 Command.Parameters.AddWithValue("@UserID", UserID);
				try
				{
					Connection.Open();
					SqlDataReader Reader = Command.ExecuteReader();
					if (Reader.Read()) {

					IsFound = true;
								PersonID = (int)Reader["PersonID"];
			Username = (string)Reader["Username"];
			Password = (string)Reader["Password"];
			IsActive = (bool)Reader["IsActive"];
			Role = (bool)Reader["Role"];
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


	public static bool DoesUsersExists(int UserID) {

		bool IsFound = false;

		string query = " SELECT Found = 1 FROM Users WHERE UserID = @UserID ";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@UserID", UserID);
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


	public static DataTable GetAllUsers(int UserID) {

		DataTable dt = new DataTable();

		string query = " SELECT * FROM Users";


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