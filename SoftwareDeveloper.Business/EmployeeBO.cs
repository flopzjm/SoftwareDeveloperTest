using Newtonsoft.Json;
using SoftwareDeveloper.Entities;
using SoftwarePresentation.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDeveloper.Business
{
    public class EmployeeBO
    {

        public long CalculateEmployeeAnualSalary(long employee_salary)
        {
            long Employee_anual_salary = default(long);
            try
            {
                Employee_anual_salary = employee_salary * 12;
                return Employee_anual_salary;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Datum>> GetEmployeeAsync(int id)
        {
            string employeeJson = default(string);
            List<Datum> lst_Datum = new List<Datum>();
            try
            {
                EmployeeDAO employees = new EmployeeDAO();
                //employeeJson = await employees.GetEmployee(id);
                employeeJson = employees.GetEmployeeRest(id);
                var data = JsonConvert.DeserializeObject<EmployeeDTO>(employeeJson);
                int numeroData = data.Data.Count();
                for (int i = 0; i < numeroData; i++)
                {
                    lst_Datum.Add(new Datum()
                    {
                        Id = data.Data[i].Id,
                        EmployeeName = data.Data[i].EmployeeName,
                        EmployeeSalary = data.Data[i].EmployeeSalary,
                        EmployeeAge = data.Data[i].EmployeeAge,
                        EmployeeAnualSalary = CalculateEmployeeAnualSalary(data.Data[i].EmployeeSalary),
                        ProfileImage = data.Data[i].ProfileImage

                    });
                }

                return lst_Datum;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Datum>> GetEmployeesAsync()
        {
            string employeeJson = default(string);
            List<Datum> lst_Datum = new List<Datum>();
            try
            {
                EmployeeDAO employee = new EmployeeDAO();
                employeeJson = employee.GetEmployeesRest();

                if (!string.IsNullOrEmpty(employeeJson))
                {
                    var data = JsonConvert.DeserializeObject<EmployeeDTO>(employeeJson);
                    int numeroData = data.Data.Count();
                    for (int i = 0; i < numeroData; i++)
                    {
                        lst_Datum.Add(new Datum()
                        {
                            Id = data.Data[i].Id,
                            EmployeeName = data.Data[i].EmployeeName,
                            EmployeeSalary = data.Data[i].EmployeeSalary,
                            EmployeeAge = data.Data[i].EmployeeAge,
                            EmployeeAnualSalary = CalculateEmployeeAnualSalary(data.Data[i].EmployeeSalary),
                            ProfileImage = data.Data[i].ProfileImage

                        });
                    }
                }
                return lst_Datum;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
