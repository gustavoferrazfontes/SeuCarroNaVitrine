using DevWeek.SeuCarroNaVitrine.Negocio.DominioEF.GerenciamentoDeAnuncio;

namespace DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioEF
{
    public class AnuncioRepositorio
    {
        private readonly MeuCarroNaVitrineContext _contexto;

        public AnuncioRepositorio()
        {
            _contexto = new MeuCarroNaVitrineContext();
        }

        public void Salvar(Anuncio anuncio)
        {
            _contexto.Anuncio.Add(anuncio);
            _contexto.SaveChanges();
        }
    }
}
