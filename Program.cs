using System;
using System.Collections.Generic;

namespace dotnetcore
{
    class Program
    {
        // Exercício 1:
        // - Fazer a média de notas dos dois alunos (Zuqui, Bronza) e imprimir no Console.WriteLine();
        // - Imprimir no console para cada aluno
        //      - Nome do aluno
        //      - Caso média maior ou igual 7:
        //          - Passou no ano letivo
        //          - Não passou no ano letivo
        // Requisítos:
        // - Criar um método "CalcularMedia", onde a entrada de parâmetros seja as notas e o retorno seja a média em float
        // - Utilizar For ou Foreach


        // Exercício 2:
        // - Fazer um programa que cadastre pessoas, contendo nome e idade;
        // - Imprimir a media de idade das pessoas
        // - Imprimir o nome e idade da pessoa mais velha
        // - Imprimir o nome e idade da pessoa mais nova
        // - Imprimir a quantidade de pessoas com maior idade
        // Requisítos:
        // - Utilizar List (Avg, Max, Min, Where)
        // - Utilizar Classe Pessoa

        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Programa");

            var xNotasZuqui = new List<int> { 7, 6, 5, 3 };
            var xNotasBronza = new List<int> { 8, 9, 10, 8 };
            
            var xMediaZuqui = CalcularMedia(xNotasZuqui);
            Console.WriteLine($"Media Zuqui {xMediaZuqui} " + IsAprovado(xMediaZuqui));
            
            
            var xMediaBronza = CalcularMedia(xNotasBronza);
            Console.WriteLine($"Nota Bronza {xMediaBronza} " + IsAprovado(xMediaBronza));

        }
        static float CalcularMedia(List<int> notas)
        {
            var total = 0;

            foreach(var nota in notas)
            {
                total += nota;
            }
            return total / notas.Count;
        }

        static string IsAprovado(float media)
        {
            if(media < 7)
            {
                return "Reprovado";
            }
            else
            {
                return "Aprovado";
            }
        }
    }
}
