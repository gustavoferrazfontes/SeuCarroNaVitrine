using DevWeek.SeuCarroNaVitrine.Negocio.Comum;
using DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioNH.Map;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;

namespace DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioNH
{
    public class RepositorioBase<T> where T : Agregado
    {

        protected readonly ISessionFactory _sessionFactory;
        protected readonly ISession _session;

        public RepositorioBase()
        {
            _sessionFactory = Init();

            _session = _sessionFactory.OpenSession();

        }

        public T ObterPor(Guid id)
        {
            return _session.Load<T>(id);
        }

        private ISessionFactory Init()
        {
            return Fluently.Configure()
               .Database(MsSqlConfiguration.MsSql2012.ShowSql()
                           .ConnectionString(@"Server=.\; Database=SeuCarroNaVitrine; Integrated Security=SSPI;"))
               .Mappings(m =>
               {
                   m.FluentMappings.Add<AnuncianteMap>();
                   m.FluentMappings.Add<IdentidadeMap>();

               })

               .BuildConfiguration()
               .BuildSessionFactory();
        }



    }
}
