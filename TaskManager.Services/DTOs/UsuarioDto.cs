namespace TaskManager.Aplicacao.DTOs;

public class UsuarioDto
{
    public int IdUsuario { get; set; }

    public string Login { get; set; }

    public string? Email { get; set; }

    public string NomeCompleto { get; set; }

    public IEnumerable<TarefaDto> Tarefas { get; set; } = [];
}

