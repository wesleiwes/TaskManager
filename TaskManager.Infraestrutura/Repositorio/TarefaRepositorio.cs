using Microsoft.EntityFrameworkCore;
using TaskManager.Domain.Entidades;
using TaskManager.Domain.Enuns;
using TaskManager.Infraestrutura.Interface;

namespace TaskManager.Infraestrutura.Repositorio;

internal class TarefaRepositorio(AppDbContext context) : ITarefaRepositorio
{

    private readonly AppDbContext _context = context;

    public async Task<Tarefa> CrieTarefa(Tarefa tarefa)
    {
        _context.Tarefas.Add(tarefa);
        await _context.SaveChangesAsync();
        return tarefa;
    }
    public async Task<bool> Atualizar(Tarefa tarefa)
    {
        _context.Tarefas.Update(tarefa);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<Tarefa?> ObterPorId(int id) =>
        await _context.Tarefas.FindAsync(id);

    public async Task<IEnumerable<Tarefa>> ObterTarefasPorDataDeCriacao(DateTime data) =>
        await _context.Tarefas.Where(t => t.DataCriacao == data).ToListAsync();

    public async Task<IEnumerable<Tarefa>> ObterTarefasPorDataDeConclusao(DateTime data) =>
        await _context.Tarefas.Where(t => t.DataConclusao == data).ToListAsync();

    public async Task<IEnumerable<Tarefa>> ObterTarefasPorStatus(StatusTarefa status) =>
        await _context.Tarefas.Where(t => t.Status == status).ToListAsync();

    public async Task<IEnumerable<Tarefa>> ObterTodasTarefas() =>
        await _context.Tarefas.ToListAsync();

    public async Task<IEnumerable<Tarefa>> ObterTodasTarefasPorUsuario(int idUsuario) =>
        await _context.Tarefas.Where(t => t.UsuarioId == idUsuario).ToListAsync();


    public async Task<bool> Remover(int id)
    {
        var tarefa = ObterPorId(id);

        _context.Remove(tarefa);

        await _context.SaveChangesAsync();
        return true;
    }

}

