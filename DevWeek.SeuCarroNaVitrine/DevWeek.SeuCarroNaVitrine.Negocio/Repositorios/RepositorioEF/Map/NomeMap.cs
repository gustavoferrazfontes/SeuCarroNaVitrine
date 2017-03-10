using DevWeek.SeuCarroNaVitrine.Negocio.DominioEF.GerenciamentoDeAnunciante;
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
                .HasMaxLength(100)
                .IsRequired();

            Property(nome => nome.Sobrenome)
                .HasColumnName("Sobrenome")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

        }
    }
}
