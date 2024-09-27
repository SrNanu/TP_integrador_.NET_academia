﻿using System;
using System.Linq;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Usuario_Controller
{
    public static void CrearUsuario(Usuario usuario)
    {
        
        using var context = new AcademiaContext();
        
        context.Usuarios.Add(usuario);
        context.SaveChanges();
        
        }
    

    public static Usuario? LeerUsuario(int legajo)
    {
        using var context = new AcademiaContext();

        return context.Usuarios.FirstOrDefault(u => u.Legajo == legajo);
        
    }

    public static IEnumerable<Usuario> GetAll()
    {
        using var context = new AcademiaContext();

        return context.Usuarios.ToList();
    }

    public static void ActualizarUsuario(Usuario usuario)
    {
        

        
        using var context = new AcademiaContext();
        
        var usuarioToUpdate = context.Usuarios.FirstOrDefault(u => u.Legajo == usuario.Legajo);

        if (usuarioToUpdate != null)
        {
            usuarioToUpdate.IdPlan = usuario.IdPlan;
            usuarioToUpdate.Nombre = usuario.Nombre;
            usuarioToUpdate.Apellido = usuario.Apellido;
            usuarioToUpdate.Edad = usuario.Edad;
            usuarioToUpdate.FechaNacimiento = usuario.FechaNacimiento;
            usuarioToUpdate.Direccion = usuario.Direccion;
            usuarioToUpdate.Tipo = usuario.Tipo;
            usuarioToUpdate.Telefono = usuario.Telefono;
            usuarioToUpdate.Legajo = usuario.Legajo;
            usuarioToUpdate.Email = usuario.Email;
            usuarioToUpdate.Username = usuario.Username;
            usuarioToUpdate.Password = usuario.Password;
            usuarioToUpdate.Habilitado = usuario.Habilitado;
            context.SaveChanges();
        }
            
        
    }

    public static void EliminarUsuario(int legajo)
    {
        using var context = new AcademiaContext();
        
        var usuario = context.Usuarios.FirstOrDefault(u => u.Legajo == legajo);
        if (usuario != null)
        {
            context.Usuarios.Remove(usuario);
            context.SaveChanges();
        }
        
    }
}
