namespace mesa_de_trabalho
{
    public class Atividade07
    {
        public double cotacaoDoDolarHoje = 4.97;
        public const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
        public const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;
        public double valorDaCompraEmReais;
        public double valorDaCompraEmDolar;

        public void Inicio()
        {
            PegarValorDaCompra();
            converterRealParaDolar(valorDaCompraEmReais, cotacaoDoDolarHoje);
            AvaliarACompra();
        }
        public void converterRealParaDolar(double valorDaCompraEmReais, double cotacaoDoDolarHoje)
        {
            valorDaCompraEmDolar = valorDaCompraEmReais / cotacaoDoDolarHoje;
        }
        public void PegarValorDaCompra()
        {
            Console.WriteLine("Digite o valor da compra: ");
            valorDaCompraEmReais = double.Parse(Console.ReadLine());
        }
        public void AvaliarACompra()
        {
            if (valorDaCompraEmDolar < VALOR_MINIMO_DE_COMPRA_EM_DOLAR)
            {
                Console.WriteLine($"A compra mínima permitida é de $ {VALOR_MINIMO_DE_COMPRA_EM_DOLAR}");
            }
            else if (valorDaCompraEmDolar > VALOR_MAXIMO_DE_COMPRA_EM_DOLAR)
            {
                Console.WriteLine($"A compra máxima permitida é de $ {VALOR_MAXIMO_DE_COMPRA_EM_DOLAR}");
            }
            else
            {
                Console.WriteLine($"Você pode comprar $ {valorDaCompraEmDolar.ToString("N2")}");
            }
        }
    }



/*
    internal class Atividade07
    {
        public void Inicio()
        {

        }
    }*/
}