using System;

using Dominio.Entidade;

namespace Dominio.Repositorio
{
    public interface IProdutoRepository
    {
        public void Registrar(Produto produto);
        public Produto BuscarProdutoPorId(Guid produtoId);
        public void Deletar(Produto produto);
    }
}