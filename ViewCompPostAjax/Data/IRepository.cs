using System.Linq;
using ViewCompPostAjax.Models;

namespace ViewCompPostAjax.Data
{
    public interface IRepository
    {
        public IQueryable<DataModel> Data { get; }
    }
}
