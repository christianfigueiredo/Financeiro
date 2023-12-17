using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces.Generics;
using Entities.Entidades;

namespace Domain.Interfaces.IDespesa
{
    public interface InterfaceDespesa : InterfaceGeneric<Despesa>
    {
        Task<List<Despesa>> ListarDespesasUsuario(string emailUsuario);

        Task<List<Despesa>> ListarDespesasUsuarioNaoPagasMesesAnterior(string emailUsuario);

        


    }
}