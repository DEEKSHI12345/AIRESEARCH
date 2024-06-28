using BigEmployee_DAL;
using BigEmployee_PL.BigEmployee_Entities;

namespace BigEmployee_BL
{
    public class EmployeeBl
    {
        public readonly IEmployee _employeeDAL;

        public EmployeeBl(IEmployee employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }

        public List<EmployeeDataRecord> GetEmployees(int size,int number)
        {
            return _employeeDAL.GetEmployees(size,number);
        }

    }
}
