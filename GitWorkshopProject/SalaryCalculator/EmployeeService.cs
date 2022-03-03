﻿using System;

namespace SalaryCalculator
{
    public class EmployeeService
    {
        private const decimal BASIC_SALARY = 10000000;

        public static decimal CalculateSalary(EmployeeType employeeType, int years)
        {
            if (years < 0)
            {
                throw new ArgumentException("Years of experience is not valid");
            }

            decimal factor = 0;

            if (employeeType == EmployeeType.Engineer)
            {
                factor = 1;
            }
            else if (employeeType == EmployeeType.SeniorEngineer || employeeType == EmployeeType.Manager)
            {
                factor = 2.0m;
            }
            else if (employeeType == EmployeeType.SeniorManager)
            {
                factor = 3;
            }
            // TODO: if employee is Expert, set factor = 3

            var salary = BASIC_SALARY * years * factor;

            return salary;
        }
    }
}
