﻿using DevWeek.SeuCarroNaVitrine.Negocio.Comum;
using System;

namespace DevWeek.SeuCarroNaVitrine.Negocio.DominioEF
{
    public sealed class Periodo : ObjetoDeValor<Periodo>
    {
        public DateTime Inicial { get; private set; }
        public DateTime Final { get; private set; }

        //construtor sem parametros necessário para atender necessidades do EF e NH
        private Periodo()
        {

        }

        private Periodo(DateTime inicial, DateTime final)
        {
            if (inicial == DateTime.MinValue)
                throw new InvalidOperationException("O Período Inicial é obrigatório");

            if (final == DateTime.MinValue)
                throw new InvalidOperationException("O Período Final é obrigatório");

            if (inicial > final)
                throw new InvalidOperationException("O Período Inicial não pode ser maior que o Período Final");

            Inicial = inicial;
            Final = final;
        }

        public static Periodo Novo(DateTime inicial, DateTime final)
        {
            return new Periodo(inicial, final);
        }

        protected override bool EqualsCore(Periodo other)
        {
            return Inicial == other.Inicial
                && Final == other.Final;
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                var hashCode = Inicial.GetHashCode();
                hashCode = (hashCode * 397) ^ Final.GetHashCode();

                return hashCode;
            }
        }
    }
}
