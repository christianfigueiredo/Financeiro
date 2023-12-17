using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces.Generics;
using Entities.Entidades;

namespace Domain.Interfaces.ICategoria
{
    public interface InterfaceCategoria : InterfaceGeneric<Categoria>
    {
        Task<List<Categoria>> ListarCategoriasUsuario(string emailUsuario);            
    }
}