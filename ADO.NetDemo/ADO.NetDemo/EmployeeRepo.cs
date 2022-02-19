using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetDemo
{
    public class EmployeeRepo
    {
        public static string Connectionstring = "Data Source=DESKTOP-711IFBF/SQLEXPRESS;Initial Catalog=payroll_service;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static void GetAllEmployee()
        {
           SqlConnection sqlConnection = new SqlConnection(Connectionstring);
        }
    }
}
