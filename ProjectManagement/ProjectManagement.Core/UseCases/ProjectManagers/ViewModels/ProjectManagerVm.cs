using System.Collections.Generic;
using ProjectManagement.Core.UseCases.ProjectManagers.DTO;

namespace ProjectManagement.Core.UseCases.ProjectManagers.ViewModels
{
    public class ProjectManagerVm
    {
        public IList<ProjectManagerDto> ProjectManagersList { get; set; }
        public int Count { get; set; }
    }
}