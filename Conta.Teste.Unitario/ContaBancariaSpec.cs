using Conta.Dominio.Entidade;
using FluentAssertions;
using System;
using Xunit;

namespace Conta.Teste.Unitario
{
    public class ContaBancariaSpec
    {
        [Fact]
        public void DeveInstanciarContaPessoaFisica()
        {
            string codigoBanco = "1";
            string descricaoBanco = "Bradesco";
            var banco = new Banco(codigoBanco, descricaoBanco);

            var numeroconta = "0250987-1";
            var agencia = "1239";
            var cpf = "847.557.360-64";
            var nome = "Jussara Magalhães da Silva";
            DateTime dataAbertura = new DateTime(2021, 01, 18);
    
            var conta = new ContaBancaria();

            conta.CriarContaPessoaFisica(banco, numeroconta, agencia, cpf, nome, dataAbertura);

            conta.Should().NotBeNull();
            conta.NumeroConta.Should().Be(numeroconta);
            conta.NumeroAgencia.Should().Be(agencia);
            conta.Cpf.Should().Be(cpf);
            conta.Nome.Should().Be(nome);
            conta.DataAbertura.Should().Be(dataAbertura);
           
        }

        [Fact]
        public void DeveInstanciarContaPessoaJuridica()
        {
            string codigoBanco = "1";
            string descricaoBanco = "Bradesco";
            var banco = new Banco(codigoBanco, descricaoBanco);

            var numeroconta = "0250987-1";
            var agencia = "1239";
            var cnpj = "52.364.460/0001-00";
            var razaosocial = "MegaWork SA";
            DateTime dataAbertura = new DateTime(2021, 01, 18);

            var conta = new ContaBancaria();

            conta.CriarContaPessoaJuridica(banco, numeroconta, agencia, cnpj, razaosocial, dataAbertura);

            conta.Should().NotBeNull();
            conta.NumeroConta.Should().Be(numeroconta);
            conta.NumeroAgencia.Should().Be(agencia);
            conta.Cnpj.Should().Be(cnpj);
            conta.RazaoSocial.Should().Be(razaosocial);
            conta.DataAbertura.Should().Be(dataAbertura);
        }

    }
}