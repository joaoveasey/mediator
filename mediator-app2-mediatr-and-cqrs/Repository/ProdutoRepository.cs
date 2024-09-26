using mediator_app2_mediatr_and_cqrs.Domain.Entity;
using mediator_app2_mediatr_and_cqrs.Repository.Interface;

namespace mediator_app2_mediatr_and_cqrs.Repository
{
    public class ProdutoRepository : IRepository<Produto>
    {
        private static Dictionary<int, Produto> _produtos = new Dictionary<int, Produto>();

        public Dictionary<int, Produto> GetProdutos()
        {
            _produtos.Add(1, new Produto { Id = 1, Nome = "Notebook", Preco = 1999 });
            _produtos.Add(2, new Produto { Id = 2, Nome = "Mouse", Preco = 99 });
            _produtos.Add(3, new Produto { Id = 3, Nome = "Teclado", Preco = 199 });
            _produtos.Add(4, new Produto { Id = 4, Nome = "Monitor", Preco = 799 });
            _produtos.Add(5, new Produto { Id = 5, Nome = "Cadeira", Preco = 499 });

            return _produtos;
        }

        public ProdutoRepository() 
        {
            _produtos = GetProdutos();
        }

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
