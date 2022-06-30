namespace ConclusaoBb
{
    class Calculadora
    {
        static void Main()
        {
            bool opcao = true;

            Console.WriteLine("Olá, irei realizar a soma de números que você deseja até você desejar parar.");

            Console.WriteLine("Digite o valor inicial");
            float.TryParse(Console.ReadLine(), out float inicial);

            while(opcao == true)
            {
                float n1;
                
                Console.WriteLine("Digite um número que deseja somar ao número inicial");
                float.TryParse(Console.ReadLine(), out n1);
                inicial = inicial + n1;
                Console.WriteLine("A soma o momento é {0}", inicial);
                Console.WriteLine("Deseja sair do programa? 1 - Sim & 2 - Não");
                int.TryParse(Console.ReadLine(), out int saida);
               
                switch(saida)
                {
                    case 1:
                        Console.WriteLine("Fechando o programa");
                        opcao = false;
                        break;
                    case 2:
                        Console.WriteLine("Continua a soma");
                        //opcao = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Retornado para a soma.");
                        break;
                }
            }
        }
    }
}