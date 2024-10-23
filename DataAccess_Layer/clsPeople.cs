using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer{

public class clsPeople { 



	public static int AddNewPeople(string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, string Email, string Address) {
		int PersonID = -1;
		string query = $"INSERT INTO People (FirstName, SecondName, ThirdName, LastName, DateOfBirth, Email, Address)VALUES (@FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Email, @Address); SELECT SCOPE_IDENTITY();";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@FirstName", FirstName);

		if (SecondName != "" && SecondName != null) {	 

			Command.Parameters.AddWithValue("@SecondName", SecondName);
		}
		else {

			Command.Parameters.AddWithValue("@SecondName", DBNull.Value);
		}

		if (ThirdName != "" && ThirdName != null) {	 

			Command.Parameters.AddWithValue("@ThirdName", ThirdName);
		}
		else {

			Command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
		}

		Command.Parameters.AddWithValue("@LastName", LastName);

		Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

		Command.Parameters.AddWithValue("@Email", Email);

		Command.Parameters.AddWithValue("@Address", Address);



				try
				{
					Connection.Open();
					object result = Command.ExecuteScalar();
						if (result != null && int.TryParse(result.ToString(), out int InsertedID))
						{
							PersonID = InsertedID;
						}
					}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while adding a new record.", ex);
					}
				}
			}

			return PersonID;
		}
public static bool UpdatePeople(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, string Email, string Address) {
		int RowsAffected = -1;
		string query = "UPDATE People SET FirstName = @FirstName, SET SecondName = @SecondName, SET ThirdName = @ThirdName, SET LastName = @LastName, SET DateOfBirth = @DateOfBirth, SET Email = @Email, SET Address = @Address WHERE PersonID = @PersonID;"
;

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@FirstName", FirstName);

		if (SecondName != "" && SecondName != null) {	 

			Command.Parameters.AddWithValue("@SecondName", SecondName);
		}
		else {

			Command.Parameters.AddWithValue("@SecondName", DBNull.Value);
		}

		if (ThirdName != "" && ThirdName != null) {	 

			Command.Parameters.AddWithValue("@ThirdName", ThirdName);
		}
		else {

			Command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
		}

		Command.Parameters.AddWithValue("@LastName", LastName);

		Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

		Command.Parameters.AddWithValue("@Email", Email);

		Command.Parameters.AddWithValue("@Address", Address);



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


	public static bool DeletePeople(int PersonID) {

		int RowsAffected = -1;

		string query = " DELETE FROM People WHERE PersonID = @PersonID";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@PersonID", PersonID);
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


		public static bool Find(int PersonID,  ref string FirstName,  ref string SecondName,  ref string ThirdName,  ref string LastName,  ref DateTime DateOfBirth,  ref string Email,  ref string Address) {
		bool IsFound= false;
		string query = "select * from People where PersonID = @PersonID";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			 Command.Parameters.AddWithValue("@PersonID", PersonID);
				try
				{
					Connection.Open();
					SqlDataReader Reader = Command.ExecuteReader();
					if (Reader.Read()) {

					IsFound = true;
								FirstName = (string)Reader["FirstName"];
		if (Reader["SecondName"] != DBNull.Value) { 
		SecondName = (string)Reader[SecondName];
		}
		else {
		SecondName = "";
		}
		if (Reader["ThirdName"] != DBNull.Value) { 
		ThirdName = (string)Reader[ThirdName];
		}
		else {
		ThirdName = "";
		}
			LastName = (string)Reader["LastName"];
			DateOfBirth = (DateTime)Reader["DateOfBirth"];
			Email = (string)Reader["Email"];
			Address = (string)Reader["Address"];

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


	public static bool DoesPeopleExists(int PersonID) {

		bool IsFound = false;

		string query = " SELECT Found = 1 FROM People WHERE PersonID = @PersonID ";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@PersonID", PersonID);
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


	public static DataTable GetAllPeople(int PersonID) {

		DataTable dt = new DataTable();

		string query = " SELECT * FROM People";


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