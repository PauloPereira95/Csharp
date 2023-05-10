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
            teste();
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
            double  somaGUm = 0, somaGDois = 0;
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
                //if (arrGrupUm[i] < piorNota)
                //{
                //    piorNota = arrGrupUm[i];
                //    grupo = "Um";
                //}
                if (arrGrupUm[i] < 10)
                    reprovacoes++;
                else
                    aprovaçõesA++;
            }
            Console.WriteLine();
            // Calcula a Media do Grupo Um , aprovados  e media notas
            mediaAproA = ((double)aprovaçõesA / arrGrupDois.Length) * 100;
            //mediaGUm = arrGrupUm.Average();
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
                //if (arrGrupDois[i] <= piorNota)
                //{
                //    piorNota = arrGrupDois[i];
                //    grupo = "Dois";
                //}
                if (arrGrupDois[i] < 10)
                    reprovacoes++;
                else
                    aprovaçõesB++;

            }
            Console.WriteLine();

            // Calcula a Media do Grupo Dois , aprovados  e media notas
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-----------------Resultados-----------------\n");
            mediaAproB = arrGrupDois.Average();
            // Mostra o grupo com a maior media
            if (arrGrupUm.Average() > arrGrupDois.Average())
                Console.WriteLine($"Grupo Um tem a maior media, {arrGrupUm.Average()}\n");
            else if (arrGrupUm.Average() < arrGrupDois.Average())

                Console.WriteLine($"Grupo Dois tem a maior media , {arrGrupDois.Average()}\n");
            else
                Console.WriteLine($"A Média dos Grupos é igual !");

            //Console.WriteLine($"Pior nota -> {piorNota} Grupo {grupo}\n");
            if (arrGrupUm.Max() > arrGrupDois.Max())

                Console.WriteLine($"Melhor Avaliação -> Grupo Um , {arrGrupUm.Max()}");
            else
                Console.WriteLine($"Melhor Avaliação -> Grupo Um ,{arrGrupDois.Max()}");
            //-------------- OU ---------------------------------------

            if (arrGrupUm.Min() > arrGrupDois.Min())

                Console.WriteLine($"Pior Avaliação -> Grupo Um , {arrGrupUm.Min()}");
            else
                Console.WriteLine($"Pior Avaliação -> Grupo Dois ,{arrGrupDois.Min()}");
            //IF - Ternario int min = arrGrupUm.Min() < arrGrupDois.Min() ? arrGrupUm.Min() : arrGrupDois.Min();



            //Console.WriteLine($"Reprovações -> {reprovacoes}\n");
            // OU 
            int rep_grupoUm = 0; int rep_grupoDois = 0;
            rep_grupoUm = arrGrupUm.Where(x => x < 10).Count();
            rep_grupoDois = arrGrupDois.Where(x => x < 10).Count();
            if (rep_grupoUm > rep_grupoDois)

                Console.WriteLine($"Mais Reprovações no Grupo 1 = {rep_grupoUm}");
            else
                Console.WriteLine($"Mais Reprovações no Grupo 2 = {rep_grupoDois}");

            //Console.WriteLine($"Percentagem de Aprovacões Grupo A -> {mediaAproA} % || Media Grupo B -> {mediaAproB} % \n");
            // CORRIGIR !!!!!
            double per_rep_grup1 = ((double)rep_grupoUm / arrGrupUm.Length) * 100;
            double per_apr_grup1 = (((double)arrGrupUm.Length - rep_grupoUm) / arrGrupUm.Length * 100);
            double per_rep_grup2 = ((double)rep_grupoDois / arrGrupDois.Length) * 100;
            double per_apr_grup2 = (((double)arrGrupDois.Length - rep_grupoDois) / arrGrupDois.Length * 100);

            Console.WriteLine($"Arpovações Grupo 1 -> {per_apr_grup1} || Reprovações Grupo 1 -> {per_apr_grup1}" );
            Console.WriteLine($"Arpovações Grupo 2 -> {per_apr_grup2} || Reprovações Grupo 2 -> {per_apr_grup2}" );

            
            
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
            // 3.7
            int avaliação = 0;
            Console.WriteLine("Qual é a avaliação que pretende vereificar: ");
            avaliação = int.Parse(Console.ReadLine());

            int total = 0;
            total = arrGrupUm.Where(x => x == avaliação).Count() + arrGrupDois.Where(x => x == avaliação).Count();
            Console.WriteLine($"O valor {total} regista-se {total} vezes");

            //-----------------------------------------------
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
            // Declaração do Jagged Array que vai guadar os respetivos arrays
            int[][] jaaggedPaises = new int[5][];
            // PT
            jaaggedPaises[0] = new int [6];
            // ESP
            jaaggedPaises[1] = new int[11];
            // IT
            jaaggedPaises[2] = new int[10];
            // f
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
            //for (int i = 0; i < jaaggedPaises.Length; i++)
            //{
            //    for (int j = 0; j < jaaggedPaises[i].Length; j++)
            //    {
            //        somaPop += jaaggedPaises[i][j];
            //        contador++;
            //    }
            //}
            // --------------- ou -----------------------
            for(int i =0; i < jaaggedPaises.Length;i++)
            {
                somaPop += jaaggedPaises[i].Sum();
                contador++;
            }
            Console.WriteLine($"Total População {somaPop}");
            Console.WriteLine($"Media População {Math.Round((double)somaPop / contador,2)}");
            // 4.2. O país com mais população;
            int linha_max = 0;
            for(int i = 0; i< jaaggedPaises.Length; i++)
            {
                somaTemp = jaaggedPaises[i].Sum();
                if ( somaTemp > soma )
                {
                    soma = somaTemp;
                    linha_max = i;
                }
                    switch (linha_max)
                    {
                        case 0: paisMaisPop = "Portugal";break;
                        case 1: paisMaisPop = "Espanha"; break;
                        case 2: paisMaisPop = "Itália";  break;
                        case 3: paisMaisPop = "França";  break;
                        case 4: paisMaisPop = "UK";      break;
                    }
            }
            Console.WriteLine($"País mais populado -> {paisMaisPop}, {soma}");
            //4.3.A cidade com menor população(indicar valor
            //da população e posição no array);
            soma = Int16.MaxValue;
            int minPopCidade = jaaggedPaises[0][0], minCidadeI = 0, minCidadeJ = 0;
            for (int i=0; i < jaaggedPaises.Length; i++)
            {
                for (int j = 0; j < jaaggedPaises[i].Length;j++)
                {
                    if (jaaggedPaises[i][j] < minPopCidade)
                    {
                        minPopCidade = jaaggedPaises[i][j];
                        minCidadeI = i;
                        minCidadeJ = j;
                    }
                }

            }
                switch (minCidadeI)
                {
                    case 0: paisMaisPop = "Portugal"; break;
                    case 1: paisMaisPop = "Espanha"; break;
                    case 2: paisMaisPop = "Itália"; break;
                    case 3: paisMaisPop = "França"; break;
                    case 4: paisMaisPop = "UK"; break;
                }
                Console.WriteLine($"A cidade com menos pop tem {minPopCidade} habitantes, é a " +
                    $"{minCidadeJ + 1}º cidade de {paisMaisPop}");
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
                    jaggedTemp[i][j] = GerarValorReal(-10,30);
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
            int totalEl = 0;
            double soma = 0;
            for (int i =0; i < jaggedTemp.Length;i++)
            {
                for (int j =0; j < jaggedTemp[i].Length;j++)
                {
                    soma += jaggedTemp[i][j];
                    totalEl += jaggedTemp[i].Length;
                }

            }
            Console.WriteLine($"Media Global -> {Math.Round(soma/ totalEl,2)}º");
            Console.WriteLine("----------------------------------------");
            // 5.2. A temperatura média por local;

            //for (int i =0; i < jaggedTemp.Length;i++)
            //{
            //    switch (i)
            //    {
            //        case 0:
            //            Console.WriteLine($"Temp Media Lisboa -> {Math.Round(jaggedTemp[0].Average(),1)}º");
            //            break;
            //        case 1:
            //            Console.WriteLine($"Temp Media  Beja -> {Math.Round(jaggedTemp[i].Average(),1)}º");
            //            break;
            //        case 2:
            //            Console.WriteLine($"Temp Media Guarda -> {Math.Round(jaggedTemp[i].Average(),1)}º");

            //            break;
            //        case 3:
            //            Console.WriteLine($"Temp Media Bragança -> {Math.Round(jaggedTemp[i].Average(),1)}º");

            //            break;
            //        case 4:
            //            Console.WriteLine($"Temp Media Braga -> {Math.Round(jaggedTemp[i].Average(),1)}º");
            //            break;
            //    }
            //}
            //-----------------------------------------------
            int c = 0;
            foreach (var item in jaggedTemp)
            {
                string cidade = "";
                switch (c)
                {
                    case 0: cidade = "Lisboa"; break;
                    case 1: cidade = "Beja"; break;
                    case 2: cidade = "Guarda"; break;
                    case 3: cidade = "Bragança"; break;
                    case 4: cidade = "Braga"; break;
                }
                c++;
                Console.WriteLine($" A temperatua meida em {cidade} foi {Math.Round(item.Average(),0)}");
            }
            Console.WriteLine("----------------------------------------");
            //5.3. A zona onde se verificou a menor temperatura;
            double menorTemp = jaggedTemp[0].Min();
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
            // Declaração de variavel que vai receber a zona com mais temperaturas negativas
            #region switch
            //zona = 0;
            // Declaração variavel que vai receber de forma temporaria o numero de
            // temperaturas negativas (numTempNegTemp) // Numero de Temperaturas Negativas Temporaria
            // para mais tarde comparar com a proxima cidade 
            //int numTempNegTemp = 0;


            // Declaração da variavel que vai receber o numero de temperaturas negativas final
            //int numTempNega = 0;

            //// percorre o jaggedArray
            //for (int i =0; i< jaggedTemp.Length;i++)
            //{
            //    for (int j =0; j < jaggedTemp[i].Length;j++)
            //    {
            //        // se o valor for menor que 0 
            //        if (jaggedTemp[i][j] < 0)
            //        {
            //            // adicionamos +1
            //            // ou seja contamos + 1
            //            numTempNegTemp++;
            //        }
            //    }
            //        // depois de percorrer a primeira linha
            //        // verificamos se a linha anterior tem mais temperaturas negativas
            //        // que a linha que acabamos de percorrer
            //        if (numTempNegTemp > numTempNega)
            //        {   
            //            // se sim recebe o valor guardado temporariamente 
            //            numTempNega = numTempNegTemp;
            //            // recebe a respetiva zona (posição da linha no jagged Array)
            //            zona = i;
            //        }
            //    // reinicaiamos a variavel temporaria
            //    numTempNegTemp = 0;

            //}
            // Apartir da zona recebida mostramos a respetiva mensagem
            int  contadorTempNegativas = jaggedTemp[0].Where(t => t < 0).Count();
            for (int i = 1; i < jaggedTemp.Length;i++)
            {
                int temp = jaggedTemp[i].Where(t => t < 0).Count();
                if (temp > contadorTempNegativas)
                {
                    contadorTempNegativas = temp;
                    zona = i;
                }
            }
           
            switch (zona)
            {
                case 0:
                    Console.WriteLine($"A Região com mais Temp Negativas foi Registada em Lisboa -> {contadorTempNegativas}");
                    break;
                case 1:
                    Console.WriteLine($"A Região com mais Temp Negativas foi Registada em Beja -> {contadorTempNegativas}");
                    break;
                case 2:
                    Console.WriteLine($"A Região com mais Temp Negativas foi Registada em Guarda -> {contadorTempNegativas}");

                    break;
                case 3:
                    Console.WriteLine($"A Região com mais Temp Negativas foi Registada em Bragança -> {contadorTempNegativas}");

                    break;
                case 4:
                    Console.WriteLine($"A Região com mais Temp Negativas foi Registada em Braga -> {contadorTempNegativas}");
                    break;
            }
            #endregion Fim Switch
        }
        //--------------------------------------------------
        // Gera numeros de 1 a 20, Notas para avaliação
        static int RandomNumb()
        {
            Random r = new Random();
            return r.Next(0, 21);
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
        static void teste()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 5, 6 };
            int index1 = Array.IndexOf(numeros, 3);
            Console.WriteLine(index1);
            int index2 = Array.LastIndexOf(numeros, 6);
            Console.WriteLine(index2);

            Array.Resize(ref numeros, 10);
        }
    }
}