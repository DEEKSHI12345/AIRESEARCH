using BigEmployee_PL.BigEmployee_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigEmployee_DAL
{
    public interface IEmployee
    {
        public List<EmployeeDataRecord> GetEmployees(int size,int number);
    }
}
