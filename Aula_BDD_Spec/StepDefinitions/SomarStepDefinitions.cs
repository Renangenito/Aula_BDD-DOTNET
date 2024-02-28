using Aula_BDD;
using System;
using TechTalk.SpecFlow;

namespace Aula_BDD_Spec.StepDefinitions
{
    [Binding]
    public class SomarStepDefinitions
    {
        private readonly Calculos _calculos = new Calculos();
        private int _resultado;

        [Given(@"O primeiro numero é (.*)")]
        public void GivenOPrimeiroNumeroE(int p0)
        {
            _calculos.PrimeiroNumero = p0;
        }
        [Given(@"O segundo numero é (.*)")]
        public void GivenOSegundoNumeroE(int p0)
        {
            _calculos.SegundoNumero = p0;
        }

        [When(@"Somados os dois numeros")]
        public void WhenSomadosOsDoisNumeros()
        {
                _resultado = _calculos.Somar();
        }

        [Then(@"O resultado deve ser (.*)")]
        public void ThenOResultadoDeveSer(int p0)
        {
                _resultado.Should().Be(p0);
        }
    }
}
