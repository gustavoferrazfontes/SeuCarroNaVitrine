using DevWeek.SeuCarroNaVitrine.Negocio.DominioEF.GerenciamentoDeAnuncio;
using System.Data.Entity.ModelConfiguration;

namespace DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioEF.Map
{
    public class VeiculoMap : EntityTypeConfiguration<Veiculo>
    {
        public VeiculoMap()
        {
            HasKey(veiculo => veiculo.Id);

            Property(veiculo => veiculo.Id)
                .HasColumnName("VeiculoId");


            HasRequired(anuncio => anuncio.Anuncio);

            ToTable("Veiculo");

        }
    }
}
