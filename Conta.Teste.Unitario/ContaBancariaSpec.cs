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
    
            var conta = new ContaBancaria(banco, numeroconta, agencia, cpf, nome, string.Empty, string.Empty, dataAbertura);

            conta.Should().NotBeNull();
            conta.NumeroConta.Should().Be(numeroconta);
            conta.NumeroAgencia.Should().Be(agencia);
            conta.Cpf.Should().Be(cpf);
            conta.Nome.Should().Be(nome);
            conta.Cnpj.Should().Be(string.Empty);
            conta.RazaoSocial.Should().Be(string.Empty);
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

            var conta = new ContaBancaria(banco, numeroconta, agencia, string.Empty, string.Empty, cnpj, razaosocial, dataAbertura);

            conta.Should().NotBeNull();
            conta.NumeroConta.Should().Be(numeroconta);
            conta.NumeroAgencia.Should().Be(agencia);
            conta.Cpf.Should().Be(string.Empty);
            conta.Nome.Should().Be(string.Empty);
            conta.Cnpj.Should().Be(cnpj);
            conta.RazaoSocial.Should().Be(razaosocial);
            conta.DataAbertura.Should().Be(dataAbertura);
        }

    }
}