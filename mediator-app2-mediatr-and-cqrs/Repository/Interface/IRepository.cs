using System.Collections.Generic;
using System.Threading.Tasks;

namespace mediator_app2_mediatr_and_cqrs.Repository.Interface;

public interface IRepository<T>
{
    Task<IEnumerable<T>> GetAll();
    Task<T> Get(int id);
    Task Add(T entity);
    Task Edit(T entity);
    Task Delete(int id);
}
