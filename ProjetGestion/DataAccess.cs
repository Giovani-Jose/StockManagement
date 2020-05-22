using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace ProjetGestion
{
    public class DataAccess
    {
        private static SqlDataReader DataReader;
        private static string storedProcedure_name;
        private static VerifyInformation_And_ManageStuff Manage;
        private static  int increment = 0;
        private static MenuForm Menu;

        public void VerifyCredentialsInformation(string Login_name, string Password)
        {
            string LoginOutput = "";
            string PasswordOutput = "";

            storedProcedure_name = @"dbo.[LoginCredentials_GetLoginCredentials]";

            ConnectionToSqlSever(ref Login_name, ref Password, ref LoginOutput, ref PasswordOutput);

        }

        public static void ConnectionToSqlSever(ref string Login_name, ref string Password, ref string LoginOutput, ref string PasswordOutput)
        {

            using SqlConnection connectionToServer = new SqlConnection(Helper.CnnVal("ManagementAppDB"));
            {
                SqlCommand command = new SqlCommand(storedProcedure_name, connectionToServer);
                command.Parameters.Add("@LoginName", SqlDbType.VarChar).Value = Login_name;
                command.Parameters.Add("@LoginPassword", SqlDbType.VarChar).Value = Password;
                connectionToServer.Open();
                command.CommandType = CommandType.StoredProcedure;
                DataReader = command.ExecuteReader();

                while (DataReader.Read())
                {
                    LoginOutput += DataReader.GetValue(1);
                    PasswordOutput += DataReader.GetValue(2);
                }

                if (Login_name != LoginOutput || Password != PasswordOutput)
                {
                    MessageBox.Show($"Login failed for user {Login_name}", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    var LoginForm = Application.OpenForms["LoginForm"];
                    LoginForm.Hide();
                    Menu = new MenuForm();
                    Menu.StartPosition = FormStartPosition.CenterScreen;
                    Menu.Show();

                    
                }


            }


        }

        public void AddClientToBdd(ref string FirstName, ref string LastName, ref string Country, ref string city, ref string CellNumber, ref string Address, ref string Email)

        {
            storedProcedure_name = @"dbo.[AddClient]";

            using SqlConnection connection = new SqlConnection(Helper.CnnVal("ManagementAppDB"));
            {
                SqlCommand command = new SqlCommand(storedProcedure_name, connection);

                command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
                command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
                command.Parameters.Add("@Country", SqlDbType.VarChar).Value = Country;
                command.Parameters.Add("@City", SqlDbType.VarChar).Value = city;
                command.Parameters.Add("@CellNumber", SqlDbType.VarChar).Value = CellNumber;
                command.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;


                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                increment += 1;

                if (increment >= 1)
                {
                    Manage = new VerifyInformation_And_ManageStuff();
                    Manage.GetCurrentMenuFormInstance(ref Menu);
                }
            }
        }




        public List<string> GetClientInformation(List<string> GetData)

        {
            storedProcedure_name = @"dbo.[GetClientInformation]";
            string FirstName_output = "";
            string LastName_output = "";
            string Country_output = "";
            string City_output = "";
            string CellNumber_output = "";
            string adresse_output = "";
            string Email_output = "";
            string Id_output = "";
            int ConvertId = 0;




            using SqlConnection connection = new SqlConnection(Helper.CnnVal("ManagementAppDB"));
            {
                SqlCommand command = new SqlCommand(storedProcedure_name, connection);
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                DataReader = command.ExecuteReader();

                while (DataReader.Read())

                {
                    Id_output = DataReader.GetValue(0).ToString();
                    ConvertId += Int32.Parse(Id_output);
                    FirstName_output = DataReader.GetValue(1).ToString();
                    LastName_output = DataReader.GetValue(2).ToString();
                    Country_output = DataReader.GetValue(3).ToString();
                    City_output = DataReader.GetValue(4).ToString();
                    CellNumber_output = DataReader.GetValue(5).ToString();
                    adresse_output = DataReader.GetValue(6).ToString();
                    Email_output = DataReader.GetValue(7).ToString();
                }

                GetData.Add(ConvertId.ToString());
                GetData.Add(FirstName_output);
                GetData.Add(LastName_output);
                GetData.Add(Country_output);
                GetData.Add(City_output);
                GetData.Add(CellNumber_output);
                GetData.Add(adresse_output);
                GetData.Add(Email_output);

                Console.WriteLine(FirstName_output);
               

            }
            return GetData;
        }





        public int CountNumberOfRow()

        {
            storedProcedure_name = @"dbo.[GetNumberOfClientRow]";
            int count = 0;


            using SqlConnection connection = new SqlConnection(Helper.CnnVal("ManagementAppDB"));
            {

                SqlCommand command = new SqlCommand(storedProcedure_name, connection);
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                count = (int)command.ExecuteScalar();
                connection.Close();
            }



            return count;

        }

    }
}

