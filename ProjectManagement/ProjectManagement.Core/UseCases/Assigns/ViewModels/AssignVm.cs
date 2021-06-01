using System.Collections.Generic;
using ProjectManagement.Core.UseCases.Assigns.Dto;

namespace ProjectManagement.Core.UseCases.Assigns.ViewModels
{
    public class AssignVm
    {
        public IList<AssignDto> AssignDto { get; set; }
        public int Count { get; set; }
    }
}
