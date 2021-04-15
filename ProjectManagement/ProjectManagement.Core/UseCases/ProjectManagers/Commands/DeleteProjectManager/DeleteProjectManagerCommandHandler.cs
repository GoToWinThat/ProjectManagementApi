using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using MediatR;
using ProjectManagement.Core.Base.Exceptions;
using ProjectManagement.Core.Base.Interfaces;

namespace ProjectManagement.Core.UseCases.ProjectManagers.Commands.DeleteProjectManager
{
    public class DeleteProjectManagerCommandHandler : IRequestHandler<DeleteProjectManagerCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteProjectManagerCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<Unit> Handle(DeleteProjectManagerCommand request, CancellationToken cancellationToken)
        {
            var projectManager = await _context.ProjectManagers.FindAsync(request.ProjectManagerId, cancellationToken);
            if (projectManager == null)
            {
                throw new NotFoundException(nameof(ProjectManager), request.ProjectManagerId);
            }
            
            _context.ProjectManagers.Remove(projectManager);
            await _context.SaveChangesAsync(cancellationToken);
            
            return Unit.Value;
        }
    }
}