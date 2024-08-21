using TaskManager.Domain.Entidades;

namespace TaskManager.Infraestrutura.Interface;

public interface IUsuarioRepositorio
{
    Task Adicionar(Usuario usuario);
    Task<Usuario?> ObterPorId(int id);
    Task Remover(int id);
    Task Atualizar(Usuario usuario);
    Task<IEnumerable<Usuario>> ObterTodos();

}
 