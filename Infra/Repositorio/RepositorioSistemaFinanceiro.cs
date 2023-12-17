using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces.ISistemaFinanceiro;
using Entities.Entidades;
using Infra.Repositorio.Generics;

namespace Infra.Repositorio
{
    public class RepositorioSistemaFinanceiro : RepositoryGeneric<SistemaFinanceiro>, InterfaceSistemaFinanceiro
    {
        public Task<List<SistemaFinanceiro>> ListarSistemasUsuario(string emailUsuario)
        {
            throw new NotImplementedException();
        }
    }
}