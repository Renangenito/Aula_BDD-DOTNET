using Aula_BDD;
using System;
using TechTalk.SpecFlow;

namespace Aula_BDD_Spec.StepDefinitions
{
    [Binding]
    public class SubtrairStepDefinitions
    {
        private readonly Calculos _calculos = new Calculos();
        private int _resultado;

        [Given(@"O primeiro numero e (.*)")]
        public void GivenOPrimeiroNumeroE(int p0)
        {
            _calculos.PrimeiroNumero = p0;
        }

        [Given(@"O segundo numero e (.*)")]
        public void GivenOSegundoNumeroE(int p0)
        {
            _calculos.SegundoNumero = p0;
        }

        [When(@"Subtraindo um numero pelo outro")]
        public void WhenSubtraindoUmNumeroPeloOutro()
        {
            _resultado = _calculos.Subtrair();
        }

        [Then(@"O resultado sera (.*)")]
        public void ThenOResultadoSera(int p0)
        {
            _resultado.Should().Be(p0);
        }
    }
}
