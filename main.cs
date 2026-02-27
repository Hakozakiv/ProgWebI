using   System;
public class Teste
{
    static void Main()
    {
        Console.WriteLine("digite sua idade:");
        int idade = int.Parse(Console.ReadLine());
        if(idade < 0)
        {
            Console.WriteLine("idade invalida");
        }
        else if(idade >= 18)
        {
            Console.WriteLine("maior de idade");
        }
        else
        {
            Console.WriteLine("menor de idade");
        }
        Console.WriteLine(idade);
    }
}