using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region [Estrutura de repetição para escolha da atividade a ser executada.]
            int opcao;
            do
            {
                Console.WriteLine("------[Vetores]------");
                Console.WriteLine("[ 1 ] Atividade 1");
                Console.WriteLine("[ 2 ] Atividade 2");
                Console.WriteLine("[ 3 ] Atividade 3");
                Console.WriteLine("[ 4 ] Atividade 4");
                Console.WriteLine("\n");
                Console.WriteLine("------[Matrizes]------");
                Console.WriteLine("[ 5 ] Atividade 5");
                Console.WriteLine("[ 6 ] Atividade 6");
                Console.WriteLine("[ 7 ] Atividade 7");
                Console.WriteLine("\n");
                Console.WriteLine("[ 0 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("Escolha a atividade a ser executada: ");
                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        atividade1();
                        break;
                    case 2:
                        //atividade2();
                        break;
                    case 3:
                        //atividade3();
                        break;
                    case 4:
                        //atividade4();
                        break;
                    case 5:
                        //atividade5();
                        break;
                    case 6:
                        //atividade6();
                        break;
                    case 7:
                        //atividade7();
                        break;
                    default:
                        saiPrograma();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (opcao != 0);
            #endregion
        }

        #region ----Vetores----

        #region [Atividade 1]
        /// <summary>
        /// Atividade 1: Escreva um programa que armazene em um vetor todos os números inteiros de 0 a 50. 
        /// Após isso, o programa deve imprimir todos os valores armazenados.
        /// </summary>
        private static void atividade1()
        {
            Console.Clear();
            Console.Write("[Atividade 1]");
            Console.WriteLine("\n");

            int[] vetor1 = new int[51];
            for (int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = i;
                System.Console.WriteLine(vetor1[i]);
            }
        }
        #endregion

        #endregion

        private static void saiPrograma()
        {
            Console.WriteLine();
            Console.WriteLine("Você saiu do programa. Clique qualquer tecla para fechar...");
        }
    }
}
