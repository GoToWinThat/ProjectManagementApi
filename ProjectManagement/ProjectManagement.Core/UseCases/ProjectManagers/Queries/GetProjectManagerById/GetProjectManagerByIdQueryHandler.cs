using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using MediatR;
using ProjectManagement.Core.Base.Exceptions;
using ProjectManagement.Core.Base.Interfaces;
using ProjectManagement.Core.UseCases.ProjectManagers.DTO;

namespace ProjectManagement.Core.UseCases.ProjectManagers.Queries.GetProjectManagerById
{
    public class GetProjectManagerQueryHandler : IRequestHandler<GetProjectManagerByIdQuery, DetailedProjectManagerDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetProjectManagerQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<DetailedProjectManagerDto> Handle(GetProjectManagerByIdQuery request, CancellationToken cancellationToken)
        {
            var projectManager = await _context.ProjectManagers.FindAsync(request.ProjectManagerId, cancellationToken);
            if (projectManager == null)
            {
                throw new NotFoundException(nameof(ProjectManager), request.ProjectManagerId);
            }

            var projectManagerToReturn = _mapper.Map<DetailedProjectManagerDto>(projectManager);
            return projectManagerToReturn;
        }
    }
}