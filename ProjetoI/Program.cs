using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoI
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1ª Aula - Exercício 00
            Console.WriteLine("Exercício 01");
            Console.WriteLine("============");
            Console.WriteLine();
            Console.WriteLine();

            Classe00 c00 = new Classe00();
            c00.exercicios();


            // 1ª Aula - Exercício 01
            Console.Clear();
            Console.WriteLine("Exercício 01");
            Console.WriteLine("============");
            Console.WriteLine();
            Console.WriteLine();

            Classe01 c01 = new Classe01();
            c01.questao01();
            c01.questao02();
            c01.questao03();
            c01.questao04();
            c01.questao05();

            // 1ª Aula - Exercício 02
            Console.Clear();
            Console.WriteLine("Exercício 02");
            Console.WriteLine("============");
            Console.WriteLine();
            Console.WriteLine();

            Classe02 c02 = new Classe02();
            c02.questao01();


            // 1ª Aula - Exercício 03
            Console.Clear();
            Console.WriteLine("Exercício 03");
            Console.WriteLine("============");
            Console.WriteLine();
            Console.WriteLine();

            Classe03 c03 = new Classe03();
            c03.questao01();
            c03.questao02();

            // 1ª Aula - Exercício 04
            Console.Clear();
            Console.WriteLine("Exercício 04");
            Console.WriteLine("============");
            Console.WriteLine();
            Console.WriteLine();

            Classe04 c04 = new Classe04();
            c04.questao01();
            c04.questao02();
            c04.questao03();
            c04.questao04();


            // 1ª Aula - Exercício 05
            Console.Clear();
            Console.WriteLine("Exercício 05");
            Console.WriteLine("============");
            Console.WriteLine();
            Console.WriteLine();

            Classe05 c05 = new Classe05();
            c05.questao01();
            c05.questao02();
            c05.questao03();
            c05.questao04();
            c05.questao05();
            c05.questao06();


        }
    }

    class Classe00
    {
        public void exercicios()
        {
            Console.WriteLine("1- O que é a Common Language Runtime (CLR)? Por que ela é uma parte importante do .NET Framework?");
            Console.WriteLine("R: É equivalente a JVM do Java. Isto é, responsável pela execução de assembly´s (byte codes e, java).");
            Console.WriteLine("O CRL é a camada entre a aplicação e o sistema operacional. Daí sua importância.");
            Console.WriteLine("próxima...");
            Console.ReadLine();

            Console.WriteLine("2- Descreva o processo de compilação de um programa C# para um assembly e o processo de execução de um assenbly.");
            Console.WriteLine("R: Na compilação de um código fonte de uma das linguagens do .NET, por exemplo o C#, o compilador gera ");
            Console.WriteLine("um código intermediário que será lido pelo CLR e convertido para o código nativo de máquina. ");
            Console.WriteLine("Esse código é conhecido por assembly.");
            Console.WriteLine("Na execução do assembly, o CLR faz uso do JIT (just in time) para otimizar o código de acordo com os recursos da máquina.");
            Console.WriteLine("próxima...");
            Console.ReadLine();

            Console.WriteLine("3- O que é a MSIL? Aponte algumas características chaves.");
            Console.WriteLine("R: O MSIL, Microsoft Intermediate Language, também conhecido como IL ou CIL, é uma linguagem intermediária gerada pela compilação");
            Console.WriteLine("do código fonte da aplicação. É uma linguagem de baixo nível para a CLR.");
            Console.WriteLine("Por meio do compilador JIT existente na CLR, o MSIL é convertido em instruções do processador utilizado na execução. ");
            Console.WriteLine("Assim, o código faz uso dos recursos existentes para cada processador que irá executar a aplicação.");
            Console.WriteLine("próxima...");
            Console.ReadLine();

            Console.WriteLine("4- O que é a Common Language Specification (CLS)? Por que ela foi desenvolvida?");
            Console.WriteLine("R: É a espeficação comum de liguagem.");
            Console.WriteLine("Como podemos desenvolver em diversas liguagens no.NET, (C#, J#, VB, Delphi, entre outras), se faz necessário uma ");
            Console.WriteLine("especificação a ser implementada em cada liguagem e desta forma, tornar as instruções comuns ao.NET");
            Console.WriteLine("Esta é a razão da existência da CLS.");
            Console.WriteLine("próxima...");
            Console.ReadLine();

            Console.WriteLine("5- O que é o Common Type System? Quando ele é utilizado?");
            Console.WriteLine("R: Da mesma forma da CLS, a CTS foi desenvolvida para definir os tipos ");
            Console.WriteLine("de dados(int, string, float, ...) comuns as diversas linguagens existentes no.NET");
            Console.WriteLine("Desta forma podemos, por exemplo, usar o tipo 'inteiro' nas diversas liguagens do framework");
            Console.WriteLine("e no processo de compilação esse tipo será referênciado ao system.int");
            Console.WriteLine("O CTS é utilizado no processo de compilação do código fonte para compatibilizar os tipos de dados.");

            Console.WriteLine();
            Console.WriteLine("fim do exercício.");
            Console.ReadLine();

        }
    }

    class Classe01
    {
        //1 - Crie, compile e execute uma aplicação console “Hello C#”.
        public void questao01()
        {
            Console.WriteLine("Questão 1 - Crie, compile e execute uma aplicação console “Hello C#");
            Console.WriteLine("Hello C#");
            Console.ReadLine();
        }


        //2 - Modifique a aplicação para imprimir na tela o seu nome.
        public void questao02()
        {
            Console.WriteLine();
            Console.WriteLine("Questão 2 - Modifique a aplicação para imprimir na tela o seu nome.");
            Console.WriteLine("Osmar de Oliveira Martins Filho (Mat.: 1581444)");
            Console.ReadLine();
        }


        //3 - Escreva um programa para imprimir na tela os números 1, 101 e 1001.
        public void questao03()
        {
            Console.WriteLine();
            Console.WriteLine("Questão 3 - Escreva um programa para imprimir na tela os números 1, 101 e 1001.");
            Console.WriteLine("1º Número: {0}", 1);
            Console.WriteLine("2º Número: {0}", 101);
            Console.WriteLine("3º Número: {0}", 1001);
            Console.ReadLine();

        }


        //4 - Crie uma aplicação console que imprime na tela a data e hora atual.
        public void questao04()
        {
            Console.WriteLine();
            Console.WriteLine("Questão 4 - Crie uma aplicação console que imprime na tela a data e hora atual.");
            Console.WriteLine("Data e Hora atual: {0}", DateTime.Now);
            Console.ReadLine();
        }


        //5 - Crie uma aplicação console que calcula e imprime na tela o quadrado do número 12345, bem como sua raíz quadrada.
        public void questao05()
        {
            Console.WriteLine();
            Console.WriteLine("Questão 5 - Crie uma aplicação console que calcula e imprime na tela o quadrado do número 12345, bem como sua raíz quadrada.");
            Console.WriteLine("Quadrado de 12345: {0}", Math.Pow(12345, 2));
            Console.WriteLine("Raiz Quadrada de 12345: {0}", Math.Sqrt(12345));
            Console.ReadLine();
        }
    }




    class Classe02
    {
        public void questao01()
        {
            Console.WriteLine("Questão 1: ");
            Console.WriteLine("Declare duas variáveis string e atribua a elas os valores 'Hello' e 'World'. ");
            Console.WriteLine("Declare uma variável do tipo object e atribua a ela a concatenação das duas primeiras variáveis (adicione um espaço entre ambas). ");
            Console.WriteLine("Declare uma terceira variável string e a inicialize com o valor da variável do tipo object criada anteriormente (será preciso fazer um type casting).");

            Console.WriteLine();
            Console.WriteLine();

            string str1 = "Hello";
            Console.WriteLine("1ª Variável string: {0}", str1);
            Console.ReadLine();

            string str2 = "World";
            Console.WriteLine("2ª Variável string: {0}", str2);
            Console.ReadLine();

            object obj = str1 + " " + str2;
            Console.WriteLine("Objeto: {0}", obj);
            Console.ReadLine();

            string str3 = (string)obj;
            Console.WriteLine("3ª Variável string: {0}", str3);
            Console.ReadLine();

        }

    }




    class Classe03
    {
        // 1ª Questão
        public void questao01()
        {
            Console.WriteLine();
            Console.WriteLine("Questão 1: Escreva um programa que encontra o maior valor entre 5 variáveis dadas.");
            Console.WriteLine();

            int maiorValor;
            int vl1 = 2;
            int vl2 = 6;
            int vl3 = 2;
            int vl4 = 8;
            int vl5 = 1;

            Console.WriteLine("Valor da 1ª Variável: {0}", vl1);
            Console.WriteLine("Valor da 2ª Variável: {0}", vl2);
            Console.WriteLine("Valor da 3ª Variável: {0}", vl3);
            Console.WriteLine("Valor da 4ª Variável: {0}", vl4);
            Console.WriteLine("Valor da 5ª Variável: {0}", vl5);

            maiorValor = vl1;

            if (vl2 > maiorValor) { maiorValor = vl2; }
            if (vl3 > maiorValor) { maiorValor = vl3; }
            if (vl4 > maiorValor) { maiorValor = vl4; }
            if (vl5 > maiorValor) { maiorValor = vl5; }

            Console.WriteLine("Maior valor encontrado: " + maiorValor);
            Console.ReadLine();

        }

        // 2ª Questão 
        public void questao02()
        {
            Console.WriteLine();
            Console.WriteLine("Questão 2:");
            Console.WriteLine("Escreva um programa que aplica um fator de bônus para um dado escore no intervalo [1..9]. ");
            Console.WriteLine("O programa deve ler o escore como um dígito na entrada. ");
            Console.WriteLine("Se o dígito está entre 1 e 3, o programa deve multiplicá-lo por 10; ");
            Console.WriteLine("se estiver entre 4 e 6, multiplica por 100; ");
            Console.WriteLine("se tiver entre 7 e 9, multiplica por 1000. ");
            Console.WriteLine("Se a entrada for zero ou outro valor não numérico o programa deve relatar um erro.");
            Console.WriteLine("Use a instrução switch e imprima o novo valor calculado no console.");
            Console.WriteLine();

            Console.Write("Entre com o escore no intervalo [1..9]: ");
            int escore = int.Parse(Console.ReadLine());

            switch (escore)
            {
                case 1:
                case 2:
                case 3:
                    escore = escore * 10;
                    break;
                case 4:
                case 5:
                case 6:
                    escore = escore * 100;
                    break;
                case 7:
                case 8:
                case 9:
                    escore = escore * 1000;
                    break;
                default:
                    Console.WriteLine("Entrada não é válida!");
                    break;
            }

            Console.WriteLine("Resultado: {0}", escore);
            Console.ReadLine();
        }

    }




    class Classe04
    {
        // 1ª Questão
        public void questao01()
        {
            Console.WriteLine("Questão 1: Escreva um programa que imprima todos os números de 1 até N que não sejam divisíveis por 3 e por 7 ao mesmo tempo.");
            Console.WriteLine();

            Console.Write("Informe um número: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Números não divisiveis por 3 e 7 entre 1 e {0}", n);
            for (int i = 1; i < n; i++)
            {
                if ((i % 3 == 0) || (i % 7 == 0))
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            Console.ReadLine();

        }

        public void questao02()
        {
            Console.WriteLine();
            Console.WriteLine("Questão 2: Escreva um programa que leia do console uma sequência de N números inteiros e retorne o maior e o menor deles. ");
            Console.WriteLine();

            Console.Write("Informe a qtd de números na sequência: ");
            int n = int.Parse(Console.ReadLine());


            int menor;
            int maior;
            int numero = 0;

            // Solicita o 1º elemento fora do loop para inicializar as  variáveis menor e maior
            Console.Write("Informe o 1º elemento da sequência:");
            numero = int.Parse(Console.ReadLine());

            maior = numero;
            menor = numero;

            // inicia o loop a partir do 2º elemento
            for (int i = 1; i < n; i++)
            {
                Console.Write("Informe o {0}º elemento da sequência: ", i + 1);
                numero = int.Parse(Console.ReadLine());

                if (numero < menor)
                {
                    menor = numero;
                }

                if (numero > maior)
                {
                    maior = numero;
                }
            }

            Console.WriteLine("Menor valor da sequência: {0}", menor);
            Console.WriteLine("Maior valor da sequência: {0}", maior);
            Console.ReadLine();
        }

        public void questao03()
        {
            Console.WriteLine();
            Console.WriteLine("Questão 3: ");
            Console.WriteLine("Escreva um programa que receba N e calcule a soma dos N primeiros termos da sequência de Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …");
            Console.WriteLine("Cada membro da sequência de Fibonacci(exceto os dois primeiros) é a soma dos dois membros anteriores.");
            Console.WriteLine();

            Console.Write("Informe a qtd de termos da sequência de fibonacci:");
            int n = int.Parse(Console.ReadLine());

            int i = 2;
            int f1 = 0;
            int f2 = 1;
            int aux = 0;
            int soma = 1; // 0+1 (os dois primeiros termos fora do loop)

            Console.Write("0 1 ");

            while (i < n)
            {

                Console.Write("{0} ", f1 + f2);
                soma = soma + (f1 + f2);

                aux = f1;
                f1 = f2;
                f2 = aux + f2;

                i++;
            }

            Console.WriteLine("");
            Console.WriteLine("Soma dos termos: {0}", soma);
            Console.ReadLine();

        }

        public void questao04()
        {
            Console.WriteLine();
            Console.WriteLine("Questão 4: ");
            Console.WriteLine("Escreva um programa que leia do console um número inteiro positivo N (N < 20) e escreva no console a matriz correspondente, tal como exemplificado:");
            Console.WriteLine();

            Console.Write("Informe um valor menor que 20: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 20)
            {
                for (int l = 1; l < n + 1; l++)
                {
                    for (int c = l; c < l + n; c++)
                    {
                        Console.Write("{0} ", c);
                    }

                    Console.WriteLine();

                }
            }

            Console.ReadLine();
        }
    }

    class Classe05
    {
        // 1ª Questão
        public void questao01()
        {
            Console.WriteLine("Questão 1: ");
            Console.WriteLine("Escreva um programa que declara um array de 20 inteiros e inicializa cada elemento pelo seu índice multiplicado por 6. Imprima o array obitido no console.");
            Console.WriteLine();

            int[] numeros = new int[20];
            for (int i = 0; i < 20; i++)
            {
                numeros[i] = i * 6;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Elemento[{0}] = {1}", i, numeros[i]);
            }

            Console.ReadLine();

        }

        //2ª Questão
        public void questao02()
        {
            Console.WriteLine();
            Console.WriteLine("Questão 2: ");
            Console.WriteLine("Escreva um programa que encontra a maior sequência incremental dentro de um array. Exemplo:{3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.");
            Console.WriteLine();

            int[] array = { 1, 1, 4, 5, 2, 3, 4, 5, 3, 1, 2, 3, 4, 5, 5, 5, 6, 7, 3 };
            List<int> seq = new List<int>();
            List<int> maiorSeq = new List<int>();

            Console.WriteLine("Array:  { 1, 1, 4, 5, 2, 3, 4, 5, 3, 1, 2, 3, 4, 5, 5, 5, 6, 7, 3 }");


            // Loop iniciando no segundo elemento do array
            int i = 0;
            while (i < array.Length - 1)
            {
                seq.Add(array[i]);

                // Caso a subtração do valor atual com o seu sucessor seja diferente de "1", então há quebra de sequência.
                if (array[i + 1] - array[i] != 1)
                {
                    if (seq.Count > maiorSeq.Count)
                    {
                        maiorSeq.Clear();
                        foreach (int l in seq)
                        {
                            maiorSeq.Add(l);
                        }

                    }

                    // Inicializa nova lista
                    seq = new List<int>();

                }

                i++;

            }

            Console.WriteLine();
            Console.WriteLine("Maior sequência encontrada:");
            foreach (int s in maiorSeq)
            {
                Console.Write("{0} ", s);
            }
            Console.ReadLine();
        }

        //3ª Questão
        public void questao03()
        {
            Console.WriteLine();
            Console.WriteLine("Questão 3: ");
            Console.WriteLine("Escreva um programa que encontra o número mais frequente dentro de um array. Examplo: ");
            Console.WriteLine(" { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4(5 times).");
            Console.WriteLine();

            int[] array = { 2, 4, 5, 5, 5, 7, 8, 9, 5, 2, 2, 4, 4, 5, 6, 5 };
            int valorMaiorFrequencia = array[0];
            int frequencia = 1;
            int conta;

            Console.WriteLine("Array: { 2, 4, 5, 5, 5, 7, 8, 9, 5, 2, 2, 4, 4, 5, 6, 5 }");


            for (int i = 0; i < array.Length; i++)
            {
                conta = 0;
                for (int j = 0; j < array.Length; j++)
                {

                    if (array[j] == array[i])
                    {
                        conta++;
                    }
                }
                if (conta > frequencia)
                {
                    frequencia = conta;
                    valorMaiorFrequencia = array[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Número com maior repetição: {0}", valorMaiorFrequencia);
            Console.WriteLine("Qtd. de repetição: {0}", frequencia);
            Console.ReadLine();
        }

        //4ª Questão
        public void questao04()
        {
            Console.WriteLine();
            Console.WriteLine("Questão 4: ");
            Console.WriteLine("Escreva um programa que cria um array contendo todas as letras do alfabeto (A-Z). Leia uma palavra do console e imprima o índice de cada letra que a compõe. ");
            Console.WriteLine();

            char[] arrayAlfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string palavra = "";

            Console.Write("Digite uma palavra: ");
            palavra = Console.ReadLine();
            palavra = palavra.ToLower();

            Console.WriteLine();

            for (int i = 0; i < palavra.Length; i++)
            {
                Console.WriteLine("letra {0} posição {1} ", palavra[i], Array.IndexOf(arrayAlfabeto, palavra[i]));
            }

            Console.ReadLine();
        }


        //5ª Questão
        public void questao05()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Questão 5: ");
            Console.WriteLine("Escreva um programa que preencha uma matriz de tamanho (N, N) conforme exemplos (for N=4): ");
            Console.WriteLine();

            // Preenchendo na declaração da matriz
            int[,] matrizA = {  {16, 15, 13, 10},
                                {14, 12, 9,   6 },
                                {11,  8, 5,   3 },
                                {7,   4, 2,   1} };

            // Preenchendo celula a celula
            int[,] matrizB = new int[4, 4];
            matrizB[0, 0] = 7;
            matrizB[1, 0] = 4;
            matrizB[2, 0] = 2;
            matrizB[3, 0] = 1;

            matrizB[0, 1] = 11;
            matrizB[1, 1] = 8;
            matrizB[2, 1] = 5;
            matrizB[3, 1] = 3;

            matrizB[0, 2] = 14;
            matrizB[1, 2] = 12;
            matrizB[2, 2] = 9;
            matrizB[3, 2] = 6;

            matrizB[0, 3] = 16;
            matrizB[1, 3] = 15;
            matrizB[2, 3] = 13;
            matrizB[3, 3] = 10;

            int[,] matrizC = {  { 1, 12, 11, 10},
                                { 2, 13, 16,  9 },
                                { 3, 14, 15,  8 },
                                { 4,  5, 6,   7} };


            for (int l = 0; l < 4; l++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("{0}  ", matrizA[l, c]);
                }

                Console.WriteLine("");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int l = 0; l < 4; l++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("{0}  ", matrizB[l, c]);
                }

                Console.WriteLine("");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int l = 0; l < 4; l++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("{0}  ", matrizB[l, c]);
                }

                Console.WriteLine("");
            }


            Console.ReadLine();

        }

        //6ª Questão
        public void questao06()
        {
            Console.WriteLine();
            Console.WriteLine("Questão 6: ");
            Console.WriteLine("Escreva um programa que conta quantas vezes uma palavras aparece em uma frase recebido no console. ");
            Console.WriteLine("Não deve ser feita distinção entre maiúsculas e minúsculas. ");
            Console.WriteLine("O resultado deve ser ordenado pelo número de incidências da palavra. ");
            Console.WriteLine();

            string frase;
            string[] palavras;
            char[] delimitadores = new char[] { ' ', ',', '.', '!', '?', };

            // Lista para a quebra da frase em palavras e a quantidade de repetição
            List<string> palavra = new List<string>();
            List<int> repeticao = new List<int>();

            // Lista para o resultado final
            List<string> palavraFinal = new List<string>();
            List<int> repeticaoFinal = new List<int>();

            int menor;
            int indiceMenor;
            int i;



            // Variáveis auxiliares para contar as palavras
            int c = 0;
            string aux;

            Console.Write("Digite uma frase: ");
            frase = Console.ReadLine();
            frase = frase.ToLower();

            palavras = frase.Split(delimitadores);
            Array.Sort(palavras);

            c = 0;
            aux = "";

            foreach (string p in palavras)
            {

                if (!p.Equals(aux))
                {
                    palavra.Add(aux);
                    repeticao.Add(c);
                    c = 0;
                    aux = p;
                }
                c++;
            }

            // Última palavra (adiciona fora do laço)
            palavra.Add(aux);
            repeticao.Add(c);


            // Ordenação
            while (palavra.Count > 0)
            {
                i = 0;
                indiceMenor = 0;
                menor = repeticao.ElementAt(i);
                while (i < palavra.Count)
                {
                    if (repeticao.ElementAt(i) < menor)
                    {
                        menor = repeticao.ElementAt(i);
                        indiceMenor = i;
                    }

                    i++;
                }

                palavraFinal.Add(palavra.ElementAt(indiceMenor));
                repeticaoFinal.Add(repeticao.ElementAt(indiceMenor));

                palavra.RemoveAt(indiceMenor);
                repeticao.RemoveAt(indiceMenor);
            }



            // Exibe lista resultante 
            Console.WriteLine();
            for (int x = 0; x < palavraFinal.Count; x++)
            {
                // Retira da lista o delimitador " "
                if (palavraFinal.ElementAt(x).Equals(""))
                {
                    continue;
                }
                Console.WriteLine("{0} --> {1}", palavraFinal.ElementAt(x), repeticaoFinal.ElementAt(x));
            }

            Console.ReadLine();

        }
    }
}
