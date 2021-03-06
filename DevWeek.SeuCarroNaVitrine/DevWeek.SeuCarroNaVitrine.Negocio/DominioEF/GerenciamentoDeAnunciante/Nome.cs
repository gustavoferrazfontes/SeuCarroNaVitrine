﻿using System;
using DevWeek.SeuCarroNaVitrine.Negocio.Comum;

namespace DevWeek.SeuCarroNaVitrine.Negocio.DominioEF.GerenciamentoDeAnunciante
{
    public sealed class Nome : ObjetoDeValor<Nome>
    {
        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }

        private Nome()
        {

        }
        
        private Nome(string primeiroNome, string sobreNome)
        {
            if (string.IsNullOrWhiteSpace(primeiroNome))
                throw new InvalidOperationException("O Primeiro Nome é obrigatório");

            if (string.IsNullOrWhiteSpace(sobreNome))
                throw new InvalidOperationException("O Sobrenome é obrigatório");

            PrimeiroNome = primeiroNome;
            Sobrenome = sobreNome;
        }

        internal Nome Novo()
        {
            throw new NotImplementedException();
        }

        public static Nome Novo(string primeiroNome, string sobreNome)
        {
            return new Nome(primeiroNome, sobreNome);
        }

        protected override bool EqualsCore(Nome other)
        {
            return PrimeiroNome == other.PrimeiroNome &&
                Sobrenome == other.Sobrenome;
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                int hashCode = PrimeiroNome.GetHashCode();
                hashCode = (hashCode * 397) ^ Sobrenome.GetHashCode();

                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"{PrimeiroNome} {Sobrenome}";
        }
    }
}