using System;

using Dominio.Entidade;
using Dominio.ObjetosDeValor;

namespace Dominio.Factory
{
    public class CategoriaFactory
    {
        public Categoria CriarNova(Guid id, String nome, String descricao)
        {
            NomeCategoria nomeCategoria = new NomeCategoria(nome);
            Categoria novaCategoria = new Categoria(id, nomeCategoria, descricao);
            return novaCategoria;
        }

        public Categoria CriarExistente(Guid id, String nome, String descricao)
        {
            NomeCategoria nomeCategoria = new NomeCategoria(nome);
            Categoria existenteCategoria = new Categoria(id, nomeCategoria, descricao);
            return existenteCategoria;
        }
    }
}