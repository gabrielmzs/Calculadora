namespace Calculadora.ConsoleApp {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Calculadora Top 2023\n");
            //Console.Write("Digite o número desejados de operações: ");
            //int numeroOperacoes = int.Parse(Console.ReadLine());
            //int contador = 
            //bool continua = true;

            do {

                Console.Write("Defina a o operação: 1-Somar, 2-Subtrair, 3-Multiplicar ou 4-Divisão: ");
                string operacao = Console.ReadLine();

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4") {
                    Console.WriteLine("Operação Inválida!");
                    continue;
                }

                Console.Write("Digite o primeiro número: ");
                double primeiroNumero = double.Parse(Console.ReadLine());     //  ou       int primeiroNumero = Convert.ToInt32(strPrimeiroNumero)
                Console.Write("Digite o segundo número: ");
                double segundoNumero = double.Parse(Console.ReadLine());
                double resultado = 0;


                if (operacao == "1") {
                    resultado = primeiroNumero + segundoNumero;
                    Console.WriteLine($"Resultado: {resultado}\n");
                }
                else if (operacao == "2") {
                    resultado = primeiroNumero - segundoNumero;
                    Console.WriteLine($"Resultado: {resultado} \n");
                } 
                else if (operacao == "3") {
                    resultado = primeiroNumero * segundoNumero;
                    Console.WriteLine($"Resultado: {resultado} \n");
                } 
                else if (operacao == "4") {
                    while (segundoNumero == 0) {
                        Console.Write("A divisão não pode ser por zero. Digite outro número: ");
                        segundoNumero = double.Parse(Console.ReadLine());
                        
                    }
                    resultado = primeiroNumero / segundoNumero;
                    Console.WriteLine($"Resultado: {resultado} \n");
                } 

            } while (true);

            
        }


    }
}