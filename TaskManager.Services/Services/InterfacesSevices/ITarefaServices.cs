using TaskManager.Aplicacao.DTOs;
using TaskManager.Domain.Enuns;

namespace TaskManager.Aplicacao.Services.InterfacesSevices;

public interface ITarefaServices
{
    Task<TarefaDto> CrieTarefa(TarefaDto tarefaDto);
    Task<TarefaDto> AtualizeTarefa(TarefaDto tarefaDto);
    Task<bool> RemovaTarefa(int idTarefa);
    Task<TarefaDto> ObtenhaTarefaPorId(int idTarefa);
    Task<IEnumerable<TarefaDto>> ObtenhaTarefasPorUsuario(int idUsuario);
    Task<IEnumerable<TarefaDto>> ObtenhaTarefasPorStatus(StatusTarefa status);
    Task<IEnumerable<TarefaDto>> ObtenhaTarefasPorDataDeCriacao(DateTime data);
    Task<IEnumerable<TarefaDto>> ObtenhaTarefasPorDataDeConclusao(DateTime data);
}

