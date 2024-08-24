using TaskManager.Aplicacao.DTOs;
using TaskManager.Aplicacao.Mapeadores;
using TaskManager.Aplicacao.Services.InterfacesSevices;
using TaskManager.Domain.Entidades;
using TaskManager.Domain.Enuns;
using TaskManager.Infraestrutura.Interface;

namespace TaskManager.Aplicacao.Services;

public class TarefaServices(ITarefaRepositorio tarefaReposiitorio) : ITarefaServices
{
    private readonly ITarefaRepositorio _tarefaReposiitorio = tarefaReposiitorio;

    public async Task<TarefaDto> AtualizeTarefa(TarefaDto tarefaDto)
    {
        Tarefa? tarefa = await _tarefaReposiitorio.ObterPorId(tarefaDto.IdTarefa);

        return tarefa == null ?
            throw new Exception("Tarefa não encontrada") :
            MapeadorDeEntidades.ConvertaTarefaParaDto(tarefa);
    }

    public async Task<TarefaDto> CrieTarefa(TarefaDto tarefaDto)
    {
        Tarefa tarefa = MapeadorDeEntidades.ConvertaDtoParaTarefa(tarefaDto);

        Tarefa tarefaAdicionada = await _tarefaReposiitorio.CrieTarefa(tarefa);

        return MapeadorDeEntidades.ConvertaTarefaParaDto(tarefaAdicionada);
    }

    public async Task<TarefaDto> ObtenhaTarefaPorId(int idTarefa)
    {
        Tarefa? tarefa = await _tarefaReposiitorio.ObterPorId(idTarefa);

        return tarefa == null ?
            throw new Exception("Usuario não encontrado") :
            MapeadorDeEntidades.ConvertaTarefaParaDto(tarefa);
    }

    public async Task<IEnumerable<TarefaDto>> ObtenhaTarefasPorUsuario(int idUsuario)
    {
        IEnumerable<Tarefa> tarefas = await _tarefaReposiitorio.ObterTodasTarefasPorUsuario(idUsuario);

        if (tarefas == null || !tarefas.Any())
        {
            return [];
        }

        return tarefas.Select(t => MapeadorDeEntidades.ConvertaTarefaParaDto(t)).ToList();
    }

    public async Task<IEnumerable<TarefaDto>> ObteTarefasPorStatus(StatusTarefa status)
    {
        IEnumerable<Tarefa> tarefas = await _tarefaReposiitorio.ObterTarefasPorStatus(status);

        if (tarefas == null || !tarefas.Any())
        {
            return [];
        }

        return tarefas.Select(t => MapeadorDeEntidades.ConvertaTarefaParaDto(t)).ToList();
    }

    public async Task<bool> RemovaTarefa(int idTarefa)
    {
        bool sucesso = await _tarefaReposiitorio.Remover(idTarefa);

        if (!sucesso)
        {
            throw new Exception("Não foi possível remover a tarefa.");
        }

        return true;
    }
}

