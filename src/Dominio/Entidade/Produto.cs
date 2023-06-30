using System;

using Dominio.ObjetosDeValor;

namespace Dominio.Entidade
{
    public class Produto
    {
        public EntidadeId Id { get; set; }
        public NomeProduto Nome { get; set; }
        public String Descricao { get; set; }
        public ValorProduto Valor { get; set; }
        public EntidadeId CategoriaId { get; set; }
        public String ImagemUrl { get; set; }

        public Produto(EntidadeId id, NomeProduto nome, String descricao, ValorProduto valor, EntidadeId categoriaId, String imagemUrl)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Valor = valor;
            this.CategoriaId = categoriaId;
            this.ImagemUrl = imagemUrl;
        }

    }
}