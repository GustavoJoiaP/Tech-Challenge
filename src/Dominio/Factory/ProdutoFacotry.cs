using System;

using Dominio.Entidade;
using Dominio.ObjetosDeValor;

namespace Dominio.Factory
{
    public class ProdutoFacotry
    {
        public Produto CriarNovo(EntidadeId id, String nome, String descricao, float valor, EntidadeId categoriaId, String imagemUrl)
        {
            EntidadeId novoProdutoId = new EntidadeId(Guid.NewGuid());
            NomeProduto nomeProduto = new NomeProduto(nome);
            ValorProduto valorProduto = new ValorProduto(valor);
            Produto novoProduto = new Produto(novoProdutoId, nomeProduto, descricao, valorProduto, categoriaId, imagemUrl);
            return novoProduto;
        }

        public Produto CriarExistente(EntidadeId id, NomeProduto nome, String descricao, ValorProduto valor, EntidadeId categoriaId, String imagemUrl)
        {
            Produto existenteProduto = new Produto(id, nome, descricao, valor, categoriaId, imagemUrl);
            return existenteProduto;
        }
    }
}