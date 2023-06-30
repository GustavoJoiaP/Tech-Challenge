using System;

using Dominio.Entidade;
using Dominio.ObjetosDeValor;

namespace Dominio.Factory
{
    public class CategoriaFactory
    {
        public Categoria CriarNova(EntidadeId id, String nome, String descricao)
        {
            NomeCategoria nomeCategoria = new NomeCategoria(nome);
            Categoria novaCategoria = new Categoria(id, nomeCategoria, descricao);
            return novaCategoria;
        }

        public Categoria CriarExistente(EntidadeId id, NomeCategoria nome, String descricao)
        {
            Categoria existenteCategoria = new Categoria(id, nome, descricao);
            return existenteCategoria;
        }
    }
}