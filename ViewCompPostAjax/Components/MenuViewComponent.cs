using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ViewCompPostAjax.Data;

namespace ViewCompPostAjax.Components
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IRepository _repository;

        public MenuViewComponent(IRepository repository)
        {
            _repository = repository;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedItem = RouteData?.Values["id"];
            return View(_repository.Data
                .Select(x => x.DataId)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
