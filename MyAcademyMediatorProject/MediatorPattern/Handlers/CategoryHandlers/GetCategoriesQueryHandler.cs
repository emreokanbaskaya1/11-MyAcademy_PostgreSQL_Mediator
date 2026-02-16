using MediatR;
using MyAcademyMediatorProject.MediatorPattern.Queries.CategoryQueries;
using MyAcademyMediatorProject.MediatorPattern.Results.CategoryResults;

namespace MyAcademyMediatorProject.MediatorPattern.Handlers.CategoryHandlers
{
    public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, List<GetCategoriesQueryResult>>
    {
        public Task<List<GetCategoriesQueryResult>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
