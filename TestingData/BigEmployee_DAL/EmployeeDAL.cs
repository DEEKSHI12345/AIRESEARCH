using BigEmployee_PL.BigEmployee_DAL;
using BigEmployee_PL.BigEmployee_Entities;
using Microsoft.Data.SqlClient;

namespace BigEmployee_DAL
{
    public class EmployeeDAL : IEmployee
    {
        public List<EmployeeDataRecord> GetEmployees(int size,int number)

        {
            
            string connectionString = "Data Source=10.20.12.197;Initial Catalog=ReportingTool;User ID=reportuser;Password=reportpassword;TrustServerCertificate=true;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //string query = "SELECT * FROM EmployeeDataRecord";
                string query = $"EXEC USP_EmployeeDataRecord_GetReports {size},{number}";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<EmployeeDataRecord> employees = new List<EmployeeDataRecord>();
                        while (reader.Read())
                        {
                            EmployeeDataRecord employee = new EmployeeDataRecord
                            {
                                EmplId = Convert.ToInt32(reader["EmplId"]),
                                Education = reader["Education"].ToString(),
                                JoiningYear = Convert.ToInt32(reader["JoiningYear"]),
                                City = reader["City"].ToString(),
                                PaymentTier = Convert.ToInt32(reader["PaymentTier"]),
                                Age = Convert.ToInt32(reader["Age"]),
                                Gender = reader["Gender"].ToString(),
                                EverBenched = reader["EverBenched"].ToString(),
                                ExperienceInCurrentDomain = reader.IsDBNull(reader.GetOrdinal("ExperienceInCurrentDomain")) ? null : Convert.ToInt32(reader["ExperienceInCurrentDomain"]),
                                LeaveOrNot = reader["LeaveOrNot"].ToString()
                               

                            };
                            
                            employees.Add(employee);
                        }
                        return employees;
                    }
                }
            }
        }
    }
}
