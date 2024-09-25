using mediator_app2_mediatr_and_cqrs.Domain.Entity;
using mediator_app2_mediatr_and_cqrs.Repository.Interface;

namespace mediator_app2_mediatr_and_cqrs.Repository
{
    public class ProdutoRepository : IRepository<Produto>
    {
        private static Dictionary<int, Produto> _produtos = new Dictionary<int, Produto>();

        public async Task<IEnumerable<Produto>> GetAll()
        {
            return await Task.Run(() => _produtos.Values.ToList());
        }

        public Task<Produto> Get(int id)
        {
            return Task.Run(() => _produtos.GetValueOrDefault(id));
        }

        public async Task Add(Produto entity)
        {
            await Task.Run(() => _produtos.Add(entity.Id, entity));
        }

        public async Task Edit(Produto entity)
        {
            await Task.Run(() =>
            {
                _produtos.Remove(entity.Id);
                _produtos.Add(entity.Id, entity);
            });
        }

        public async Task Delete(int id)
        {
            await Task.Run(() => _produtos.Remove(id));
        }
    }
}
