using TaskManager.Domain.Enuns;

namespace TaskManager.Aplicacao.DTOs;

public class TarefaDto
{
    public int IdTarefa { get; set; }

    public string Nome { get; set; }

    public string? Descricao { get; set; }

    public DateTime DataCriacao { get; set; }

    public DateTime? DataConclusao { get; set; }

    public StatusTarefa Status { get; set; }

    public PrioridadeTarefa Prioridade { get; set; }

    public int UsuarioId { get; set; }

    public UsuarioDto Usuario { get; set; }
}

