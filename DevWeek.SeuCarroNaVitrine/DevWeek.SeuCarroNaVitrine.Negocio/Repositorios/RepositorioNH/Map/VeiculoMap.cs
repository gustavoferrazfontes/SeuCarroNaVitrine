using DevWeek.SeuCarroNaVitrine.Negocio.DominioNH.GerenciamentoDeAnunciante;
using FluentNHibernate.Mapping;

namespace DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioNH.Map
{
    public class VeiculoMap:ClassMap<Veiculo>
    {
        public VeiculoMap()
        {
            Id(v => v.Id);

            Component(v => v.Detalhe, detalhe => 
            {
                detalhe.Map(d => d.Cambio);
                detalhe.Map(d => d.Carroceria);
                detalhe.Map(d => d.Combustivel);
                detalhe.Map(d => d.Cor);
                detalhe.Map(d => d.Kilometragem);
                detalhe.Map(d => d.Placa);
                detalhe.Map(d => d.Portas);
                detalhe.Map(d => d.Preco);
            });

        }
    }
}
