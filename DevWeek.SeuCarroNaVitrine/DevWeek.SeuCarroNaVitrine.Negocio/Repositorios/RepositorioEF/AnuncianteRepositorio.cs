using DevWeek.SeuCarroNaVitrine.Negocio.Comum;
using DevWeek.SeuCarroNaVitrine.Negocio.DominioEF.GerenciamentoDeAnunciante;
using System.Linq;

namespace DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioEF
{
    public class AnuncianteRepositorio
    {
        private readonly MeuCarroNaVitrineContext _contexto;

        public AnuncianteRepositorio()
        {
            _contexto = new MeuCarroNaVitrineContext();
        }

        public Anunciante ObterPor(Identidade Id)
        {
            return _contexto.Anunciante.FirstOrDefault(anunciante => anunciante.Id == Id);
        }

        public void Salvar(Anunciante anunciante)
        {
            _contexto.Anunciante.Add(anunciante);
            _contexto.SaveChanges();
        }
    }
}
