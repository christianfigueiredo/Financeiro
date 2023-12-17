using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces.Generics;
using Entities.Entidades;


namespace Domain.Interfaces.ISistemaFinanceiro
{
    public interface InterfaceSistemaFinanceiro : InterfaceGeneric<SistemaFinanceiro>
    {
        Task<List<SistemaFinanceiro>> ListarSistemasUsuario(string emailUsuario);        
    }
}