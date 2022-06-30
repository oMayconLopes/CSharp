namespace CursoBasico
{
    class CSharop
    {
        static void Main()
        {
            float media;
            //float nota1, nota2, nota3, nota4;

            Console.WriteLine("Informe a sua 1 nota: ");
            int.TryParse(Console.ReadLine(), out int nota1);
            Console.WriteLine("Informe a sua 2 nota: ");
            int.TryParse(Console.ReadLine(), out int nota2);
            Console.WriteLine("Informe a sua 3 nota: ");
            int.TryParse(Console.ReadLine(), out int nota3);
            Console.WriteLine("Informe a sua 4 nota: ");
            int.TryParse(Console.ReadLine(), out int nota4);

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            //Console.WriteLine("A sua media foi de {0}", media);

            if (media >= 7.0)
            {
                if (media == 10)
                {
                    Console.WriteLine("Parabens, voce obteve uma media de {0}", media);
                }
                Console.WriteLine("Voce foi aprovado!");
                Console.WriteLine("Com media de {0}", media);
            }
            else
            {
                Console.WriteLine("Voce foi reprovado!");
                Console.WriteLine("Com media de {0}", media);
            }



        }
    }

}