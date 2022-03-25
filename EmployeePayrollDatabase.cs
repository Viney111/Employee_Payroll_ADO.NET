using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Employee_Payroll_ADO.NET
{
    internal class EmployeePayrollDatabase
    {
        public static void Create_Database()
        {
            try
            {
                string connectionString = @"Data Source=LAPTOP-IUMGL5A5; Initial Catalog =master; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Create database payroll_Employee;", con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee_Payroll Database created successfully!");
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
