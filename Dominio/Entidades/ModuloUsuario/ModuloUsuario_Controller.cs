using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ModuloUsuario_Controller
{
    public static void CrearModuloUsuario(ModuloUsuario moduloUsuario)
    {

        using var context = new AcademiaContext();

        context.ModuloUsuarios.Add(moduloUsuario);
        context.SaveChanges();

    }

    public static ModuloUsuario? GetOneModuloUsuario(int id)
    {
        using var context = new AcademiaContext();

        return context.ModuloUsuarios.Find(id);

    }

    public static IEnumerable<ModuloUsuario> GetAllModuloUsuario()
    {
        using var context = new AcademiaContext();

        return context.ModuloUsuarios.ToList();
    }

    public static void ActualizarModuloUsuario(ModuloUsuario moduloUsuario)
    {
        using var context = new AcademiaContext();

        var moduloUsuarioToUpdate = context.ModuloUsuarios.Find(moduloUsuario.Id);

        if (moduloUsuarioToUpdate != null)
        {
            moduloUsuarioToUpdate.IdModulo = moduloUsuario.IdModulo;
            moduloUsuarioToUpdate.IdUsuario = moduloUsuario.IdUsuario;
            moduloUsuarioToUpdate.PermiteAlta = moduloUsuario.PermiteAlta;
            moduloUsuarioToUpdate.PermiteBaja = moduloUsuario.PermiteBaja;
            moduloUsuarioToUpdate.PermiteConsulta = moduloUsuario.PermiteConsulta;
            moduloUsuarioToUpdate.PermiteModificacion = moduloUsuario.PermiteModificacion;
            moduloUsuarioToUpdate.Id = moduloUsuario.Id;
            context.SaveChanges();
        }
    }

    public static void EliminarModuloUsuario(int id)
    {
        using var context = new AcademiaContext();

        var moduloUsuario = context.ModuloUsuarios.Find(id);
        if (moduloUsuario != null)
        {
            context.ModuloUsuarios.Remove(moduloUsuario);
            context.SaveChanges();
        }

    }

}
