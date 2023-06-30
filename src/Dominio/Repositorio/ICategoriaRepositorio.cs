using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidade;

namespace Dominio.Repositorio
{
    public interface ICategoriaRepositorio
    {
        public void Registrar(Categoria categoria);
        public Categoria BuscarCategoriaPorId(Guid categoriaId);
        public void Deletar(Categoria categoria);
    }
}