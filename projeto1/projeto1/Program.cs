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
                        atividade2();
                        break;
                    case 3:
                        atividade3();
                        break;
                    case 4:
                        atividade4();
                        break;
                    case 5:
                        atividade5();
                        break;
                    case 6:
                        atividade6();
                        break;
                    case 7:
                        atividade7();
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

        #region [Atividade 2]
        /// <summary>
        /// Atividade 2: Escreva um programa que armazene em um vetor todos os números pares do intervalo fechado de 1 a 100. 
        /// Após isso, o programa deve imprimir todos os valores armazenados.
        /// </summary>
        private static void atividade2()
        {
            Console.Clear();
            Console.Write("[Atividade 2]");
            Console.WriteLine("\n");

            int[] vetor2 = new int[101];
            for (int i = 1; i < vetor2.Length; i++)
            {
                if (i % 2 == 0 && i > 0)
                {
                    vetor2[i] = i;
                    System.Console.WriteLine(vetor2[i]);
                }
            }
        }
        #endregion

        #region [Atividade 3]
        /// <summary>
        /// Atividade 3: Escreva um programa que armazene em um vetor os 100 primeiros números ímpares. 
        /// Após isso, o programa deve imprimir todos os valores armazenados.
        /// </summary>
        private static void atividade3()
        {
            Console.Clear();
            Console.Write("[Atividade 3]");
            Console.WriteLine("\n");

            int count = 1;
            int[] vetorDeImpares = new int[200];
            for (int i = 0; i <= vetorDeImpares.Length; i++)
            {
                if (i % 2 != 0)
                {
                    vetorDeImpares[i] = i;
                    Console.WriteLine("{0}º número ímpar: {1}", count, vetorDeImpares[i]);
                    count++;
                }
            }
        }
        #endregion

        #region [Atividade 4]
        /// <summary>
        /// Atividade 4: Escreva um programa que receba dez números do usuário e armazene em um vetor a metade de cada número.
        /// Após isso, o programa deve imprimir todos os valores armazenados.
        /// </summary>
        public static void atividade4()
        {
            Console.Clear();
            Console.Write("[Atividade 4]");
            Console.WriteLine("\n");

            double[] numerosUsuario = new double[10];
            double metade = 0;
            int count = 1;
            for (int i = 0; i < numerosUsuario.Length; i++)
            {
                System.Console.WriteLine("Digite o {0}º número: ", count);
                numerosUsuario[i] = Int32.Parse(Console.ReadLine());
                count++;
                metade = numerosUsuario[i] / 2;
                System.Console.WriteLine("Metade: {0}", metade);
                Console.WriteLine("\n");
            }
        }
        #endregion

        #endregion

        #region ----Matrizes----

        #region [Atividade 5]
        /// <summary>
        /// Atividade 5: Escreva um programa que entre com valores para uma matriz M(5x5) e imprima a matriz final, 
        /// como exemplo mostrado abaixo:
        /// </summary>
        /// 1  2  3  4  5
        /// 6  7  8  9  10
        /// 11 12 13 14 15
        /// 16 17 18 19 20
        /// 21 22 23 24 25
        public static void atividade5()
        {
            Console.Clear();
            Console.Write("[Atividade 5]");
            Console.WriteLine("\n");

            int linhas = 5;
            int colunas = 5;
            int i, j;
            int[,] matriz = new int[linhas, colunas];
            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; j++)
                {
                    Console.WriteLine("Entre com o valor para a matriz na posição (linha, coluna): ({0},{1})", i, j);
                    matriz[i, j] = Int32.Parse(Console.ReadLine());
                    //matriz[i, j] = i;
                }
            }
            Console.Write("-------------------------------------");
            Console.WriteLine("\n");
            Console.Write("A matriz gerada foi: ");
            Console.WriteLine("\n");
            // Console.WriteLine(matriz[i, j]);
            // ---------------- OUTRO FOR PRA IMPRIMIR ----------------
            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; j++)
                {
                    Console.Write("    {0}", matriz[i, j]);
                }
                Console.Write("\n");
            }
        }
        #endregion

        #region [Atividade 6]
        /// <summary>
        /// Atividade 6: Entrar com valores inteiros para um matriz A(4x4) e para uma matriz B(4x4). 
        /// Gerar e imprimir uma outra matriz com a SOMA(A+B).
        /// </summary>
        public static void atividade6()
        {
            Console.Clear();
            Console.Write("[Atividade 6]");
            Console.WriteLine("\n");

            int linhas = 4;
            int colunas = 4;
            int[,] matrizA = new int[linhas, colunas];
            int[,] matrizB = new int[linhas, colunas];
            int[,] matrizAB = new int[linhas, colunas];
            int i, j;

            //preenche a matriz A e já passa o valor pra matrizAB
            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; j++)
                {
                    System.Console.WriteLine("Entre com o valor para a matriz A na posição (linha, coluna): ({0},{1})", i, j);
                    //matrizA[i, j] = Int32.Parse(Console.ReadLine());
                    matrizA[i, j] = i;
                    matrizAB[i, j] = matrizA[i, j];
                }
            }

            //preenche a matriz B e já soma com o que tá na matrizAB
            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; j++)
                {
                    System.Console.WriteLine("Entre com o valor para a matriz B na posição (linha, coluna): ({0},{1})", i, j);
                    //matrizB[i, j] = Int32.Parse(Console.ReadLine());
                    matrizB[i, j] = i;
                    matrizAB[i, j] += matrizB[i, j];
                }
            }
            //matrizAB[i, j] = matrizA[i, j] + matrizB[i, j]; // acho que esse cálculo não pode ser feito externamente

            //imprime a matrizAB
            Console.Write("-------------------------------------");
            Console.WriteLine("\n");
            Console.Write("A matriz SOMA é: ");
            Console.WriteLine("\n");
            for (i = 0; i < linhas; i++)
            {
                for (j = 0; j < colunas; i++)
                {
                    Console.Write("    {0}", matrizAB[i, j]);
                }
                Console.WriteLine("\n");
            }
        }
        #endregion

        #region [Atividade 7]
        /// <summary>
        /// Atividade 7: Criar um programa que carregue uma matriz 12 x 4 com os valores das vendas de uma loja, 
        /// em que cada linha represente um mês do ano, e cada coluna, uma semana do mês. 
        /// </summary>
        /// Para fins de simplificação considere que cada mês possui somente 4 semanas. Calcule e imprima: 
        /// - Total vendido em cada mês do ano; 
        /// - Total vendido em cada semana durante todo o ano; 
        /// - Total vendido no ano.
        public static void atividade7()
        {
            Console.Clear();
            Console.Write("[Atividade 7]");
            Console.WriteLine("\n");

            int linhas = 12;
            int colunas = 4;
            int[,] matrizVendas = new int[linhas, colunas];
            int totalGeral = 0;
            for (int i = 0; i < linhas; i++)
            {
                int totalMes = 0;
                for (int j = 0; j < colunas; j++)
                {
                    System.Console.WriteLine("Entre com o valor da venda da semana (linha, coluna): ({0},{1})", i, j);
                    matrizVendas[i, j] = Int32.Parse(Console.ReadLine());
                    //matrizVendas[i, j] = i;
                    totalMes = totalMes + matrizVendas[i, j]; // - Total vendido em cada mês do ano;
                    totalGeral = totalGeral + matrizVendas[i, j];
                }
                //Console.WriteLine("Total vendido em cada mês do ano: ");
                Console.WriteLine("\n");
                Console.WriteLine("Total vendido no mês {0} foi de R$ {1}", i + 1, totalMes);
                Console.WriteLine("\n");
            }


            // - Total vendido em cada semana durante todo o ano; 
            Console.WriteLine("Total vendido em cada semana durante todo o ano: ");
            Console.WriteLine("\n");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write("    {0}", matrizVendas[i, j]);
                }
                Console.WriteLine("\n");

            }

            // - Total vendido no ano.
            Console.WriteLine("Total vendido em todo o ano foi de: R$ {0}", totalGeral);

        }
        #endregion

        #endregion

        #region para fechar o programa

        private static void saiPrograma()
        {
            Console.WriteLine();
            Console.WriteLine("Você saiu do programa. Clique qualquer tecla para fechar...");
        } 
        #endregion
    }
}
