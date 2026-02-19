using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyAcademyMediatorProject.MediatorPattern.Queries.CategoryQueries;

namespace MyAcademyMediatorProject.Areas.Admin.Controllers
{
    public class CategoryController(IMediator _mediator) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await _mediator.Send(new GetCategoriesQuery());
            return View(categories);
        }

        public async Task<IActionResult> UpdateCategory(Guid id)
        {
            var category = await _mediator.Send(new GetCategoryByIdQuery(id));
            return View(category);
        }
    }
}
