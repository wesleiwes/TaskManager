using TaskManager.Domain.Entidades;

namespace TaskManager.Infraestrutura.Interface;

public interface ITarefaRepositorio
{
    Task<Usuario> ObterPorId(int id);
    Task<Usuario> Adicionar(Usuario usuario);
    Task<bool> Remover(int id);
    Task<bool> Atualizar(Usuario usuario);
    Task<IEnumerable<Usuario>> ObterTodos();
}

