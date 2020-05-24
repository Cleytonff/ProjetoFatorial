using System;

namespace ProjetoFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto Fatorial!");
            Console.WriteLine(CalcularFatorial(5));
        }

        public static int CalcularFatorial(int n){
            int resultado = 1;
            for (int i = 2; i <= n; i++){
                resultado *= i;


            }
            return resultado;
        }
    }
}
