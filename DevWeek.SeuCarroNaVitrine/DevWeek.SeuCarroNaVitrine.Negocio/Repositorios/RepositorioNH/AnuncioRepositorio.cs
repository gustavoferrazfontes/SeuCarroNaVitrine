using DevWeek.SeuCarroNaVitrine.Negocio.DominioNH.GerenciamentoDeAnuncio;

namespace DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioNH
{
    public class AnuncioRepositorio:RepositorioBase<Anuncio>
    {
        public void Salvar(Anuncio novoAnuncio)
        {
            using (var tran = _session.BeginTransaction())
            {
                _session.Save(novoAnuncio);
               // _session.Flush();
                tran.Commit();
            }
        }
    }
}
