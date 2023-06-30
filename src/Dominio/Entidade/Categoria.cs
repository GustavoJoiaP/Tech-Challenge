using System;


namespace Dominio.Entidade
{
    public class Categoria
    {
        public Guid Id { get; set; }
        public NomeCategoria Nome { get; set; }
        public String Descricao { get; set; }
        public Categoria(Guid id, NomeCategoria nome, String descricao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
        }
    }
}