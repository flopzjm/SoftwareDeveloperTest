using System;

namespace Business
{
    public class EmployeeBO
    {
        //make common business logic here
        //haz una funcion recursiva para calcular el salario anual de un empleado dado su salario mensual
        public decimal CalculateAnnualSalary(decimal monthlySalary, int monthsWorked)
        {
            if (monthsWorked <= 0)
            {
                return 0;
            }
            return monthlySalary + CalculateAnnualSalary(monthlySalary, monthsWorked - 1);
        }
    }
}
