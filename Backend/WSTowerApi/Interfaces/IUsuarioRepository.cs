﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSTowerApi.Domains;

namespace WSTowerApi.Interfaces
{
    interface IUsuarioRepository
    {
        Usuario Login(string email, string apelido, string senha);
        public void Cadastrar(Usuario novoUsuario);
        public void Remover(int id);
        public void Atualizar(int id, Usuario usuarioAtualizado);
    }
}