using SistemaGestionData.Context;
using SistemaGestionEntities;

namespace SistemaGestionData.DataAccess;
public class UsuariosDataAccess
{
    private BioTecnologyContext _context;
    public UsuariosDataAccess(BioTecnologyContext context)
    {
        _context = context; 
    }
    public List<Usuario> GetUsuarios()
    {
        return _context.Usuarios.ToList();
    }
    public Usuario? GetOneUsuario(int id)
    {
        return _context.Usuarios.FirstOrDefault(Usuario => Usuario.Id == id); ;
    }
    public void InsertUsuario(Usuario Usuario)
    {
        _context.Usuarios.Add(Usuario);
        _context.SaveChanges();
    }
    public void UpdateUsuario(int id, Usuario Usuario)
    {
        Usuario? usuarioAEditar = GetOneUsuario(id);
        if (usuarioAEditar != null)
        {
            usuarioAEditar.Nombre = Usuario.Nombre ;
            usuarioAEditar.Apellido = Usuario.Apellido ;
            usuarioAEditar.NombreUsuario = Usuario.NombreUsuario ;
            usuarioAEditar.Contrasenia = Usuario.Contrasenia;
            usuarioAEditar.Email = Usuario.Email;

            _context.SaveChanges();
        }
    }
    public void DeleteUsuario(int id)
    {
        Usuario? usuarioAEliminar = GetOneUsuario(id);
        if (usuarioAEliminar != null)
        {
            _context.Usuarios.Remove(usuarioAEliminar);
            _context.SaveChanges();
        }
    }
}