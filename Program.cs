using System;

namespace Criança_Educada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            String frase, crianca;
            
            Console.WriteLine("Me diga o que você pensa sobre o aluno que não faz a licao de casa");
            Console.WriteLine("eu acho que e um bobo, e que vai ficar boboca pra sempre");
            Console.WriteLine("Eu sou uma crianca educada. No seu lugar eu diria:"); 
            frase = Console.ReadLine();
            crianca = frase.Replace("chato", "#@$%*!&").Replace("burro", "#@$%*!&");
            Console.WriteLine($"Texto Crianca: {crianca}"); 


        }
    }
}
