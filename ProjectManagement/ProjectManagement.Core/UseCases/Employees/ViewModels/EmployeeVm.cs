using System.Collections;
using System.Collections.Generic;
using ProjectManagement.Core.UseCases.Employees.Dto;

namespace ProjectManagement.Core.UseCases.Employees.ViewModels
{
    public class EmployeeVm
    {
        public IList<EmployeeDto> Employees { get; set; }
        public int Count { get; set; }
    }
}
