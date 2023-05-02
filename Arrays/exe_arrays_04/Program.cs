using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace exe_arrays_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FicArrays04_03();
        }
        static void FicArrays04_01_02()
        {
            int[] arrNum = new int[10];
            int soma = 0;
            int end = arrNum.Length - 1, meio = arrNum.Length / 2, temp = 0;
            Console.WriteLine("->" + meio);
            // adiciona os valores ao array
            for (int i = 0; i < arrNum.Length; i++)
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
            for (int i = 0; i < arrNum.Length / 2; i++)
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
        static void FicArrays04_03()
        {
            // Declaração dos array que vao receber as notas do grupo Um e Dois
            int[] arrGrupUm = new int[10];
            int[] arrGrupDois = new int[10];

            int piorNota = Int16.MaxValue, reprovacoes = 0, aprovaçõesA = 0, aprovaçõesB = 0;
            string grupo = "";
            double mediaGUm = 0, mediaGDois = 0, somaGUm = 0, somaGDois = 0;
            double mediaAproA = 0;
            double mediaAproB = 0;
            // Preenche com numeros aleatorios
            // Calcula a soma 
            // Encontra a pior nota
            // Ve os reprovados e nao reporvados
            Console.WriteLine("----Grupo Um-------------------------------");
            for (int i = 0; i < arrGrupUm.Length; i++)
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
            // Calcula a Media do Grupo Um , aprovados  e media notas
            mediaAproA = ((double)aprovaçõesA / arrGrupDois.Length) * 100;
            mediaGUm = (double)somaGUm / arrGrupUm.Length;
            // Preenche com numeros aleatorios
            // Calcula a soma 
            // Encontra a pior nota
            // Ve os reprovados e nao reporvados
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("----Grupo Dois------------------------------");
            for (int i = 0; i < arrGrupDois.Length; i++)
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

            // Calcula a Media do Grupo Dois , aprovados  e media notas
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-----------------Resultados-----------------\n");
            mediaGDois = (double)somaGDois / arrGrupDois.Length;
            mediaAproB = ((double)aprovaçõesB / arrGrupDois.Length) * 100;
            // Mostra o grupo com a maior media
            if (mediaGUm > mediaGDois)
                Console.WriteLine($"Grupo Um tem a maior media, {mediaGUm}\n");
            else if (mediaGDois > mediaGUm)
                Console.WriteLine($"Grupo Dois tem a maior media ,{mediaGUm}\n");
            
            Console.WriteLine($"Pior nota -> {piorNota} Grupo {grupo}\n");
            Console.WriteLine($"Reprovações -> {reprovacoes}\n");
            Console.WriteLine($"Percentagem de Aprovacões Grupo A -> {mediaAproA} % || Media Grupo B -> {mediaAproB} % \n");
            //--------------------------------------
            //--------- Calcular Moda --------------------
            Console.WriteLine();
            Console.WriteLine("------------MODA---------------");
            // Declaração do Array que vai guardar o numero de vezes que cada nota se repete
            int[] arrModa = new int[21];

            // Declaração variavel(repeticoes) que vai receber o numero maior de repeticoes 
            // e moda que vai receber o index que Moda, a nota mais vezes repetida
            int repeticoes = 0,moda =0;
                // percorre os array dos dois grupos
                // e sempre que encontrar um nota ele acrescenta +1 ha posicao da nota
                foreach (int item in arrGrupUm )
                {
                    arrModa[item]++;
                }
                foreach (int item in arrGrupDois )
                {
                        arrModa[item]++;
                }
            
            // recebe o numero maior de vezes que alguma foi repetida
            repeticoes = arrModa.Max();
            // recebe o seu respetivo index
            moda = Array.IndexOf(arrModa, repeticoes);
            // Mostra ao utilizador os resultado
            Console.WriteLine($"Moda -> {moda} || Nº vezes  Repetidas -> {repeticoes}");
            //--------------------------------------------
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
                    if (i == 0)
                        valores[i][j] = arrGrupUm[j];
                    else
                        // se estiver na segunda linh adiciona o grupo 2
                        valores[i][j] = arrGrupDois[j];

                }
            }
            Console.WriteLine("--------Jagged Array ------------------");
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
            // adiciona ao Array Top os 5 Melhores de cada array(Grupo 1 e Grupo 2 respetivamente)
            for (int i = 0; i < valores.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if (i == 0)
                    {
                        top[j] = valores[i][j];

                    }
                    else if (i > 0)
                    {
                        top[j + 5] = valores[i][j];
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
            Console.WriteLine();

        }
        static void FicArrays04_04()
        {
            // Declaração do Jagged Array que vai gaudar os respetivos arrays
            int[][] jaaggedPaises = new int[5][];
            jaaggedPaises[0] = new int [6];
            jaaggedPaises[1] = new int[11];
            jaaggedPaises[2] = new int[10];
            jaaggedPaises[3] = new int[14];
            jaaggedPaises[4] = new int[11];

            int somaPop = 0, contador = 0, somaTemp = 0, soma = 0, posArray = 0;
            double mediaPais = 0;
            string paisMaisPop = "",paisMenorPop ="";
            // Preenche com valores aleatorios
            for (int i = 0; i < jaaggedPaises.Length;i++)
            {
                for(int j = 0; j < jaaggedPaises[i].Length; j++)
                {
                    jaaggedPaises[i][j] = RandomNumb_Positivos();
                }
            }
            for (int i = 0; i < jaaggedPaises.Length; i++)
            {
                for (int j = 0; j < jaaggedPaises[i].Length; j++)
                {
                    Console.Write($"{jaaggedPaises[i][j]}\t");
                }
                Console.WriteLine();
            }
            // 4.1. Calcular a média global da população;
            // Acessamos ao jagged array e somamos cada valor
            // e para alem disso contamos quantas vezes vamos fazer a soma
            // porque assim saberemos qual o numero de "casas" tem a jagged array no total
            for (int i = 0; i < jaaggedPaises.Length; i++)
            {
                for (int j = 0; j < jaaggedPaises[i].Length; j++)
                {
                    somaPop += jaaggedPaises[i][j];
                    contador++;
                }
            }
            Console.WriteLine($"Total População {somaPop}");
            Console.WriteLine($"Media População {somaPop / contador}");
            // 4.2. O país com mais população;
            for(int i = 0; i< jaaggedPaises.Length; i++)
            {
                somaTemp = jaaggedPaises[i].Sum();
                if ( somaTemp > soma )
                {
                    soma = somaTemp;
                    switch (i)
                    {
                        case 0:
                            paisMaisPop = "Portugal";
                            break;
                        case 1:
                            paisMaisPop = "Espanha";
                            break;
                        case 2:
                            paisMaisPop = "Itália";
                            break;
                        case 3:
                            paisMaisPop = "França";
                            break;
                        case 4:
                            paisMaisPop = "UK";
                            break;
                    }
                }
            }
            Console.WriteLine($"País mais populado -> {paisMaisPop}");
            //4.3.A cidade com menor população(indicar valor
            //da população e posição no array);
            soma = Int16.MaxValue;
            for (int i = 0; i < jaaggedPaises.Length; i++)
            {
                somaTemp = jaaggedPaises[i].Sum();
                
                if (somaTemp < soma)
                {
                    soma = somaTemp;
                    switch (i)
                    {
                        case 0:
                            paisMenorPop = "Portugal";
                            posArray = i;
                            break;
                        case 1:
                            paisMenorPop = "Espanha";
                            posArray = i;
                            break;
                        case 2:
                            paisMenorPop = "Itália";
                            posArray = i;
                            break;
                        case 3:
                            paisMenorPop = "França";
                            posArray = i;
                            break;
                        case 4:
                            paisMenorPop = "UK";
                            posArray = i;
                            break;
                    }
                }
            }
            Console.WriteLine($"Pais com menor População -> {paisMenorPop} || Posicão Array -> {posArray}");
            // 4.4. A soma e a média da população por país
            soma = 0;
            for (int i = 0; i< jaaggedPaises.Length;i++)
            {
                    soma =jaaggedPaises[i].Sum();
                    mediaPais = jaaggedPaises[i].Average();
                switch (i)
                {
                    case 0:
                        Console.WriteLine($" Soma PT -> {soma} || Media -> {Math.Round(mediaPais, 2)}");
                        break;
                    case 1:
                        Console.WriteLine($" Soma ES -> {soma} || Media -> {Math.Round(mediaPais, 2)}");
                        break;
                    case 2:
                        Console.WriteLine($" Soma IT -> {soma} || Media -> {Math.Round(mediaPais, 2)}");
                        break;
                    case 3:
                        Console.WriteLine($" Soma FR -> {soma} || Media -> {Math.Round(mediaPais, 2)}");
                        break;
                    case 4:
                        Console.WriteLine($" Soma UK -> {soma} || Media -> {Math.Round(mediaPais, 2)}");
                        break;
                }
            }
        }
        static void FicArrays04_05()
        {
            // Declaração do Jagged Array
            double[][] jaggedTemp = new double[5][];
            // Atribuição das arrays ao jagged array
            jaggedTemp[0] = new double[4];
            jaggedTemp[1] = new double[6];
            jaggedTemp[2] = new double[3];
            jaggedTemp[3] = new double[3];
            jaggedTemp[4] = new double[5];
            // Preenchimento do array
            for (int i =0; i < jaggedTemp.Length;i++)
            {
                for (int j =0; j < jaggedTemp[i].Length; j++)
                {
                    jaggedTemp[i][j] = GerarValorReal(-5,11);
                }
            }
            // Mostrar Array
            for (int i = 0; i < jaggedTemp.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write("Lisboa --> ");
                        break; 
                    case 1:
                        Console.Write("Beja --> ");
                        break; 
                    case 2:
                        Console.Write("Guarda --> ");
                        break; 
                    case 3:
                        Console.Write("Bragança --> ");
                        break;
                    case 4:
                        Console.Write("Braga --> ");
                        break;
                }
                for (int j = 0; j < jaggedTemp[i].Length; j++)
                {
                    
                    Console.Write($"{jaggedTemp[i][j]}\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------");
            // 5.1. A temperatura média global do dia 1 de Janeiro;
            int contador = 0;
            double media = 0, soma = 0;
            for (int i =0; i < jaggedTemp.Length;i++)
            {
                for (int j =0; j < jaggedTemp[i].Length;j++)
                {
                    soma += jaggedTemp[i][j];
                    contador++;
                }

            }
            Console.WriteLine($"Media Global -> {Math.Round(soma/ contador++,2)}º");
            Console.WriteLine("----------------------------------------");
            // 5.2. A temperatura média por local;

            for (int i =0; i < jaggedTemp.Length;i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine($"Temp Media Lisboa -> {Math.Round(jaggedTemp[0].Average(),2)}º");
                        break;
                    case 1:
                        Console.WriteLine($"Temp Media  Beja -> {Math.Round(jaggedTemp[i].Average(),2)}º");
                        break;
                    case 2:
                        Console.WriteLine($"Temp Media Guarda -> {Math.Round(jaggedTemp[i].Average(),2)}º");

                        break;
                    case 3:
                        Console.WriteLine($"Temp Media Bragança -> {Math.Round(jaggedTemp[i].Average(),2)}º");

                        break;
                    case 4:
                        Console.WriteLine($"Temp Media Braga -> {Math.Round(jaggedTemp[i].Average(),2)}º");
                        break;
                }
            }
            Console.WriteLine("----------------------------------------");
            //5.3. A zona onde se verificou a menor temperatura;
            double menorTemp = jaggedTemp[0][0];
            int zona = 0;
            
            for (int i = 0; i < jaggedTemp.Length;i++)
            {
               
                if (jaggedTemp[i].Min() < menorTemp)
                {
                    menorTemp = jaggedTemp[i].Min();
                    zona = i;
                }
            }
            switch (zona)
            {
                case 0:
                    Console.WriteLine($"A Temperatura mais baixa foi Registada em Lisboa {menorTemp}");
                    break;
                case 1:
                    Console.WriteLine($"A Temperatura mais baixa foi Registada em Beja {menorTemp}");
                    break;
                case 2:
                    Console.WriteLine($"A Temperatura mais baixa foi Registada em Guarda {menorTemp}");

                    break;
                case 3:
                    Console.WriteLine($"A Temperatura mais baixa foi Registada em Bragança {menorTemp}");

                    break;
                case 4:
                    Console.WriteLine($"A Temperatura mais baixa foi Registada em Braga {menorTemp}");
                    break;
            }
            // 5.4 A zona com temperatura média mais elevada;
            double mediaMaisElevada = 0;
            zona = 0;
            for (int i = 0; i < jaggedTemp.Length; i++) 
            {
                if (jaggedTemp[i].Average() > mediaMaisElevada)
                {
                    mediaMaisElevada = jaggedTemp[i].Average();
                    zona = i;
                }
            }
            switch (zona)
            {
                case 0:
                    Console.WriteLine($"A Temperatura media mais alta foi Registada em Lisboa -> {Math.Round(mediaMaisElevada, 2)}º");
                    break;
                case 1:
                    Console.WriteLine($"A Temperatura media mais alta foi Registada em Beja -> {Math.Round(mediaMaisElevada, 2)}º");
                    break;
                case 2:
                    Console.WriteLine($"A Temperatura media mais alta foi Registada em Guarda -> {Math.Round(mediaMaisElevada, 2)}º");

                    break;
                case 3:
                    Console.WriteLine($"A Temperatura media mais alta foi Registada em Bragança -> {Math.Round(mediaMaisElevada, 2)}º");

                    break;
                case 4:
                    Console.WriteLine($"A Temperatura media mais alta foi Registada em Braga -> {Math.Round(mediaMaisElevada, 2)}º");
                    break;
            }
            //5.5. A zona onde se verificaram maior número de temperaturas negativas;
            zona = 0;
            int numTempNegTemp = 0;
            int numTempNega = 0;
            for (int i =0; i< jaggedTemp.Length;i++)
            {
                for (int j =0; j < jaggedTemp[i].Length;j++)
                {
                    if (jaggedTemp[i][j] < 0)
                    {
                        numTempNegTemp++;
                    }
                }
                    if (numTempNegTemp > numTempNega)
                    {
                        numTempNega = numTempNegTemp;
                        zona = i;
                    }
                numTempNegTemp = 0;

            }
            switch (zona)
            {
                case 0:
                    Console.WriteLine($"A Região com mais Temp Negativas foi Registada em Lisboa -> {numTempNega}");
                    break;
                case 1:
                    Console.WriteLine($"A Região com mais Temp Negativas foi Registada em Beja -> {numTempNega}");
                    break;
                case 2:
                    Console.WriteLine($"A Região com mais Temp Negativas foi Registada em Guarda -> {numTempNega}");

                    break;
                case 3:
                    Console.WriteLine($"A Região com mais Temp Negativas foi Registada em Bragança -> {numTempNega}");

                    break;
                case 4:
                    Console.WriteLine($"A Região com mais Temp Negativas foi Registada em Braga -> {numTempNega}");
                    break;
            }
        }
        // Gera numeros de 1 a 20, Notas para avaliação
        static int RandomNumb()
        {
            Random r = new Random();
            return r.Next(1, 21);
        }
        static int RandomNumb_Positivos()
        {
            Random r = new Random();
            return r.Next(0, 10);
        }
        static double GerarValorReal(double minimo, double maximo)
        {
            Random random = new Random();
            double result = random.NextDouble() * (maximo - minimo) + minimo;
            return Math.Round(result, 1);
        }

    }
}