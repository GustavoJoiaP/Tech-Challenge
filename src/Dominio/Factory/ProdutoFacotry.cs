using System;

using Dominio.Entidade;
using Dominio.ObjetosDeValor;

namespace Dominio.Factory
{
    public class ProdutoFacotry
    {
        public Produto CriarNovo(Guid id, String nome, String descricao, float valor, Guid categoriaId, String imagemUrl)
        {
            NomeProduto nomeProduto = new NomeProduto(nome);
            ValorProduto valorProduto = new ValorProduto(valor);
            Produto novoProduto = new Produto(id, nomeProduto, descricao, valorProduto, categoriaId, imagemUrl);
            return novoProduto;
        }

        public Produto CriarExistente(Guid id, String nome, String descricao, float valor, Guid categoriaId, String imagemUrl)
        {
            NomeProduto nomeProduto = new NomeProduto(nome);
            ValorProduto valorProduto = new ValorProduto(valor);
            Produto existenteProduto = new Produto(id, nomeProduto, descricao, valorProduto, categoriaId, imagemUrl);
            return existenteProduto;
        }
    }
}