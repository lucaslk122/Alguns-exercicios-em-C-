namespace ExercicioFixacao_ConversorDeMoeda
{
    public class ConversorDeMoeda
    {
        public static double Conversor(double cotacao , double compra){
            return (cotacao + (cotacao*0.06) ) * compra;
        }
    }
}