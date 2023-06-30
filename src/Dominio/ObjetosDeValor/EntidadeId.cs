using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.ObjetosDeValor
{
    public class EntidadeId
    {
        public Guid Valor { get; init; }

        public EntidadeId(Guid valor) => Valor = valor;

        public static EntidadeId CriarNovo() => new EntidadeId(Guid.NewGuid());

        public static EntidadeId CriarPara(Guid valor)
        {
            Validar(valor);

            return new EntidadeId(valor);
        }

        private static void Validar(Guid valor)
        {
            if (valor == Guid.Empty)
            {
                throw new ArgumentException("EntidadeId não pode ser vazia");
            }
        }
    
    }
}