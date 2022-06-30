namespace notas
{
    class validacao
    {
        static void Main()
        {
            double nota1 = 8;
            double nota2 = 9.6;

            Console.WriteLine("Nota maior que 7? {0}", nota1 > 7.0);
            Console.WriteLine("TIrou 10? {0}", nota2 == 10);
        }
    }
}