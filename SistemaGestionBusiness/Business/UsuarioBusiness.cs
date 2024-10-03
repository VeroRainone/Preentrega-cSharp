using SistemaGestionData.DataAccess;
using SistemaGestionEntities;

namespace SistemaGestionBusiness.Business;

public class UsuariosBusiness
{
    private UsuariosDataAccess _usuariosDataAccess;

    public UsuariosBusiness(UsuariosDataAccess usuariosDataAccess)
    {
        _usuariosDataAccess = usuariosDataAccess;
    }
    public List<Usuario> GetUsuarios()
    {
        return _usuariosDataAccess.GetUsuarios();
    }
    public Usuario? GetOneUsuario(int id)
    {
        return _usuariosDataAccess.GetOneUsuario(id);
    }
    public void InsertUsuario(Usuario usuario)
    {
        _usuariosDataAccess.InsertUsuario(usuario);
    }
    public void UpdateUsuario(int id, Usuario usuario)
    {
        _usuariosDataAccess.UpdateUsuario(id, usuario);
    }
    public void DeleteUsuario(int id)
    {
        _usuariosDataAccess.DeleteUsuario(id);
    }
}
