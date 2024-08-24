using System.ComponentModel.DataAnnotations;

namespace TaskManager.Domain.Entidades;
public class Usuario
{
    [Key]
    public int IdUsuario { get; set; }

    [Required]
    [MaxLength(10)]
    public string Login { get; set; }

    [Required(ErrorMessage = "A senha é obrigatória.")]
    [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres.")]
    public string Senha { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    [MaxLength(50)]
    public string NomeCompleto { get; set; }

    public IEnumerable<Tarefa> Tarefas { get; set; } = [];
}

