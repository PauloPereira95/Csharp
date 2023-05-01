using System;
using System.ComponentModel;
using System.Drawing;

namespace exe_arrays_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //teste();
            exeAvaliacao();
        }
        static void FicArrays04()
        {
            int[] arrNum = new int[10];
            int soma = 0;
            int end = arrNum.Length - 1, meio = arrNum.Length/2,temp=0;
            Console.WriteLine("->" + meio);
            // adiciona os valores ao array
            for (int i = 0; i < arrNum.Length;i++)
            {
                arrNum[i] = RandomNumb();
            }
            // mostra o array
            for (int i = 0; i < arrNum.Length; i++)
            {
                Console.Write($"{arrNum[i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            // Faz a soma do ultimo com o primeiro e assim sucessivamente
            for (int i = 0; i < arrNum.Length; i++)
            {
                soma = arrNum[i] + arrNum[end];
                Console.WriteLine($"Soma  {arrNum[i]} + {arrNum[end]} = {soma}");
                end--;
            }
            // Trocar os valores no array - posição 0 com a posição 10, posição 1 com
            // a posição 11, 2 com a 12
            // e assim sucessivamente); após a troca, mostrar valores do array;
            for (int i =0; i < arrNum.Length/2; i++)
            {
                temp = arrNum[i];
                arrNum[i] = arrNum[meio];
                arrNum[meio] = temp;
                meio++;
            }
            for (int i = 0; i < arrNum.Length; i++)
            {
                Console.Write($"{arrNum[i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine();

        }
        static void exeAvaliacao()
        {
            int[] arrGrupUm = new int[10];
            int[] arrGrupDois = new int[10];
            
            int piorNota = Int16.MaxValue, reprovacoes =0,aprovaçõesA=0,aprovaçõesB =0;
            string grupo = "";
            double mediaGUm = 0, mediaGDois = 0,somaGUm = 0, somaGDois = 0;
            double mediaAproA = 0;
            double mediaAproB= 0;
            Console.WriteLine("----Grupo Um-------------------------------");
            for (int i =0; i< arrGrupUm.Length;i++)
            {
                arrGrupUm[i] = RandomNumb();
                somaGUm += arrGrupUm[i];
                Console.Write($"{arrGrupUm[i]}\t");
                if (arrGrupUm[i] < piorNota)
                {
                    piorNota = arrGrupUm[i];
                    grupo = "Um";
                }
                if (arrGrupUm[i] < 10)
                    reprovacoes++;
                else
                    aprovaçõesA++;
            }
            Console.WriteLine();
            mediaAproA = ((double)aprovaçõesA / arrGrupDois.Length) * 100;

            mediaGUm = (double)somaGUm / arrGrupUm.Length;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("----Grupo Dois------------------------------");
            for (int i =0; i< arrGrupDois.Length;i++)
            {
                arrGrupDois[i] = RandomNumb();
                somaGDois += arrGrupDois[i];
                Console.Write($"{arrGrupDois[i]}\t");
                if (arrGrupDois[i] <= piorNota)
                {
                    piorNota = arrGrupDois[i];
                    grupo = "Dois";
                }
                if (arrGrupDois[i] < 10)
                    reprovacoes++;
                else
                    aprovaçõesB++;

            }
            Console.WriteLine();

            //
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-----------------Resultados-----------------\n");
            mediaGDois = (double)somaGDois / arrGrupDois.Length;
            mediaAproB = ((double)aprovaçõesB / arrGrupDois.Length) * 100;

            if (mediaGUm > mediaGDois)
                Console.WriteLine($"Grupo Um tem a maior media, {mediaGUm}\n");
            else if (mediaGDois > mediaGUm)
                Console.WriteLine($"Grupo Dois tem a maior media ,{mediaGUm}\n");
            Console.WriteLine($"Pior nota -> {piorNota} Grupo {grupo}\n");
            Console.WriteLine($"Reprovações -> {reprovacoes}\n");
            Console.WriteLine($"Percentagem de Aprovacões Grupo A -> {mediaAproA} % || Media Grupo B -> {mediaAproB} % \n");
            //--------------------------------------
            /* calcular Moda
            int[] listaValoresOrdenada = arrGrupUm.ToArray();
            // Ordena o Valor
            Array.Sort(listaValoresOrdenada);
            //Obtem o primeiro valor da lista Ordenada
            int valorAtual = listaValoresOrdenada[0];
            int contadorActual = 0;

            int[] listaNumRepeticoes = new int[listaValoresOrdenada.Length];
            listaNumRepeticoes[0] = contadorActual;
            // Define o numero de repeticao de cada Numero
            for (int i = 1; i <= listaValoresOrdenada.Length - 1; i++)
            {
                if (listaValoresOrdenada[i] != valorAtual)
                {
                    valorAtual = listaValoresOrdenada[i];
                    contadorActual++;
                }
                listaNumRepeticoes[i] = contadorActual;
            }
            // Exemplo: 
            //   listaValoresOrdenada {3,3,3,5,6,7,8,9,9,9,9}
            // Resultado:
            //   listaNumRepeticoes   {0,1,2,0,0,0,0,0,1,2,3}
            int maiorRepeticao = listaNumRepeticoes.Max();

            if (maiorRepeticao > 0)
            {
                // obtem os valores que mais se repetirem
                int contadorRepeticaoMaior = 0;
                for (int i = 0; i < listaNumRepeticoes.Length; i++)
                {
                    if (listaNumRepeticoes[i] == maiorRepeticao)
                    {
                        contadorRepeticaoMaior++;
                    }
                }
                // popula a lista para retornar os valores que mais se repetem
                int[] listaRetorno = new int[contadorRepeticaoMaior];
                int contadorRetorno = 0;
                for (int i = 0; i < listaNumRepeticoes.Length; i++)
                {
                    if (listaNumRepeticoes[i] == maiorRepeticao)
                    {
                        listaRetorno[contadorRetorno] += listaValoresOrdenada[i];
                        contadorRetorno++;
                    }
                }
                for (int i = 0; i < listaRetorno.Length;i++)
                {
                    Console.WriteLine($"Moda->{listaRetorno[i]}");

                }
            }*/
            //int[] arrRep = new int[arrGrupUm.Length];
            //int rep = 0;
            //int repTemp = 0;
            //int moda = 0;
            //for (int i =0; i < arrGrupUm.Length;i++)
            //{
            //    arrRep[i] = arrGrupUm[i];
            //} 
            //for (int i =0; i < arrGrupUm.Length;i++)
            //{
            //    repTemp = 0;
            //    for (int j = 0; j < arrRep.Length;j++)
            //    {
            //        if (rep == 0)
            //        {
            //            rep = repTemp;
            //        }
            //        else if(arrRep[j] == arrGrupUm[j])
            //        {
            //            repTemp++;
            //        }
            //        Console.WriteLine(repTemp);
            //    }
            //    if (repTemp > rep)
            //    {
            //        rep = repTemp;
            //        moda = arrRep[i];
            //    }
            //}

            //Console.WriteLine($"Moda -> {moda} -> Repeticoes  {rep}");
            //------------------------------------------------------------
            //Solicitar ao utilizador a definição de um valor;
            //verificar o número de vezes que o valor definido se encontra em ambos os Arrays;
            //string numUserString = "";
            //int numUser,presencas =0;


            //Console.WriteLine("Digite o numero que deseja verificar");
            //numUserString = Console.ReadLine();
            //int.TryParse(numUserString, out numUser);

            //foreach (int valor in arrGrupUm)
            //{
            //    if (valor == numUser) 
            //        presencas++;
            //}

            //foreach (int valor in arrGrupDois)
            //{
            //    if(valor == numUser)
            //        presencas++;
            //}
            //Console.WriteLine($"O numero esta {presencas} x nos arrays");
            //-----------------------------------------------------------
            ////Escrever de forma ascendente o conjunto das avaliações de ambos os grupos;
            //// Ordena de forma ascendente
            //Array.Sort(arrGrupUm);
            //Array.Sort(arrGrupDois);
            //// Mostra aos arrays ordenados
            //Console.WriteLine("-------------Array Grupo Um ----------------");
            //foreach (int valor in arrGrupUm)
            //{
            //    Console.Write($"{valor}\t");

            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------Array Grupo Dois ----------------");
            //foreach (int valor in arrGrupDois)
            //{
            //    Console.Write($"{valor}\t");

            //}
            //Console.WriteLine("------------------------");
            ////------------------------------------------------------------------------
            
            //3.9  Escrever as 5 melhores avaliações do conjunto dos dois grupos;
           
            // declaração da array valores que vai ser a jagged array da grupo 1 + grupo 2
            int[][] valores = new int[2][];
            // declarar da array top que vai receber os melhores 5 de cada grupo
            int[] top = new int[10];
            // atribuir cada espaço da jagged array as arrays respetivas
            valores[0] = new int[arrGrupUm.Length];
            valores[1] = new int[arrGrupDois.Length];
            

            for (int i = 0; i < valores.Length; i++)
            {
                for (int j = 0; j < valores[i].Length; j++)
                {
                    // se estiver na primeira linha adicionar o grupo 1
                    if(i==0)
                        valores[i][j] = arrGrupUm[j];
                    else
                        // se estiver na segunda linh adiciona o grupo 2
                        valores[i][j] = arrGrupDois[j];

                }
            }
            // Mostra o Jagged Array
            for (int i = 0; i < valores.Length; i++)
            {
                for (int j = 0; j < valores[i].Length; j++)
                {
                    Console.Write("{0}\t", valores[i][j]);

                }
                Console.WriteLine();
            }
            // ordena cada sub-array de forma descendente MAIOR -> MENOR
            for (int i = 0; i < valores.Length; i++)
            {
                Array.Sort(valores[i]);
                Array.Reverse(valores[i]);
            }
            Console.WriteLine();
            // Mostra ao array ordenado
            Console.WriteLine("ORDENADO");
            for (int i = 0; i < valores.Length; i++)
            {
                for (int j = 0; j < valores[i].Length; j++)
                {
                    Console.Write("{0}\t", valores[i][j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------");
            // adiciona ao Array Top os 5 Melhores de cada array(Grupo 1 e Grupo 2 respetivamente)
            for (int i = 0; i < valores.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if (i==0)
                    {
                        top[j] = valores[i][j];

                    } else if (i > 0)
                    {
                        top[j+5] = valores[i][j];
                    }
                }
                Console.WriteLine();
            }
            // Ordena a array top de forna Descendente Maior -> Menor
            Array.Sort(top);
            Array.Reverse(top);
            // Mostra os Melhores 5
            Console.WriteLine("------- TOP 5 -----------");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($" {i + 1}º-> {top[i]}\t");
            }
            Console.WriteLine() ;

        }
        static int RandomNumb()
        {
            Random r = new Random();
            return r.Next(-10,10);
        }
        static void teste()
        {
            int[][] valores = new int[4][];
            valores[0] = new int[4];
            valores[1] = new int[6];
            valores[2] = new int[10];
            valores[3] = new int[5];
            for (int i = 0; i < valores.Length; i++)
            {
                for (int j = 0; j < valores[i].Length; j++)
                {
                    valores[i][j] = RandomNumb();
                }
            }
            for (int i = 0; i < valores.Length; i++)
            {
                for (int j = 0; j < valores[i].Length; j++)
                {
                }
                Console.WriteLine();
            }

        }
    }
}