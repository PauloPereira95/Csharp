using System.Runtime.Serialization.Formatters;

namespace c_exe_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exeFicArrayBiDois();
            exeFicArrayBiTres();
        }
        static void exeFicArrayBiDois()
        {
            int[,] matriz = new int[4, 4];
            int sum = 0, min = matriz[0, 0], max = matriz[0, 0], neg = 0, pos = 0, zero = 0;
            double media = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = gerarValores();
                    // Pergunta 2.1
                    sum += matriz[i, j];
                    //-----------------

                    // Pergunta 2.2
                    if (matriz[i, j] < min)
                        min = matriz[i, j];
                    else if (matriz[i, j] > max)
                        max = matriz[i, j];
                    //---------------------
                    // Pergunta 2.3
                    if (matriz[i, j] == 0)
                        zero++;
                    else if (matriz[i, j] > 0)
                        pos++;
                    else
                        neg++;
                    //------------------
                }
            }
            media = (double)sum / matriz.Length;
            Console.WriteLine("\nValores definidos:\n");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]}\t");
                }
                Console.WriteLine();
            }
            // Pergunta 2.4
            Console.WriteLine("\nDiagonal Principal\n");
            for (int i = 0; i < matriz.GetLength(0); i++) // coluna
            {
                        Console.Write($"{matriz[i,i]}\t");
   
            }
            // Pergunta 2.5
            Console.WriteLine("\n Diagonal Secundária");
            // percorre o array
            //o método GetLength permite obter o número de elementos em cada dimensão:
            //  0 para o número de linhas
            //  1 para o número de colunas

            /* for (int i = 0; i < matriz.GetLength(0); i++)
             {
                 for (int j = 0; j < matriz.GetLength(1); j++)
                 {

                     if (i != j && i + j == (matriz.GetLength(0) - 1)) //(matriz.GetLength(0) - 1) porque o
                                                                       //array começa em 0 e o metodo em começa com 1
                         Console.Write($"{matriz[i, j]}\t");
                     else
                         Console.Write("\t");

                 }
                 Console.WriteLine(" ");
             }------------------OU-------------------------------------------*/
            int k = matriz.GetLength(0) -1;
            int l = 0;
            do
            {
                Console.WriteLine(matriz[k,l]);
                k--;
                l++;
            } while ( k>= 0 && l <= matriz.GetLength(0) - 1);
            Console.WriteLine();
            Console.WriteLine($"Soma ->{sum} || Media -> {Math.Round(media, 2)}");
            Console.WriteLine($"Minimo -> {min} || Maximo -> {max}");
            Console.WriteLine($"Neg -> {neg} || Pos -> {pos} || Zeros -> {zero}");
            //------------------------------------------------------------------------  
            //------------------------------OU-(cOM O CICLO FOR)----------------------
            Console.WriteLine("--- Diagonal Sec com for --------------");
            for (int i =0;i < matriz.GetLength(0);i++)
            {
                Console.WriteLine($"{matriz[i, (matriz.GetLength(0)-1) - i]}");
            }
            Console.WriteLine("\n\n");
        //------------------------------------------------------------------------
        }
        static void exeFicArrayBiTres()
        {
            int somaMatrizUm = 0, somaMatrizDois = 0,
                negUm = 0, posUm = 0, zeroUm = 0, negDois = 0, posDois = 0, zeroDois = 0;
            double avgMatrizUm = 0, avgMatrizDois = 0;
            int[,] matrizUm = new int[3, 3];
            int[,] matrizDois = new int[3, 3];
            int[] arraySoma = new int[2];
            int[,] arrayTemp = new int[3, 3];
            // insere valores no primeiro e segundo array
            for (int i = 0; i < matrizUm.GetLength(0); i++)
            {
                for (int j = 0; j < matrizUm.GetLength(1); j++)
                {
                    matrizUm[i, j] = gerarValores();
                    matrizDois[i, j] = gerarValores();
                }
            }
            // mostra os valores do primeiro array
            Console.WriteLine("-----Matriz Um----");
            for (int i = 0; i < matrizUm.GetLength(0); i++)
            {
                for (int j = 0; j < matrizUm.GetLength(1); j++)
                {
                    somaMatrizUm += matrizUm[i, j];

                    if (matrizUm[i, j] < 0)
                        negUm++;

                    Console.Write($"{matrizUm[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----Matriz Dois----");
            // mostra valores do segundo array
            for (int i = 0; i < matrizDois.GetLength(0); i++)
            {
                for (int j = 0; j < matrizDois.GetLength(1); j++)
                {
                    somaMatrizDois += matrizDois[i, j];
                    if (matrizDois[i, j] < 0)
                        negDois++;
                    Console.Write($"{matrizDois[i, j]}\t");
                }
                Console.WriteLine();
            }
            // calc/compara medias e ve a mais alta

            // tem que ter o double para converter o int em double nesta operação
            //caso contrario vai apenas dar a parte inteira da divisao
            avgMatrizUm = (double)somaMatrizUm / matrizUm.Length;
            avgMatrizDois = (double)somaMatrizDois / matrizDois.Length;

            // compara para ver quem tem a media mais alta
            if (avgMatrizUm > avgMatrizDois)
                Console.WriteLine($"A Matriz Um é quem tem a media mais alta. {Math.Round(avgMatrizUm, 2)}");
            else if (avgMatrizUm < avgMatrizDois)
                Console.WriteLine($"A Matriz Dois é quem tem a media mais alta. {Math.Round(avgMatrizDois, 2)}");
            else
                Console.WriteLine("As duas matrzies tem exatamente a mesma media !");

            // compara para ver quem tem mais negativos
            if (negUm > negDois)
                Console.WriteLine($"Quem tem mais negativos é a Matriz Um. {negUm}");
            else if (negUm < negDois)
                Console.WriteLine($"Quem tem mais negativos é a Matriz Dois. {negDois}");
            else Console.WriteLine("Os duas matrizes tem o mesmo numero de negativos !");

            // Guarda a Soma de Cada array no Terceiro Array
            arraySoma[0] = somaMatrizUm;
            arraySoma[1] = somaMatrizDois;

            // Mostra o terceiro aRray com as somas
            foreach (int valor in arraySoma)
            {

                Console.Write($"Total Soma {valor}\n\t");
                Console.WriteLine("------");
            }
            // trocar valores dos arrays Um para o Temporario para o Um poder Receber do Array Dois
            for (int i = 0; i < matrizUm.GetLength(0); i++) // linhas
            {
                for (int j = 0; j < matrizUm.GetLength(1); j++) // colunas
                {
                    arrayTemp[i, j] = matrizUm[i, j];
                    matrizUm[i, j] = matrizDois[i, j];
                    matrizDois[i, j] = arrayTemp[i, j];
                }
            }
            // mostrar os 2 Arrays
            // array 1
            Console.WriteLine("---Matriz 1----------");
            for (int i = 0; i < matrizUm.GetLength(0); i++) // linhas
            {
                for (int j = 0; j < matrizUm.GetLength(1); j++) // colunas
                {
                    Console.Write($"{matrizUm[i, j]}\t");
                }
                Console.WriteLine();
            }
            // array 2
            Console.WriteLine("----- Matriz 2 --------");
            for (int i = 0; i < matrizDois.GetLength(0); i++) // linhas 
            {
                for (int j = 0; j < matrizDois.GetLength(1); j++) // colunas
                {
                    Console.Write($"{matrizDois[i, j]}\t");
                }
                Console.WriteLine();
            }




        }
        static int gerarValores()
        {
            Random r = new Random();
            return r.Next(-10, 11);
        }
    }
}