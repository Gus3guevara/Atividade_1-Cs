namespace AtividadesEmpresa
{
    class Atividade1
    {
        // O intuito da atividade é calcular o valor de venda de um imóvel
        // As Entradas definidas pelo supervisor Sergio Nauffal são:
        // a) Área do imóvel em metros².
        // b) Valor do metro² na região do imóvel.
        // c) Número total de quartos do imóvel.
        // d) Aluguel do imóvel (1% do valor de venda).
        // e) calcular o valor do andar do prédio.
        static double CalculoValorVendaBase(double AreaMetroQuadrado, double ValorMetroQuadradoRegiao, double TotalQuartos)
        {
            double x;
            if (TotalQuartos >= 4)
            {
                x = 4;
            }
            else
            {

                x = TotalQuartos;
            }
            double a = AreaMetroQuadrado * ValorMetroQuadradoRegiao * x;
            
            double b = (x / 2);
            double z = a / b;
            return (z);
        }
        static double CalculoAndar(int TotalAndares, int AndarImovel)
        {
            double x = AndarImovel / TotalAndares;
            double y = 1 + x;
            return y;
        }

        static double CalculoValorVendaFinal(double ValorVendaBase, double ValorAndar = 1)
        {
            return ValorVendaBase * ValorAndar;
        }

        static double CalculoValorAluguel(double ValorVendaFinal)
        {
            return ValorVendaFinal * 0.01;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite a área do imóvel em metros quadrados:");
            double AreaMetroQuadrado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do metro quadrado na região do imóvel:");
            double ValorMetroQuadrado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o número total de quartos do imóvel:");
            double TotalQuartos = Convert.ToDouble(Console.ReadLine());

            double ValorVendaBase = CalculoValorVendaBase(AreaMetroQuadrado, ValorMetroQuadrado, TotalQuartos);

            double ValorAndar = 1;

            Console.WriteLine("O imóvel está localizado em um prédio? \n 1-Sim 2-Não");
            int ConfirmaçãoPredio = Convert.ToInt32(Console.ReadLine());

            switch (ConfirmaçãoPredio)
            {
                case 1:
                    Console.WriteLine("Digite o numero total de andares no prédio:");
                    int TotalAndares = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o andar em que está o imóvel:");
                    int AndarImovel = Convert.ToInt32(Console.ReadLine());
                    ValorAndar = CalculoAndar(TotalAndares, AndarImovel);
                    break;

                case 2:
                    ValorAndar = 1;
                    break;

                default:
                    Console.WriteLine("Opção inválida. O valor considerado será o de não localizado em prédio.");
                    ValorAndar = 1;
                    break;
            }

            double ValorVendaFinal = CalculoValorVendaFinal(ValorVendaBase, ValorAndar);
            double ValorAluguel = CalculoValorAluguel(ValorVendaFinal);

            Console.WriteLine(" O valor de venda do imóvel é: " + ValorVendaFinal + "\n O valor de aluguel do imóvel é de:" + ValorAluguel);

        }
    }
}