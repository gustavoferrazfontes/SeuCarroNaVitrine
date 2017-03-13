using DevWeek.SeuCarroNaVitrine.Negocio.DominioEF;
using System.Data.Entity.ModelConfiguration;

namespace DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioEF.Map
{
    public class PeriodoMap:EntityTypeConfiguration<Periodo>
    {

        public PeriodoMap()
        {
            Property(periodo => periodo.Inicial)
                .HasColumnName("PeriodoInicio");


            Property(periodo => periodo.Final)
                .HasColumnName("PeriodoFinal");
        }
    }
}
