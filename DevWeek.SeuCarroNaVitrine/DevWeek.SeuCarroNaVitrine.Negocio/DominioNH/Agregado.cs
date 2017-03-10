using System;

namespace DevWeek.SeuCarroNaVitrine.Negocio.DominioNH
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
