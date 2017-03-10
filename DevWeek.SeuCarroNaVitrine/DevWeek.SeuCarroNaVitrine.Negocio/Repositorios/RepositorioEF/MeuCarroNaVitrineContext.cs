using DevWeek.SeuCarroNaVitrine.Negocio.DominioEF.GerenciamentoDeAnunciante;
using DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioEF.Map;
using System.Data.Entity;

namespace DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioEF
{
    public class MeuCarroNaVitrineContext:DbContext
    {

        public MeuCarroNaVitrineContext():base(@"Server=.\; Database=SeuCarroNaVitrine; Integrated Security=SSPI;")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AnuncianteMap());
            modelBuilder.Configurations.Add(new NomeMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new EmailMap());
            modelBuilder.Configurations.Add(new TelefoneMap());


        }

        public DbSet<Anunciante> Anunciante { get; set; }
    }
}
