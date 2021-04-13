using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Core.Base.Interfaces;
using ProjectManagement.Core.UseCases.ProjectManagers.DTO;
using ProjectManagement.Core.UseCases.ProjectManagers.ViewModels;

namespace ProjectManagement.Core.UseCases.ProjectManagers.Queries.GetProjectManagers
{
    public class GetProjectManagersQueryHandler : IRequestHandler<GetProjectManagersQuery, ProjectManagerVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetProjectManagersQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public async Task<ProjectManagerVm> Handle(GetProjectManagersQuery request, CancellationToken cancellationToken)
        {
            var projectManagers = 
                await _context.ProjectManagers
                    .ProjectTo<ProjectManagerDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);
            return new()
            {
                ProjectManagersList = projectManagers,
                Count = projectManagers.Count
            };
        }
    }
}