using System;

namespace exe_arrays_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            exeAvaliacao();
        }
        static void FicArrays04()
        {
            int[] arrNum = new int[20];
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
                Console.WriteLine(arrNum[i]);
            }

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
                Console.WriteLine(arrNum[i]);
            }


        }
        static void exeAvaliacao()
        {
            int[] arrGrupUm = new int[10];
            int[] arrGrupDois = new int[10];
            int piorNota = Int16.MaxValue,reprovacoes =0,aprovações =0;
            string grupo = "";
            double mediaGUm = 0, mediaGDois = 0,somaGUm = 0, somaGDois = 0;
            double mediaAproA = 0;
            double mediaAproB= 0;
            Console.WriteLine("----Grupo Um------");
            for (int i =0; i< arrGrupUm.Length;i++)
            {
                arrGrupUm[i] = RandomNumb();
                somaGUm += arrGrupUm[i];
                Console.WriteLine(arrGrupUm[i]);
                if (arrGrupUm[i] < piorNota)
                {
                    piorNota = arrGrupUm[i];
                    grupo = "Um";
                }
                if (arrGrupUm[i] < 10)
                    reprovacoes++;
                else 
                    aprovações++;
            }
            mediaAproA = ((double)aprovações / arrGrupDois.Length) * 10;

            mediaGUm = (double)somaGUm / arrGrupUm.Length;
            Console.WriteLine("--------------------");
            Console.WriteLine("----Grupo Dois------");
            for (int i =0; i< arrGrupDois.Length;i++)
            {
                arrGrupDois[i] = RandomNumb();
                somaGDois += arrGrupDois[i];
                Console.WriteLine(arrGrupDois[i]);
                if (arrGrupDois[i] <= piorNota)
                {
                    piorNota = arrGrupDois[i];
                    grupo = "Dois";
                }
                if (arrGrupDois[i] < 10)
                    reprovacoes++;
                else
                    aprovações++;

            }
            Console.WriteLine("--------------------");
            Console.WriteLine("-----Resultados-----");
            mediaGDois = (double)somaGDois / arrGrupDois.Length;
            mediaAproB = ((double)aprovações / arrGrupDois.Length) * 10;

            if (mediaGUm > mediaGDois)
                Console.WriteLine($"Grupo Um tem a maior media, {mediaGUm}");
            else if (mediaGDois > mediaGUm)
                Console.WriteLine($"Grupo Dois tem a maior media ,{mediaGUm}");
            Console.WriteLine($"Pior nota -> {piorNota} Grupo {grupo}");
            Console.WriteLine($"Reprovações -> {reprovacoes}");
            Console.WriteLine($"Percentagem de Aprovacões Grupo A -> {mediaAproA} % || Media Grupo B -> {mediaAproB} % <");
        }
        static int RandomNumb()
        {
            Random r = new Random();
            return r.Next(-10,11);
        }
    }
}