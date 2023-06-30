using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Produto
    {
        public Guid Id { get; set; }
        public NomeProduto Nome { get; set; }
        public String Descricao { get; set; }
        public ValorProduto Valor { get; set; }
        public Categoria CategoriaId { get; set; }
        public String ImagemUrl { get; set; }

        public Produto(Guid id, NomeProduto nome, String descricao, ValorProduto valor, Categoria categoriaId, String imagemUrl)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            CategoriaId = categoriaId;
            ImagemUrl = imagemUrl;
        }

    }
}