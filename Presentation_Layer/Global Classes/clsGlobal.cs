using Business_Layer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Presentation_Layer.Global_Classes
{
    public class clsGlobal
    {
        private static readonly byte[] EncryptionKey = Encoding.UTF8.GetBytes("YourEncryptKey12"); // 16 characters

        public static clsUsers GlobalUser { get; set; } = new clsUsers();

        public static clsCustomers GlobalCustomer { get; set; } = new clsCustomers();

        public enum enRole { Customer = 1, User=2, Admin =3};

        public static enRole Role { get; set; }



        public static string HashText(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        //public static bool IsValidUserNameCredentials(string userName, string Password)
        //{
        //    string EncryptedPassword = HashText(Password);

        //    if (!clsUsers.IsValidCredentials(userName, EncryptedPassword))
        //    {
        //        return false;
        //    }
        //    return true;


        //}

        //public static bool IsValidCustomerCredentials(string Name, string Password)
        //{
        //    string EncryptedPassword = HashText(Password);

        //    if (!clsCustomers.IsValidCredentials(Name, EncryptedPassword))
        //    {
        //        return false;
        //    }
        //    return true;
        //}


        public static void RememberMe(string name, string password, string userType)
        {
            try
            {
                // Encrypt the password
                string encryptedPassword = EncryptPassword(password);

                // Save the credentials to the registry
                string registryPath = @$"HKEY_CURRENT_USER\SOFTWARE\BankApp\{userType}";

                Registry.SetValue(registryPath, "keyUsername", name, RegistryValueKind.String);
                Registry.SetValue(registryPath, "keyPassword", encryptedPassword, RegistryValueKind.String);


            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., logging)
                Console.WriteLine("An error occurred while saving credentials: " + ex.Message);
            }
        }

        public static string EncryptPassword(string password)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = EncryptionKey;
                aesAlg.GenerateIV();
                aesAlg.Mode = CipherMode.CBC;

                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
                {
                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(password);
                        }

                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
        }

        public static string DecryptPassword(string encryptedPassword)
        {
            byte[] fullCipher = Convert.FromBase64String(encryptedPassword);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = EncryptionKey;
                byte[] iv = new byte[aesAlg.BlockSize / 8];
                Array.Copy(fullCipher, iv, iv.Length);
                aesAlg.IV = iv;

                using (ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV))
                using (MemoryStream msDecrypt = new MemoryStream(fullCipher, iv.Length, fullCipher.Length - iv.Length))
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();
                }
            }
        }

        public static void GetRememberMeCredentials(out string username, out string password, string userType)
        {
            username = "";
            password = "";
            string registryPath = @$"HKEY_CURRENT_USER\SOFTWARE\BankApp\{userType}";


            username = Registry.GetValue(registryPath, "keyUsername",null) as string;
            password = Registry.GetValue(registryPath, "keyPassword", null) as string;


            if (username  != null && !string.IsNullOrEmpty(password))
            {
                password = DecryptPassword(password);
            } else
            {
                return;
            }



        }


        public static void DeleteRememberMeCredentials(string userType)
        {
            try
            {
                string registryPath = @$"HKEY_CURRENT_USER\SOFTWARE\BankApp\{userType}";

                Registry.SetValue(registryPath, "keyUsername", "", RegistryValueKind.String);
                Registry.SetValue(registryPath, "keyPassword", "", RegistryValueKind.String);


            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., logging)
                Console.WriteLine("An error occurred while saving credentials: " + ex.Message);
            }
        }


        public static bool UserLogin(string userName, string Password, bool Rememberme)
        {

            string HashedPassword = HashText(Password);
            GlobalUser = clsUsers.Find(userName, HashedPassword);

            if (GlobalUser == null)
            {
                return false;
            };

            if (Rememberme)
            {
                RememberMe(userName, Password, "User");
            } else
            {
                DeleteRememberMeCredentials("User");
            }

            Role = (enRole)(GlobalUser.Role == 2 ? 2 : 3);
            return true;

        }
        public static bool CustomerLogin(string Name, string Password, bool Rememberme)
        {
            string HashedPassword = HashText(Password);
            GlobalCustomer = clsCustomers.Find(Name, HashedPassword);

            if (GlobalCustomer == null)
            {
                return false;
            };

            if (Rememberme)
            {
                RememberMe(Name, Password, "Customer");
            }
            else
            {
                DeleteRememberMeCredentials("Customer");
            }

            Role = enRole.Customer;
            return true;

        }



    }
}
