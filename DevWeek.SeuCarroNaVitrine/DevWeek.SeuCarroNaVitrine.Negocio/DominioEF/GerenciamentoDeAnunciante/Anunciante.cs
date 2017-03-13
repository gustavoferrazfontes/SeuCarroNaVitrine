using System;

namespace DevWeek.SeuCarroNaVitrine.Negocio.DominioEF.GerenciamentoDeAnunciante
{
    public class Anunciante : Agregado
    {
      

        public Nome Nome { get; }
        public Endereco Endereco { get; private set; }
        public Email Email { get; private set; }
        public Telefone TelefonePrincipal { get; private set; }
        public Telefone TelefoneComercial { get; private set; }
        public Telefone TelefoneCelular { get; private set; }

        public Anunciante(Guid id, Nome nome, Endereco endereco, Email email,Telefone celular, Telefone comercial, Telefone principal): base(id)
        {
            if (nome == null)
                throw new InvalidOperationException("O Nome do proprietário é obrigatório");

            if (endereco == null)
                throw new InvalidOperationException("O Endereço do proprietário é obrigatório");

            if (email == null)
                throw new InvalidOperationException("O Email do proprietário é obrigatório");

            if (celular == null )
                throw new InvalidOperationException("Telefone celular é obrigatório");

            if (principal == null)
                throw new InvalidOperationException("Telefone principal é obrigatório");

            if (comercial == null)
                throw new InvalidOperationException("Telefone comercial é obrigatório");

            Nome = nome;
            Email = email;
            Endereco = endereco;
            TelefoneCelular = celular;
            TelefoneComercial = comercial; 
        }

        public void AlterarEmail(Email novoEmail)
        {
            Email = novoEmail;
        }
    }
}