using Microsoft.AspNetCore.Mvc;
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
            ViewBag.SelectedItem = RouteData?.Values["dataId"];
            return View(_repository.Data);
        }
    }
}
