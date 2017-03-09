using DevWeek.SeuCarroNaVitrine.Negocio.NucleoCompartilhado;
using System.Data.Entity.ModelConfiguration;

namespace DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioEF.Map
{
    public class EnderecoMap:ComplexTypeConfiguration<Endereco>
    {
        public EnderecoMap()
        {

            Property(endereco => endereco.Cidade)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            Property(endereco => endereco.Bairro)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            Property(endereco => endereco.Cep);

            Property(endereco => endereco.Logradouro)
                .HasColumnType("varchar")
                .HasMaxLength(100);

        }
    }
}
