﻿using DevWeek.SeuCarroNaVitrine.Negocio.DominioNH;
using DevWeek.SeuCarroNaVitrine.Negocio.DominioNH.GerenciamentoDeAnunciante;
using DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioNH;
using FluentAssertions;
using System;
using Xunit;

namespace SeuCarroNaVitrine.Tests
{
    public class AnuncianteTestNH
    {
        private readonly AnuncianteRepositorio _repositorio;

        public AnuncianteTestNH()
        {
            _repositorio = new AnuncianteRepositorio();
        }

        [Fact()]
        public void PersistirUmNovoAnuncianteTest()
        {
            var identidade = Guid.NewGuid();
            var nome = Nome.Novo("Gustavo", "Fontes");
            var endereco = Endereco.Novo("Av. paulista", "Jardins", "São Paulo", "SP", 012345678);
            var email = Email.Novo("gustavo.fontes@gmail.com");
            var agendaTelefonica = AgendaTelefonica
                .Nova(
                        Telefone.Novo(11, "12345678"),
                        Telefone.Novo(11, "12345678"),
                        Telefone.Novo(11, "123456789")
                        );

            var novoAnunciante = new Anunciante(identidade, nome, endereco, email, agendaTelefonica);

            _repositorio.Salvar(novoAnunciante);

            var anunciante = _repositorio.ObterPor(identidade);

            anunciante.Should().NotBeNull();
        }


    }
}
