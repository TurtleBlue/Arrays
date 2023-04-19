using System;
using System.ComponentModel.Design.Serialization;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, reserva;
            string[] nomesTrabalhadores;

            Console.WriteLine("Qual quantidade de trabalhadores você deseja cadastrar?");
            i = Convert.ToInt32(Console.ReadLine());
            nomesTrabalhadores = new string [i];
            reserva = i;

            for (i = 0; i < reserva; i++)
            {
                Console.WriteLine($"Digite o nome do {i+1}º trabalhador:");
                nomesTrabalhadores[i] = Console.ReadLine();
            }
            Console.Clear();
            for (i = 0; i < reserva; i++)
            {
                Console.WriteLine($"O nome do {i+1}º trabalhador é: {nomesTrabalhadores[i]}");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}