
using DevWeek.SeuCarroNaVitrine.Negocio.NucleoCompartilhado;
using System;
using System.Collections.Generic;

namespace DevWeek.SeuCarroNaVitrine.Negocio.DominioNH.GerenciamentoDeAnunciante
{
    public class Anuncio : Agregado
    {
        private List<Proposta> _propostas = new List<Proposta>();

        public virtual Guid AnuncianteId { get; }
        public virtual DateTime DataDePublicacao { get; }
        public virtual Periodo Vigencia { get; }
        public virtual Veiculo Veiculo { get; }

        public virtual IReadOnlyList<Proposta> Propostas { get { return _propostas; } }

        public Anuncio(Guid id, Guid anuncianteId, Periodo vigencia,
            Veiculo veiculo) : base(id)
        {
            if (vigencia == null)
                throw new InvalidOperationException("A Vigência é obrigatória");

            if (veiculo == null)
                throw new InvalidOperationException("O Veículo é obrigatório");

            AnuncianteId = anuncianteId;
            DataDePublicacao = DateTime.Now;
            Vigencia = vigencia;
            Veiculo = veiculo;
        }

        public virtual void AdicionarProposta(Proposta proposta)
        {
            if (!_propostas.Contains(proposta))
                _propostas.Add(proposta);
        }
    }
}