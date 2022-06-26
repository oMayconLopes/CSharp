namespace Conversao
{
    class Numero
    {
        static void Main()
        {
            Console.WriteLine("Digite qual número é sua casa: ");
            string numeroCasa=Console.ReadLine();
            int numero=int.Parse(numeroCasa);
            Console.WriteLine("Nùmero é sua casa: {0}", numero);

            numero = Convert.ToInt32(numeroCasa);

            Console.WriteLine(numero);
        }
      

    }
}