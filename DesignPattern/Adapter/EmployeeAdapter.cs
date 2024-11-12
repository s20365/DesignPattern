using System;
using System.Collections.Generic;

namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new BillingSystem();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            List<Employee> adaptedEmployees = new List<Employee>();
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                adaptedEmployees.Add(new Employee(
                    int.Parse(employeesArray[i, 0]),        
                    employeesArray[i, 1],                   
                    employeesArray[i, 2],                   
                    Convert.ToDecimal(employeesArray[i, 3]) 
                ));
            }
            thirdPartyBillingSystem.ProcessSalary(adaptedEmployees);
        }
    }
}