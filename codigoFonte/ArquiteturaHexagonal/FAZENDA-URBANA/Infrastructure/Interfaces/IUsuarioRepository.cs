﻿using Domain.Entities;

namespace Infrastructure.Interfaces
{
    public interface IUsuarioRepository
    {
        bool IncluirUsuario(Usuario usuario);
        List<Usuario> ConsultarUsuario(string nomeCliente);
        bool AlterarUsuario(Usuario usuario);
        bool ExcluirUsuario(int id);
        int ConsultarPerfilUsuario(Usuario usuario);
    }
}