
using DevWeek.SeuCarroNaVitrine.Negocio.DominioEF.GerenciamentoDeAnunciante;
using System.Data.Entity.ModelConfiguration;

namespace DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioEF.Map
{
    public class TelefoneMap : ComplexTypeConfiguration<Telefone>
    {
        public TelefoneMap()
        {


            Property(tel => tel.DDD)
                 .HasColumnName("DDDTelefoneComercial")
            .IsRequired();

            Property(tel => tel.Numero)
                 .HasColumnName("TelefoneComercial")
                 .HasColumnType("varchar")
                 .HasMaxLength(9)
                 .IsRequired();

            // Property(tel => tel.DDD)
            //     .HasColumnName("DDDTelefonePrincipal")
            //.IsRequired();

            // Property(tel => tel.Numero)
            //     .HasColumnName("TelefonePrincipal")
            //     .HasColumnType("varchar")
            //     .HasMaxLength(9)
            //     .IsRequired();


        }
    }
}
