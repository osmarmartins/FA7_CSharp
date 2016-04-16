using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoII
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2ª Aula - Exercício 06
            Console.Clear();
            Console.WriteLine("Exercício 06");
            Console.WriteLine("============");
            Console.WriteLine();
            Console.WriteLine();

            Classe06 c05 = new Classe06();
            c05.questao01();
            c05.questao02();

        }
    }

    class Classe06
    {
        public void questao01()
        {
            int numero;
            try
            {
                Console.Write("Informe um número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("Raiz quadrada de {0} é {1}", numero, Math.Sqrt(numero));
            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possível calcular a raiz quadrada");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Good bye.");
                Console.ReadLine();
            }

        }

        public void questao02()
        {
            string num1, num2;
            int result;
            int n1, n2;

            Console.Write("Entre com o 1º número: ");
            num1 = Console.ReadLine();

            Console.Write("Entre com o 2º número: ");
            num2 = Console.ReadLine();
            
            try
            {
                n1 = int.Parse(num1);
                n2 = int.Parse(num2);
                result = n1 / n2;
                Console.WriteLine("Divisão de {0} por {1} é igual a {2}.", num1, num2, result);
                Console.ReadLine();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Valor acima do permitido!");
                Console.ReadLine();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divisão por zero. Operação Inválida!");
                Console.ReadLine();
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Operação de divisão inválida");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Operação inválida");
                Console.ReadLine();
            }
        }
    }
}
