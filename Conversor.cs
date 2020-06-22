namespace Aula22Static
{
    public class Conversor
    {
        private static float CotacaoDolar = 5.23f;
        private static float CotacaoEuro = 5.91f;

        public static float RealParaDolar(float ValorRS){
            return ValorRS/ CotacaoDolar;
        }
        public static float DolarParaReal(float ValorUS){
            return ValorUS* CotacaoDolar;
        }

        public static float RealParaEuro(float ValorRS){
            return ValorRS/ CotacaoEuro;
        }
        public static float EuroParaReal(float ValorEuro){
            return ValorEuro*CotacaoEuro;
        }
    }
}