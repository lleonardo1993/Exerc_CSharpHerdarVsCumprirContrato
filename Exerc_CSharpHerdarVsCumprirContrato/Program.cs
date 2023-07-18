// See https://aka.ms/new-console-template for more information

using Exerc_CSharpHerdarVsCumprirContrato.Model.Entities;
using Exerc_CSharpHerdarVsCumprirContrato.Model.Enums;

class Program
{
    static void Main(string[] args)
    {
        
        Shape s1 = new Cicle() { Radius = 2.0 , Color = Color.White};
        Shape s2 = new Retangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
        Console.WriteLine(  s1);
        Console.WriteLine(  s2);
        Console.ReadKey();
    }
}
