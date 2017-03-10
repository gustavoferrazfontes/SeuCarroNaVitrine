using DevWeek.SeuCarroNaVitrine.Negocio.Comum;
using System;
using System.Linq.Expressions;

namespace DevWeek.SeuCarroNaVitrine.Negocio.DominioEF.GerenciamentoDeAnunciante
{
    public class Anunciante : Agregado
    {
        public static Expression<Func<Anunciante, Guid>>  IdentidadeExpression = f => f.IdInterno;
        private Guid IdInterno { get { return Id.Id; } set { } }
        public Nome Nome { get; }
        public Endereco Endereco { get; private set; }
        public Email Email { get; private set; }
        public AgendaTelefonica AgendaTelefonica { get; }
        
        public Anunciante(Identidade id, Nome nome, Endereco endereco, Email email,
            AgendaTelefonica agendaTelefonica): base(id)
        {
            if (nome == null)
                throw new InvalidOperationException("O Nome do proprietário é obrigatório");

            if (endereco == null)
                throw new InvalidOperationException("O Endereço do proprietário é obrigatório");

            if (email == null)
                throw new InvalidOperationException("O Email do proprietário é obrigatório");

            if (agendaTelefonica == null)
                throw new InvalidOperationException("A Agenda Telefônica do proprietário é obrigatória");

            Nome = nome;
            Email = email;
            Endereco = endereco;
            AgendaTelefonica = agendaTelefonica;
        }

        public void AlterarEmail(Email novoEmail)
        {
            Email = novoEmail;
        }
    }
}