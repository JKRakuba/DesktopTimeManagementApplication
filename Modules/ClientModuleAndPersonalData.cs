using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication_poe
{
    public class ClientModuleAndPersonalData
    {

        //String connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\poe update\WebApplication poe\WebApplication poe\Database\ModulesDatabase.mdf;Integrated Security=True");

        //add username and password functionality
        public string Username { get; set; }
        public string Password { get; set; }


        //functionality that was already there
        public DateTime StartDate { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public int ModuleCredits { get; set; }
        public int WeeklyClassHours { get; set; }
        public int Number_of_Weeks { get; set; }
        public int SelfstudyHours { get; set; }

        //Constructor for Class
        public ClientModuleAndPersonalData(DateTime semesterStart, string moduleCode, string moduleName, int moduleCredits, int moduleWeeklyClassHours, int totalSemesterWeeks)
        {

            StartDate = semesterStart;
            ModuleCode = moduleCode;
            ModuleName = moduleName;
            ModuleCredits = moduleCredits;
            WeeklyClassHours = moduleWeeklyClassHours;
            Number_of_Weeks = totalSemesterWeeks;
            
        }
        public ClientModuleAndPersonalData(String username, string password)
        {
            Username = username;
            Password = password;
        }
        // Register method
        public void Register()
        {
            string strSelect = $"INSERT INTO DETAILS VALUES ('{Username}' , '{Password}' )";
            SqlCommand cmdSelect = new SqlCommand(strSelect, con);

            con.Open();
            cmdSelect.ExecuteNonQuery();
            con.Close();

        }
        // all modules method
        public List<ClientModuleAndPersonalData> allModules()
        {
            string strSelect = "SELECT * FROM Modules";
            SqlCommand cmdSelect = new SqlCommand(strSelect, con);
            DataTable myTable = new DataTable();
            DataRow myRow;
            SqlDataAdapter myAdapter = new SqlDataAdapter(cmdSelect);
            List <ClientModuleAndPersonalData> eList = new List<ClientModuleAndPersonalData>();

            con.Open();
            myAdapter.Fill(myTable);

            if (myTable.Rows.Count > 0)
            {
                for (int i = 0; i < myTable.Rows.Count; i++)
                {
                    myRow = myTable.Rows[i];
                    ModuleCode = (string)myRow["ModuleCode"]; //using a column name
                    ModuleName = (string)myRow[0]; //using a column index
                    ModuleCredits = Convert.ToInt32(myRow[1]);
                    WeeklyClassHours = Convert.ToInt32(myRow[2]);
                    StartDate = (DateTime)myRow[4];
                    Number_of_Weeks = Convert.ToInt32(myRow[3]);




                    eList.Add(new ClientModuleAndPersonalData(StartDate,ModuleCode, ModuleName,ModuleCredits, WeeklyClassHours, Number_of_Weeks));
                }
            }

            return eList;
        }
        //login method
        public ClientModuleAndPersonalData Login(string username, string password)
        {
            string strSelect = $"SELECT * FROM DETAILS WHERE USERNAME = '{username}' AND PASSWORD = '{password}' ";
            SqlCommand cmdSelect = new SqlCommand(strSelect, con);

            con.Open();
            using (SqlDataReader reader = cmdSelect.ExecuteReader())
            {
                while (reader.Read())
                {
                    username = (string)reader[0];
                    password = (string)reader["PASSWORD"];

                }
            }

            con.Close();

            return new ClientModuleAndPersonalData(username, password);


   
        }
        //Delete method
        public void DeleteModules(string ModuleCode)
        {

            string StrDelete = $"DELETE FROM Modules WHERE ModuleCode ='{ModuleCode}'";
            SqlCommand cmdDelete = new SqlCommand(StrDelete, con);


            con.Open();
            cmdDelete.ExecuteNonQuery();
            con.Close();

        }
        public ClientModuleAndPersonalData()
        {
            //no arguments constructor
        }
        public double StudyHours()
        {

            double formulated = (ModuleCredits * 10) / (Number_of_Weeks - WeeklyClassHours);
            return formulated;

        }
        public double remaining_hours()
        {
            //Simply deduct these hours from the self study hours
            double remainingHours = StudyHours() - SelfstudyHours;
            return remainingHours;



        }
        public ClientModuleAndPersonalData getModules(string ModuleCode)
        {
            string strSelect = $"SELECT * FROM Modules WHERE ModuleCode = '{ModuleCode}' ";
            SqlCommand cmdSelect = new SqlCommand(strSelect, con);

            con.Open();
            using (SqlDataReader reader = cmdSelect.ExecuteReader())
            {
                while (reader.Read())
                {
                    ModuleCode = (string)reader[0];
                    ModuleName = (string)reader["Name"];
                    ModuleCredits = (int)reader[2];
                    WeeklyClassHours = Convert.ToInt32(reader[3]);
                    Number_of_Weeks = Convert.ToInt32(reader[4]);
                    StartDate = (DateTime)reader[5];
                    

                }
            }

            con.Close();
            ///addModuleData
            return new ClientModuleAndPersonalData(StartDate, ModuleCode, ModuleName, ModuleCredits, WeeklyClassHours, Number_of_Weeks);
        }
        public void AddModuleData()
        {
            SqlCommand CDAddData = new SqlCommand($"INSERT INTO Modules VALUES ('{ModuleCode}','{ModuleName}','{ModuleCredits}','{WeeklyClassHours}','{Number_of_Weeks}','{StartDate}')", con);
            con.Open();
            CDAddData.ExecuteNonQuery();
            con.Close();
        }

        public void Update(string code)
        {
            SqlCommand CDAddData = new SqlCommand($"UPDATE Modules SET ModuleName = '{ModuleName}', numberOfCredits = '{ModuleCredits}' , ClassHours_perWeek = '{WeeklyClassHours}', number_Of_Weeks = '{Number_of_Weeks}', start_date = '{StartDate}' WHERE ModuleCode = '{code}'", con);
            con.Open();
            CDAddData.ExecuteNonQuery();
            con.Close();
        }

    }
  }
