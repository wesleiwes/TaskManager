using TaskManager.Domain.Entidades;
using TaskManager.Domain.Enuns;

namespace TaskManager.Infraestrutura.Interface;

public interface ITarefaRepositorio 
{
    Task<Tarefa?> ObterPorId(int id);
    Task<Tarefa> CrieTarefa(Tarefa tarefa);
    Task<bool> Remover(int id);
    Task<bool> Atualizar(Tarefa tarefa);
    Task<IEnumerable<Tarefa>> ObterTodasTarefasPorUsuario(int idUsuario);
    Task<IEnumerable<Tarefa>> ObterTodasTarefas();
    Task<IEnumerable<Tarefa>> ObterTarefasPorStatus(StatusTarefa status);
    Task<IEnumerable<Tarefa>> ObterTarefasPorDataDeCriacao(DateTime data);
    Task<IEnumerable<Tarefa>> ObterTarefasPorDataDeConclusao(DateTime data);
}

