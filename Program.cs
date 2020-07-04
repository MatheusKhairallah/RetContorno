using System;

namespace RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Altura e Largura de retângulo entre 1 e 10");
            Console.Write("Digite a largura: ");
            int largura=Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a altura: ");
            int altura=Convert.ToInt32(Console.ReadLine());

            int valor1=1;
            int valor2=1;
            
            
        
            while ( valor1<=altura )
            {
                while (valor2 <=largura )
                {
                    if (valor2==1 || valor2==largura || valor1==1 || valor1==altura)
                    {
                       Console.Write("* "); 
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    valor2++;
                }
                valor2=1;
                Console.WriteLine();
                valor1++;
            }
            
        }
    }
}
