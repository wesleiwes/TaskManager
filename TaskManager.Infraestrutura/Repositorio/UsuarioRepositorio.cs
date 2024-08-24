using Microsoft.EntityFrameworkCore;
using TaskManager.Domain.Entidades;
using TaskManager.Infraestrutura.Interface;

namespace TaskManager.Infraestrutura.Repositorio;

public class UsuarioRepositorio(AppDbContext context) : IUsuarioRepositorio
{
    private readonly AppDbContext _context = context;

    public async Task<Usuario> Adicionar(Usuario usuario)
    {
        _context.Add(usuario);
        await _context.SaveChangesAsync();
        return usuario;
    }

    public async Task<Usuario> Atualizar(Usuario usuario)
    {
        _context.Update(usuario);
        await _context.SaveChangesAsync();
        return usuario;
    }

    public async Task<Usuario?> ObterPorId(int id) =>
        await _context.Usuarios.FindAsync(id);

    public async Task<IEnumerable<Usuario>> ObterTodos() =>
        await _context.Usuarios.ToListAsync();

    public async Task<bool> Remover(int id)
    {
        Usuario? usuario = await ObterPorId(id);

        if (usuario != null)
        {
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
        }
        return true;
    }
}

