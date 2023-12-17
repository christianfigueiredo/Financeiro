using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces.Generics;
using Entities.Entidades;

namespace Domain.Interfaces.IUsuarioSistemaFinanceiro
{
    public interface InterfaceUsuarioSistemaFinanceiro : InterfaceGeneric<UsuarioSistemaFinanceiro>
    {       
        Task<UsuarioSistemaFinanceiro> ListarUsuarioSistema(int IdSistema);    
        Task RemoveUsuarios(List<UsuarioSistemaFinanceiro> usuarios);     
        Task<UsuarioSistemaFinanceiro> ObterUsuarioPorEmail(string emailUsuario);    
    }
}