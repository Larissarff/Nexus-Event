using backend.Entities;
using backend.Interfaces;

namespace backend.Repositories;

public class EventoRepository : IEventoRepository
{
    // Quando você criar o DbContext, ele será injetado aqui no construtor.

    public async Task<IEnumerable<EventoEntity>> GetTodosAsync()
    {
        // No futuro: return await _context.Eventos.ToListAsync();
        throw new NotImplementedException();
    }

    public async Task<EventoEntity?> GetPorIdAsync(Guid id)
    {
        // No futuro: return await _context.Eventos.FindAsync(id);
        throw new NotImplementedException();
    }

    public async Task AdicionarAsync(EventoEntity evento)
    {
        throw new NotImplementedException();
    }

    public async Task AtualizarAsync(EventoEntity evento)
    {
        throw new NotImplementedException();
    }

    public async Task DeletarAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<EventoEntity>> BuscarPorTituloAsync(string titulo)
    {
        throw new NotImplementedException();
    }
}