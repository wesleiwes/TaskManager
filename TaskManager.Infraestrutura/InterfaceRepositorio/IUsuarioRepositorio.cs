using TaskManager.Domain.Entidades;

namespace TaskManager.Infraestrutura.Interface;

public interface IUsuarioRepositorio
{
    Task<Usuario> Adicionar(Usuario usuario);
    Task<Usuario?> ObterPorId(int id);
    Task<bool> Remover(int id);
    Task<Usuario> Atualizar(Usuario usuario);
    Task<IEnumerable<Usuario>> ObterTodos();

}
