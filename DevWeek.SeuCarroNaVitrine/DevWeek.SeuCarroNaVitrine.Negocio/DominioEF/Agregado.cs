using System;

namespace DevWeek.SeuCarroNaVitrine.Negocio.DominioEF
{
    public class Agregado : Entidade
    {
        public Agregado(Guid id) : base(id)
        {
          
        }

        public Agregado() : base(Guid.NewGuid())
        {

        }

    }
}
