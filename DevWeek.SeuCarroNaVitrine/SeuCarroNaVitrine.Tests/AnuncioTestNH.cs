using DevWeek.SeuCarroNaVitrine.Negocio.DominioNH.GerenciamentoDeAnuncio;
using DevWeek.SeuCarroNaVitrine.Negocio.NucleoCompartilhado;
using DevWeek.SeuCarroNaVitrine.Negocio.NucleoCompartilhado.Enums;
using DevWeek.SeuCarroNaVitrine.Negocio.Repositorios.RepositorioNH;
using System;
using Xunit;

namespace SeuCarroNaVitrine.Tests
{
    public class AnuncioTestNH
    {
        private readonly AnuncioRepositorio _repositorio;
        public AnuncioTestNH()
        {
            _repositorio = new AnuncioRepositorio();
        }

        [Fact]
        public void SalvarUmNovoAnuncioTest()
        {
            var identidadeDoAnuncio = Guid.NewGuid();
            var idAnunciante = Guid.Parse("71789850-77F1-47A2-B60C-A734011911D2");
            var periodo = Periodo.Novo(DateTime.Now, DateTime.Now.AddDays(10));

            var identidadeDoVeiculo = Guid.NewGuid();
            var detalheDeFabricacao = DetalheDeFabricacao.Novo("Honda", "Civic", 2010, 2010);
            var opcionais = ItensOpcicionais.Novo("trava, vidro,alarme, airbag,kit multimidia,ABS");


            var detalheDoVeiculo = DetalheDoVeiculo.Novo
                (
                    "ABC1234",
                    50000,
                    TipoDoCambio.Automatico,
                    TipoDaCarroceria.Sedan,
                    Cor.Branco,
                    TipoDeCombustivel.Flex,
                    4,
                    30.500m);

            
            var veiculo = new Veiculo(identidadeDoAnuncio, detalheDeFabricacao, opcionais, detalheDoVeiculo);

            var novoAnuncio = new Anuncio(identidadeDoAnuncio, idAnunciante, periodo, veiculo);

            var iqual = novoAnuncio == veiculo;

            _repositorio.Salvar(novoAnuncio);
        }
    }
}
