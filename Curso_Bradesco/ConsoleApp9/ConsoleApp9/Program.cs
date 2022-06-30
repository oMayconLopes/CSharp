Console.WriteLine("Informe um número para iniciar o contator");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe um número que o contador irá concluir");
int num2 = int.Parse(Console.ReadLine());

while (num1 <= num2)
{
    Console.WriteLine(num1);
    num1++;
}
