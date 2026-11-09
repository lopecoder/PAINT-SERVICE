using Paint_Service.API.Context;
using Paint_Service.Domain.Entities.Entities;

namespace Paint.Service.Infrastructure.Repositories
{
    public class ClienteRepository
    {
        private readonly PaintServiceContext _context;

        public ClienteRepository(PaintServiceContext context)
        {
            _context = context;
        }

        public List<Cliente> GetAll()
        {
            return _context.Clientes.ToList();
        }
    }
}
