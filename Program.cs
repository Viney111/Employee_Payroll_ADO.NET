using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll_ADO.NET
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Database");
            EmployeePayrollDatabase employeePayrollDatabase = new EmployeePayrollDatabase();
            employeePayrollDatabase.GetAllEmployeeRecords();
            Employee employee = new Employee
            {
                employeeName = "RamSingh",
                gender = "M",
                phoneNo = 9991661664,
                employeeAddress = "VPO Kotputli, Rajasthan",
                startDate = DateTime.Now,
                basicPay = 1200000,
                deductions = 200000,
                incomeTax = 100000,
                companySelect = 1,
                employeeSelect = 5,
                departmentSelect = 1,
            };
            //employeePayrollDatabase.AddEmployeeToDatabase(employee);
        }
    }
}