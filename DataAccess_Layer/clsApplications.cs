using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer{

public class clsApplications { 



	public static int AddNewApplications(int CustomerID, int ApplicationTypeID, DateTime ApplicationDate, DateTime LastUpdateDate, int ApplicationStatus, int AccountID, string ApplicationDescription) {
		int ApplicationID = -1;
		string query = $"INSERT INTO Applications (CustomerID, ApplicationTypeID, ApplicationDate, LastUpdateDate, ApplicationStatus, AccountID, ApplicationDescription)VALUES (@CustomerID, @ApplicationTypeID, @ApplicationDate, @LastUpdateDate, @ApplicationStatus, @AccountID, @ApplicationDescription); SELECT SCOPE_IDENTITY();";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@CustomerID", CustomerID);

		Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

		Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);

		Command.Parameters.AddWithValue("@LastUpdateDate", LastUpdateDate);

		Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);

		Command.Parameters.AddWithValue("@AccountID", AccountID);

		if (ApplicationDescription != "" && ApplicationDescription != null) {	 

			Command.Parameters.AddWithValue("@ApplicationDescription", ApplicationDescription);
		}
		else {

			Command.Parameters.AddWithValue("@ApplicationDescription", DBNull.Value);
		}



				try
				{
					Connection.Open();
					object result = Command.ExecuteScalar();
						if (result != null && int.TryParse(result.ToString(), out int InsertedID))
						{
							ApplicationID = InsertedID;
						}
					}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while adding a new record.", ex);
					}
				}
			}

			return ApplicationID;
		}
public static bool UpdateApplications(int ApplicationID, int CustomerID, int ApplicationTypeID, DateTime ApplicationDate, DateTime LastUpdateDate, int ApplicationStatus, int AccountID, string ApplicationDescription) {
		int RowsAffected = -1;
		string query = "UPDATE Applications SET CustomerID = @CustomerID, SET ApplicationTypeID = @ApplicationTypeID, SET ApplicationDate = @ApplicationDate, SET LastUpdateDate = @LastUpdateDate, SET ApplicationStatus = @ApplicationStatus, SET AccountID = @AccountID, SET ApplicationDescription = @ApplicationDescription WHERE ApplicationID = @ApplicationID;"
;

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@CustomerID", CustomerID);

		Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

		Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);

		Command.Parameters.AddWithValue("@LastUpdateDate", LastUpdateDate);

		Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);

		Command.Parameters.AddWithValue("@AccountID", AccountID);

		if (ApplicationDescription != "" && ApplicationDescription != null) {	 

			Command.Parameters.AddWithValue("@ApplicationDescription", ApplicationDescription);
		}
		else {

			Command.Parameters.AddWithValue("@ApplicationDescription", DBNull.Value);
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


	public static bool DeleteApplications(int ApplicationID) {

		int RowsAffected = -1;

		string query = " DELETE FROM Applications WHERE ApplicationID = @ApplicationID";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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


		public static bool Find(int ApplicationID,  ref int CustomerID,  ref int ApplicationTypeID,  ref DateTime ApplicationDate,  ref DateTime LastUpdateDate,  ref int ApplicationStatus,  ref int AccountID,  ref string ApplicationDescription) {
		bool IsFound= false;
		string query = "select * from Applications where ApplicationID = @ApplicationID";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			 Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
				try
				{
					Connection.Open();
					SqlDataReader Reader = Command.ExecuteReader();
					if (Reader.Read()) {

					IsFound = true;
								CustomerID = (int)Reader["CustomerID"];
			ApplicationTypeID = (int)Reader["ApplicationTypeID"];
			ApplicationDate = (DateTime)Reader["ApplicationDate"];
			LastUpdateDate = (DateTime)Reader["LastUpdateDate"];
			ApplicationStatus = (int)Reader["ApplicationStatus"];
			AccountID = (int)Reader["AccountID"];
		if (Reader["ApplicationDescription"] != DBNull.Value) { 
		ApplicationDescription = (string)Reader[ApplicationDescription];
		}
		else {
		ApplicationDescription = "";
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


	public static bool DoesApplicationsExists(int ApplicationID) {

		bool IsFound = false;

		string query = " SELECT Found = 1 FROM Applications WHERE ApplicationID = @ApplicationID ";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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


	public static DataTable GetAllApplications(int ApplicationID) {

		DataTable dt = new DataTable();

		string query = " SELECT * FROM Applications";


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