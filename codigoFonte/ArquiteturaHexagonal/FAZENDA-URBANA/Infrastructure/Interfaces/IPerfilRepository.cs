﻿using Domain.Entities;

namespace Infrastructure.Interfaces
{
    public interface IPerfilRepository
    {
        bool AlterarPerfil(Perfil Perfil);
        bool ExcluirPerfil(int id);
        List<Perfil> ConsultarPerfil(string nomePerfil);
        List<Perfil> ConsultarTodosPerfis();
        bool IncluirPerfil(Perfil Perfil);
    }
}