
using DevWeek.SeuCarroNaVitrine.Negocio.DominioEF;
using System.Data.Entity.ModelConfiguration;

namespace DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioEF.Map
{
    public class ItensOpcionaisMap:ComplexTypeConfiguration<ItensOpcicionais>
    {

        public ItensOpcionaisMap()
        {

            Property(itensOp => itensOp.Itens)
                .HasColumnName("Opcionais")
                .HasColumnType("varchar")
                .HasMaxLength(300);
        }
    }
}
