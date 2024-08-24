using TaskManager.Aplicacao.DTOs;

namespace TaskManager.Aplicacao.Services.InterfacesSevices;

public interface IUsuarioServices
{
    Task<UsuarioDto> CrieUsuario(UsuarioDto usuarioDto);
    Task<UsuarioDto> AtualizeUsuario(UsuarioDto usuarioDto);
    Task<bool> RemovaUsuario(int idUsuario);
    Task<UsuarioDto> ObtenhaUsuarioPorId(int idUsuario);
    Task<IEnumerable<UsuarioDto>> ObtenhaTodosUsuarios();
}

