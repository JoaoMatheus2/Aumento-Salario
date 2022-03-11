using System;

namespace ConsoleApp1 
{
    class Program 
    {
        static void Main(String[] args) 
        {
            double salario; 
            double percentual;
            double aumentoSalario;
            double salarioAumentado;
            
            Console.WriteLine("Qual o seu salário atual?");
            salario =  double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o percentual do aumento do seu salario?");
            percentual = double.Parse(Console.ReadLine());
            
            aumentoSalario = (salario * percentual) / 100;
            salarioAumentado = salario + aumentoSalario;
            
            Console.WriteLine("Seu novo salario é de R$ " + salarioAumentado);
        }
    }
}