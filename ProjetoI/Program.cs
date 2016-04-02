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
            Classe04 c4 = new Classe04();
        }
    }

    class Classe00
    {
        // Exercicio 
    }

    class Classe01
    {

    }

    class Classe02
    {
        void metodo01()
        {
            string str1 = "Hello";
            string str2 = "World";
            object obj = str1 + " " + str2;
            string str3 = (string) obj;
        }

    }

    class Classe03
    {
        // 1ª Questão
        void maiorValorDeCinco()
        {
            int maiorValor;
            int vl1 = 2;
            int vl2 = 6;
            int vl3 = 2;
            int vl4 = 8;
            int vl5 = 1;

            maiorValor = vl1;

            if (vl2 > maiorValor){ maiorValor = vl2; }
            if (vl3 > maiorValor) { maiorValor = vl3; }
            if (vl4 > maiorValor) { maiorValor = vl4; }
            if (vl5 > maiorValor) { maiorValor = vl5; }

            Console.WriteLine("Maior valor encontrado: " + maiorValor);

        }

        // 2ª Questão CONCLUIR
        void fatorBonus(int escore)
        {
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
                    break;


            }



        }

    }

    class Classe04
    {
        // 1ª Questão
        void naoDivisiveisPorTresSete()
        {
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i< n; i++)
            {
                if ((i % 3 == 0)||(i % 7 == 0)){
                    continue;
                }

                Console.WriteLine("Número não divisível por 3 e 7: {0}", i);
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


