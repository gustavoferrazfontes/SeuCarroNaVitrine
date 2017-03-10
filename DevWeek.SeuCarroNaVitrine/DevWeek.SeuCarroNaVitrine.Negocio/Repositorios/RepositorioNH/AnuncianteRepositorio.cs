using DevWeek.SeuCarroNaVitrine.Negocio.DominioNH.GerenciamentoDeAnunciante;

namespace DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioNH
{
    public class AnuncianteRepositorio:RepositorioBase<Anunciante>
    {
        public void Salvar(Anunciante novoAnunciante)
        {
            using (var tran = _session.BeginTransaction())
            {
                _session.Save(novoAnunciante);
                _session.Flush();
                tran.Commit();
            }
        }
    }
}
