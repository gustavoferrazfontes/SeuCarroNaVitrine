using DevWeek.SeuCarroNaVitrine.Negocio.DominioEF.GerenciamentoDeAnunciante;
using System.Data.Entity.ModelConfiguration;

namespace DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioEF.Map
{
    public class AnuncianteMap:EntityTypeConfiguration<Anunciante>
    {
        public AnuncianteMap()
        {
            HasKey(anunciante => anunciante.Id);
            Property(anunciante => anunciante.Id)
                .HasColumnName("AnuncianteId");

           
            ToTable("Anunciante","dbo");      
                
        }
    }
}
