using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess_Layer
{

    public class clsUsers
    {

        public static bool IsThePersonAvailableToConnectWithUser(int PersonID)
        {

            bool IsValid = false;
            string query = $"select COUNT(1)  from Users Where  PersonID = @PersonID";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@PersonID", PersonID);
                    try
                    {
                        Connection.Open();
                        int count = (int)Command.ExecuteScalar();
                        IsValid = count == 0;
                    }
                    catch (Exception ex)
                    {
                        IsValid = false;
                    }
                }
            }
            return IsValid;
        }

        public static bool IsUserNameAvailable(string userName)
        {

            bool IsValid = false;
            string query = $"select COUNT(1)  from Users Where  Users.Username = @UserName";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@UserName", userName);
                    try
                    {
                        Connection.Open();
                        int count = (int)Command.ExecuteScalar();
                        IsValid = count == 0;
                    }
                    catch (Exception ex)
                    {
                        IsValid = false;
                    }
                }
            }
            return IsValid;
        }

        public static bool IsValidCredentials(string username, string hashedPassword)
        {
            bool IsValid = false;
            string query = $"select COUNT(1)  from Users Where Users.Password = @Password and Users.Username = @UserName";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {



                    Command.Parameters.AddWithValue("@UserName", username);

                    Command.Parameters.AddWithValue("@Password", hashedPassword);


                    try
                    {
                        Connection.Open();
                        int count = (int)Command.ExecuteScalar();
                        IsValid = count > 0;
                    }
                    catch (Exception ex)
                    {
                        IsValid = false;
                    }
                }
            }
            return IsValid;


        }


        public static int AddNewUsers(int PersonID, string Username, string Password, bool IsActive, byte Role, DateTime CreatedDate)
        {
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
        public static bool UpdateUsers(int UserID, int PersonID, string Username, string Password, bool IsActive, byte Role, DateTime CreatedDate)
        {
            int RowsAffected = -1;
            string query = "UPDATE Users SET PersonID = @PersonID, Username = @Username, Password = @Password, IsActive = @IsActive, Role = @Role, CreatedDate = @CreatedDate WHERE UserID = @UserID;";
            ;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@UserID", UserID);

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


        public static bool DeleteUsers(int UserID)
        {

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


        public static bool Find(int UserID, ref int PersonID, ref string Username, ref string Password, ref bool IsActive, ref byte Role, ref DateTime CreatedDate)
        {
            bool IsFound = false;
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
                        if (Reader.Read())
                        {

                            IsFound = true;
                            PersonID = (int)Reader["PersonID"];
                            Username = (string)Reader["Username"];
                            Password = (string)Reader["Password"];
                            IsActive = (bool)Reader["IsActive"];
                            Role = (byte)Reader["Role"];
                            CreatedDate = (DateTime)Reader["CreatedDate"];

                        }
                        Reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        throw new ApplicationException("An error occurred while Find a record.", ex);
                    }
                }
            }
            return IsFound;
        }

        public static bool FindByUserNameAndPassword(ref int UserID, ref int PersonID, string Username, string HashedPassword, ref bool IsActive, ref byte Role, ref DateTime CreatedDate)
        {
            bool IsFound = false;
            string query = "select * from Users Where Users.Password = @Password and Users.Username = @Username";

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@Password", HashedPassword);
                    Command.Parameters.AddWithValue("@Username", Username);
                    try
                    {
                        Connection.Open();
                        SqlDataReader Reader = Command.ExecuteReader();
                        if (Reader.Read())
                        {

                            IsFound = true;
                            UserID = (int)Reader["UserID"];
                            PersonID = (int)Reader["PersonID"];
                            IsActive = (bool)Reader["IsActive"];
                            Role = (byte)Reader["Role"];
                            CreatedDate = (DateTime)Reader["CreatedDate"];

                        }
                        Reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        IsFound = false;
                    }
                }
            }
            return IsFound;
        }


        public static bool DoesUsersExists(int UserID)
        {

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
                        if (result != null)
                        {
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
        public static bool DoesUsersExists(string username, string password)
        {

            bool IsFound = false;

            string query = " select Found=1 from Users Where Users.Password = @Password and Users.Username = @Username ";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@Username", username);
                    Command.Parameters.AddWithValue("@Password", password);
                    try
                    {
                        Connection.Open();
                        object result = Command.ExecuteScalar();
                        if (result != null)
                        {
                            IsFound = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        IsFound = false;
                    }

                }
            }
            return IsFound;
        }


        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();

            string query = " select UserID, Users.PersonID, Username, FullName = FirstName + ' ' + SecondName + ' ' + ThirdName + ' ' + LastName, IsActive,   CASE   WHEN Role = 2 THEN 'User' WHEN Role = 3 THEN 'Admin' end as Role , CreatedDate from Users join People On People.PersonID =  Users.PersonID ;";


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    try
                    {
                        Connection.Open();
                        SqlDataReader Reader = Command.ExecuteReader();
                        if (Reader.HasRows)
                        {
                            dt.Load(Reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log exception or handle accordingly
                        throw new ApplicationException("An error occurred while Deleting a record.", ex);
                    }
                }
            }
            return dt;
        }
    }
}