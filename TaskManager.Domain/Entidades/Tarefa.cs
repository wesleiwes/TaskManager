using System.ComponentModel.DataAnnotations;
using TaskManager.Domain.Enuns;

namespace TaskManager.Domain.Entidades;

public class Tarefa
{
    [Key]
    public int IdTarefa { get; set; }
    [Required(ErrorMessage = "Deve ser informado o nome da tarefa!")]
    [MaxLength(20)]
    public string Nome { get; set; }
    public string? Descricao { get; set; }
    [Required]
    public DateTime DataCriacao { get; set; }
    public DateTime? DataConclusao { get; set; }
    public StatusTarefa Status { get; set; }
    [Required(ErrorMessage ="Informe qual o nível de prioridade da tarefa.")]
    public PrioridadeTarefa Prioridade { get; set; } 

    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
}

