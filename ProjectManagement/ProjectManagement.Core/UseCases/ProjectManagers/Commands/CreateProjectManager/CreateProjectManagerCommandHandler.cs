using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using MediatR;
using ProjectManagement.Core.Base.Exceptions;
using ProjectManagement.Core.Base.Interfaces;
using ProjectManagement.Core.UseCases.ProjectManagers.DTO;

namespace ProjectManagement.Core.UseCases.ProjectManagers.Commands.CreateProjectManager
{
    public class CreateProjectManagerCommandHandler :
        IRequestHandler<CreateProjectManagerCommand, CreateProjectManagerCommandResponse>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CreateProjectManagerCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<CreateProjectManagerCommandResponse> Handle(
            CreateProjectManagerCommand request,
            CancellationToken cancellationToken)
        {
            if (!_context.Bosses.Any(b => b.Id == request.BossId))
            {
                throw new NotFoundException(nameof(Boss), request.BossId);
            }

            var projectManager = _mapper.Map<ProjectManager>(request);

            await _context.ProjectManagers.AddAsync(projectManager, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            var detailedProjectManagerDto = _mapper.Map<DetailedProjectManagerDto>(projectManager);
            return new(detailedProjectManagerDto);
        }
    }
}