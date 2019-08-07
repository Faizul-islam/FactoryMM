using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.EmployeeMm
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ EmpId = 1, EmpName = "Farhan", Phone = 01785464454,Address="Uttara, Dhaka" , EmpCatId = EmployeeCategor.Manager, JoiningDate=DateTime.Now, BloodGroup = BloodGroup.A_Negative },
                new Employee(){ EmpId = 2, EmpName = "Tuhid", Phone = 01885464454,Address="Dhanmondi, Dhaka" , EmpCatId = EmployeeCategor.Marketing_Manager, JoiningDate=DateTime.Now, BloodGroup = BloodGroup.AB_Negative},
                new Employee(){ EmpId = 3, EmpName = "Hafiz", Phone = 01985464454,Address="Mohakhali, Dhaka" , EmpCatId = EmployeeCategor.Machine_Operator, JoiningDate=DateTime.Now, BloodGroup = BloodGroup.AB_Positive},
            };
        }

        public Employee Add(Employee employee)
        {
            employee.EmpId = _employeeList.Max(e => e.EmpId) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return this._employeeList.FirstOrDefault(e => e.EmpId == Id);
        }

        public Employee Update(Employee employeeChanges)
        {
            throw new NotImplementedException();
        }
    }
}
