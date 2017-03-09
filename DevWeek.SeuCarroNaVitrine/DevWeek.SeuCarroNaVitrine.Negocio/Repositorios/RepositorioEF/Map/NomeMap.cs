using DevWeek.SeuCarroNaVitrine.Negocio.NucleoCompartilhado;
using System.Data.Entity.ModelConfiguration;

namespace DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioEF.Map
{
    public class NomeMap:ComplexTypeConfiguration<Nome>
    {
        public NomeMap()
        {
            Property(nome => nome.PrimeiroNome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(100);

            Property(nome => nome.Sobrenome)
                .HasColumnType("varchar")
                .HasMaxLength(100);

        }
    }
}
