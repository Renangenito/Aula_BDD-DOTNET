namespace Aula_BDD
{
    public class Calculos
    {
        public int PrimeiroNumero { get; set; }
        public int SegundoNumero { get; set; }

        public int Somar()
        {
            return PrimeiroNumero + SegundoNumero;
        }
        public int Subtrair()
        {
            return PrimeiroNumero - SegundoNumero;
        }
    }
}