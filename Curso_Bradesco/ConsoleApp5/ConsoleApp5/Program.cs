﻿namespace nome
{
    class nomeIdade
    {
        static void Main()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome=Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int idade=int.Parse(Console.ReadLine());

            Console.WriteLine("Seu nome é {0} e sua idade é {1}", nome, idade);
        }
    }
}