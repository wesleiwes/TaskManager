using TaskManager.Aplicacao.DTOs;
using TaskManager.Aplicacao.Mapeadores;
using TaskManager.Aplicacao.Services.InterfacesSevices;
using TaskManager.Domain.Entidades;
using TaskManager.Infraestrutura.Interface;

namespace TaskManager.Aplicacao.Services;

public class UsuarioServices(IUsuarioRepositorio usuarioRepositorio) : IUsuarioServices
{
    private readonly IUsuarioRepositorio _usuarioRepositorio = usuarioRepositorio;

    public async Task<UsuarioDto> AtualizeUsuario(UsuarioDto usuarioDto)
    {
        Usuario? usuario = await _usuarioRepositorio.ObterPorId(usuarioDto.IdUsuario) ?? throw new Exception("Usuário não encontrado");

        usuario.NomeCompleto = usuarioDto.NomeCompleto;
        usuario.Email = usuarioDto.Email;
        usuario.Login = usuarioDto.Login;
      
        await _usuarioRepositorio.Atualizar(usuario);

        return MapeadorDeEntidades.ConvertaUsuarioParaDto(usuario);
    }

    public async Task<UsuarioDto> CrieUsuario(UsuarioDto usuarioDto)
    {
        var usuario = MapeadorDeEntidades.ConvertaDtoParaUsuario(usuarioDto);

        var usuarioAdicionado = await _usuarioRepositorio.Adicionar(usuario);

        return MapeadorDeEntidades.ConvertaUsuarioParaDto(usuarioAdicionado);
    }

    public async Task<IEnumerable<UsuarioDto>> ObtenhaTodosUsuarios()
    {
        IEnumerable<Usuario> usuarios = await _usuarioRepositorio.ObterTodos();

        IEnumerable<UsuarioDto> usuariosDto = usuarios.Select(u => MapeadorDeEntidades.ConvertaUsuarioParaDto(u));
        return usuariosDto;
    }

    public async Task<UsuarioDto> ObtenhaUsuarioPorId(int idUsuario)
    {
        Usuario? usuario = await _usuarioRepositorio.ObterPorId(idUsuario);

        return usuario == null ?
            throw new Exception("Usuario não encontrado") :
            MapeadorDeEntidades.ConvertaUsuarioParaDto(usuario);
    }

    public async Task<bool> RemovaUsuario(int idUsuario)
    {
        bool sucesso = await _usuarioRepositorio.Remover(idUsuario);

        if (!sucesso)
        {
            throw new Exception("Não foi possível remover o usuário.");
        }
        return true;
    }
}


