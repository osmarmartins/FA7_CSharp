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
            /*
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
            */

            // 1ª Aula - Exercício 04
            Console.Clear();
            Console.WriteLine("Exercício 04");
            Console.WriteLine("============");
            Console.WriteLine();
            Console.WriteLine();

            Classe04 c04 = new Classe04();
//            c04.questao01();
//            c04.questao02();
//            c04.questao03();
            c04.questao04();


        }
    }

    class Classe00
    {
        public void exercicios()
        {
            Console.WriteLine("1- O que é a Common Language Runtime (CLR)? Por que ela é uma parte importante do .NET Framework?");
            Console.WriteLine("R-");
            Console.WriteLine("próxima...");
            Console.ReadLine();

            Console.WriteLine("2- Descreva o processo de compilação de um programa C# para um assembly e o processo de execução de um assenbly.");
            Console.WriteLine("R-");
            Console.WriteLine("próxima...");
            Console.ReadLine();

            Console.WriteLine("3- O que é a MSIL? Aponte algumas características chaves.");
            Console.WriteLine("R-");
            Console.WriteLine("próxima...");
            Console.ReadLine();

            Console.WriteLine("4- O que é a Common Language Specification (CLS)? Por que ela foi desenvolvida?");
            Console.WriteLine("R-");
            Console.WriteLine("próxima...");
            Console.ReadLine();

            Console.WriteLine("5- O que é o Common Type System? Quando ele é utilizado?");
            Console.WriteLine("R-");
            Console.WriteLine("fim do exercício.");
            Console.ReadLine();

            /*

            1.O que é a Common Language Runtime (CLR) ? Por que
            ela é uma parte importante do .NET Framework

            R: É equivalente a JVM do Java.Isto é, responsável pela
            execução de assembly´s(byte codes).
            Esses assembly´s podem ser gerados a partir de qualquer linguagem
            de desenvolvimento existente no.NET
            Daí a sua importância.Sem ele não é possível a execução de aplicativos
            no.NET


            2.Descreva o processo de compilação de um programa C# para um assembly
            e o processo de execução de um assembly.

            R -


            3.O que é a linguagem MSIL? Aponte algumas características chaves

            R -


            4.O que é a Cammon Language Specification (CLS).Por que ela foi
            desenvolvida ?

            R - É as espeficação comum de liguagem.
            Como podemos desenvolver em diversas liguagens no.NET,
            (C#, J#, VB, Delphi, entre outras) se faz necessário uma 
            especificação a ser implementada em cada liguagem e assim, tornar
            as instruções comuns ao.NET
            Esta é a razão da existência da CLS.



            5.O que é o Cammon Type System ?
            Quando ele é utilizado ?

            R - Da mesma forma da CLS, a CTS foi desenvolvida para definir os tipos
            de dados(int, string, float, ...) comuns as diversas linguagens existentes
            no.NET
            Desta forma podemos usar o tipo "inteiro" nas diversas liguagens por meio
            da referência system.int
            */

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
            Console.WriteLine("Questão 2 - Modifique a aplicação para imprimir na tela o seu nome.");
            Console.WriteLine("Osmar de Oliveira Martins Filho (Mat.: 1581444");
            Console.ReadLine();
        }


        //3 - Escreva um programa para imprimir na tela os números 1, 101 e 1001.
        public void questao03()
        {
            Console.WriteLine("Questão 3 - Escreva um programa para imprimir na tela os números 1, 101 e 1001.");
            Console.WriteLine("1º Número: {0}", 1);
            Console.WriteLine("2º Número: {0}", 101);
            Console.WriteLine("3º Número: {0}", 1001);
            Console.ReadLine();

        }


        //4 - Crie uma aplicação console que imprime na tela a data e hora atual.
        public void questao04()
        {
            Console.WriteLine("Questão 4 - Crie uma aplicação console que imprime na tela a data e hora atual.");
            Console.WriteLine("Data e Hora atual: {0}", DateTime.Now);
            Console.ReadLine();
        }


        //5 - Crie uma aplicação console que calcula e imprime na tela o quadrado do número 12345, bem como sua raíz quadrada.
        public void questao05()
        {
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
            string str1 = "Hello";
            Console.WriteLine("1ª Variável string: {0}", str1);
            Console.ReadLine();

            string str2 = "World";
            Console.WriteLine("2ª Variável string: {0}", str2);
            Console.ReadLine();

            object obj = str1 + " " + str2;
            Console.WriteLine("Variável objeto: {0}", obj);
            Console.ReadLine();

            string str3 = (string) obj;
            Console.WriteLine("3ª Variável string: {0}", str3);
            Console.ReadLine();

        }

    }




    class Classe03
    {
        // 1ª Questão
        public void questao01()
        {
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

            if (vl2 > maiorValor){ maiorValor = vl2; }
            if (vl3 > maiorValor) { maiorValor = vl3; }
            if (vl4 > maiorValor) { maiorValor = vl4; }
            if (vl5 > maiorValor) { maiorValor = vl5; }

            Console.WriteLine("Maior valor encontrado: " + maiorValor);
            Console.ReadLine();

        }

        // 2ª Questão 
        public void questao02()
        {
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
            Console.Write("Informe um número: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Números não divisiveis por 3 e 7 entre 1 e {0}", n);
            for(int i=1; i< n; i++)
            {
                if ((i % 3 == 0)||(i % 7 == 0)){
                    continue;
                }

                Console.WriteLine(i);
            }

            Console.ReadLine();

        }

        public void questao02()
        {
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
            for (int i=1;i<n; i++)
            {
                Console.Write("Informe o {0}º elemento da sequência: ", i+1);
                numero = int.Parse(Console.ReadLine());

                if (numero<menor)
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

                Console.Write("{0} ", f1+f2);
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
            Console.Write("Informe um valor menor que 20: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 20)
            {
                for(int l=1;l< n+1; l++)
                {
                    for(int c= l;c<l+n; c++)
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
        int[] numeros = new int[20];

    }

}


