using System;

using Dominio.ObjetosDeValor;

namespace Dominio.Entidade
{
    public class Produto
    {
        public Guid Id { get; set; }
        public NomeProduto Nome { get; set; }
        public String Descricao { get; set; }
        public ValorProduto Valor { get; set; }
        public Guid CategoriaId { get; set; }
        public String ImagemUrl { get; set; }

        public Produto(Guid id, NomeProduto nome, String descricao, ValorProduto valor, Guid categoriaId, String imagemUrl)
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