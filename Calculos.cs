using System;

namespace Myapp
{

public class aula12
{
    public static void Main()
    
    {
    
     string nome;
     int numero1, numero2, numero3, soma, produtorio;
     double media;
     
     Console.WriteLine("Digite seu nome: ");
     Console.ReadLine();
     
     Console.WriteLine("Digite o numero 1: ");
     numero1 = int.Parse(Console.ReadLine());
     
     Console.WriteLine("Digite o numero 2: ");
     numero2 = int.Parse(Console.ReadLine());
     
     Console.WriteLine("Digite o numero 3: ");
     numero3 = int.Parse(Console.ReadLine());
     
     
    //Calculos
     
     media = (numero1 + numero2 + numero3) /3;
     soma = numero1 + numero2 + numero3;
     produtorio = (numero1 * numero2) * numero3;
     
     Console.WriteLine($"A media aritimetica dos numeros digitados e {media}");
     Console.WriteLine($"A soma dos numeros digitados e {soma}");
     Console.WriteLine($"O produtorio dos numeros digitados e {produtorio}");


    }
    
}


}
