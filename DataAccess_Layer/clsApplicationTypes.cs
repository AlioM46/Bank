using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer{

public class clsApplicationTypes { 



	public static int AddNewApplicationTypes(string ApplicationType, decimal ApplicationFees, bool RequiresDocuments) {
		int ApplicationTypeID = -1;
		string query = $"INSERT INTO ApplicationTypes (ApplicationType, ApplicationFees, RequiresDocuments)VALUES (@ApplicationType, @ApplicationFees, @RequiresDocuments); SELECT SCOPE_IDENTITY();";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@ApplicationType", ApplicationType);

		Command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

		Command.Parameters.AddWithValue("@RequiresDocuments", RequiresDocuments);



				try
				{
					Connection.Open();
					object result = Command.ExecuteScalar();
						if (result != null && int.TryParse(result.ToString(), out int InsertedID))
						{
							ApplicationTypeID = InsertedID;
						}
					}
					catch (Exception ex)
					{
						// Log exception or handle accordingly
						throw new ApplicationException("An error occurred while adding a new record.", ex);
					}
				}
			}

			return ApplicationTypeID;
		}
public static bool UpdateApplicationTypes(int ApplicationTypeID, string ApplicationType, decimal ApplicationFees, bool RequiresDocuments) {
		int RowsAffected = -1;
		string query = "UPDATE ApplicationTypes SET ApplicationType = @ApplicationType, SET ApplicationFees = @ApplicationFees, SET RequiresDocuments = @RequiresDocuments WHERE ApplicationTypeID = @ApplicationTypeID;"
;

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{


		Command.Parameters.AddWithValue("@ApplicationType", ApplicationType);

		Command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

		Command.Parameters.AddWithValue("@RequiresDocuments", RequiresDocuments);



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


	public static bool DeleteApplicationTypes(int ApplicationTypeID) {

		int RowsAffected = -1;

		string query = " DELETE FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
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


		public static bool Find(int ApplicationTypeID,  ref string ApplicationType,  ref decimal ApplicationFees,  ref bool RequiresDocuments) {
		bool IsFound= false;
		string query = "select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";

		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			 Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
				try
				{
					Connection.Open();
					SqlDataReader Reader = Command.ExecuteReader();
					if (Reader.Read()) {

					IsFound = true;
								ApplicationType = (string)Reader["ApplicationType"];
			ApplicationFees = (decimal)Reader["ApplicationFees"];
			RequiresDocuments = (bool)Reader["RequiresDocuments"];

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


	public static bool DoesApplicationTypesExists(int ApplicationTypeID) {

		bool IsFound = false;

		string query = " SELECT Found = 1 FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID ";


		using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
		{
			using (SqlCommand Command = new SqlCommand(query, Connection))
			{
			Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
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


	public static DataTable GetAllApplicationTypes(int ApplicationTypeID) {

		DataTable dt = new DataTable();

		string query = " SELECT * FROM ApplicationTypes";


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