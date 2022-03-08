using System;

namespace vogais
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string nome;
            int vogais = 0;
            int consoantes = 0;
            Console.WriteLine("Digite seu nome completo");
            nome = Console.ReadLine();
            nome = nome.ToLower();
            nome = nome.Replace(" ", "");
            for (int i = 0; i < nome.Length; i++)
            {
                
                if ((nome[i] == 'a') || (nome[i] == 'e') || (nome[i] == 'i') || (nome[i] == 'o') || (nome[i] == 'u'))
                    vogais++;

                else
                {
                    consoantes++;
                }
            }
            
            
           
                Console.WriteLine("Seu nome contém: {0} vogais", vogais);
            Console.WriteLine("Seu nome contém: {0} consoantes", consoantes);



        }
        
    }
}
