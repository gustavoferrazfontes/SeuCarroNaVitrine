using DevWeek.SeuCarroNaVitrine.Negocio.DominioEF.GerenciamentoDeAnunciante;
using System.Data.Entity.ModelConfiguration;

namespace DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioEF.Map
{
    public class AnuncianteMap:EntityTypeConfiguration<Anunciante>
    {
        public AnuncianteMap()
        {
            HasKey(Anunciante.IdentidadeExpression);

            Property(Anunciante.IdentidadeExpression)
                .HasColumnName("AnuncianteId");

            ToTable("Anunciante");      
                
        }
    }
}
