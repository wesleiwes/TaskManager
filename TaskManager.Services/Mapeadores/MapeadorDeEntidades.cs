using TaskManager.Aplicacao.DTOs;
using TaskManager.Domain.Entidades;

namespace TaskManager.Aplicacao.Mapeadores;

public static class MapeadorDeEntidades
{
    public static UsuarioDto ConvertaUsuarioParaDto(Usuario usuario)
    {
        return new UsuarioDto
        {
            IdUsuario = usuario.IdUsuario,
            NomeCompleto = usuario.NomeCompleto,
            Email = usuario.Email,
            Login = usuario.Login,
            Tarefas = usuario.Tarefas.Select(t => ConvertaTarefaParaDto(t)).ToList()
        };
    }

    public static TarefaDto ConvertaTarefaParaDto(Tarefa tarefa)
    {
        return new TarefaDto
        {
            IdTarefa = tarefa.IdTarefa,
            Nome = tarefa.Nome,
            Descricao = tarefa.Descricao,
            DataCriacao = tarefa.DataCriacao,
            DataConclusao = tarefa.DataConclusao,
            Status = tarefa.Status,
            Prioridade = tarefa.Prioridade,
            UsuarioId = tarefa.UsuarioId
        };
    }

    public static Tarefa ConvertaDtoParaTarefa(TarefaDto tarefa)
    {
        return new Tarefa
        {
            IdTarefa = tarefa.IdTarefa,
            Nome = tarefa.Nome,
            Descricao = tarefa.Descricao,
            DataCriacao = tarefa.DataCriacao,
            DataConclusao = tarefa.DataConclusao,
            Status = tarefa.Status,
            Prioridade = tarefa.Prioridade,
            UsuarioId = tarefa.UsuarioId
        };
    }

    public static Usuario ConvertaDtoParaUsuario(UsuarioDto usuario)
    {
        return new Usuario
        {
            IdUsuario = usuario.IdUsuario,
            NomeCompleto = usuario.NomeCompleto,
            Email = usuario.Email,
            Login = usuario.Login,
            Tarefas = usuario.Tarefas.Select(t => ConvertaDtoParaTarefa(t)).ToList()
        };
    }
}

