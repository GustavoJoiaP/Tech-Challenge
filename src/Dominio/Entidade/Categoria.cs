using System;

using Dominio.ObjetosDeValor;

namespace Dominio.Entidade
{
    public class Categoria
    {
        public EntidadeId Id { get; set; }
        public NomeCategoria Nome { get; set; }
        public String Descricao { get; set; }

        public Categoria(EntidadeId id, NomeCategoria nome, String descricao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
        }
    }
}