using Paint_Service.API.Context;
using Paint_Service.Domain.Entities.Entities;

namespace Paint.Service.Infrastructure.Repositories
{
    public class ServicioRepository
    {
        private readonly PaintServiceContext _context;

        public ServicioRepository(PaintServiceContext context)
        {
            _context = context;
        }

        public List<Servicio> GetAll()
        {
            return _context.Servicios.ToList();
        }
    }
}