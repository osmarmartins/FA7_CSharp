using System;
using System.Collections;
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
            /*
                        // 2ª Aula - Exercício 06
                        Console.Clear();
                        Console.WriteLine("Exercício 06");
                        Console.WriteLine("============");
                        Console.WriteLine();
                        Console.WriteLine();

                        Classe06 c06 = new Classe06();
                        c06.Questao01();
                        c06.Questao02();
       

            // 2ª Aula - Exercício 07
            Console.Clear();
            Console.WriteLine("Exercício 07");
            Console.WriteLine("============");
            Console.WriteLine();
            Console.WriteLine();

            Classe07 c07 = new Classe07();
            c07.Questao01();
            c07.Questao02();
*/
            Console.Clear();
            Console.WriteLine("Exercício 08");
            Console.WriteLine("============");
            Console.WriteLine();
            Console.WriteLine();

            Classe08 c08 = new Classe08();
            c08.Questao02();
            


        }
    }


    //Exercicios 06
    class Classe06
    {
        public void Questao01()
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

        public void Questao02()
        {
            string num1, num2;
            float result;
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





    //Exercício 07

    // Classe IEnumerable a ser usada na 2ª questão
    public class ListaValores : IEnumerable
    {
        private List<int> _valores = new List<int>();
        private int _index = 0;

        public void Add(int valor)
        {
            this._valores.Add(valor);
            this._index = this._index + 1;
        }

        public int Count()
        {
            return _valores.Count;
        }

        public int First()
        {
            return _valores[0];
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _index; i++)
                yield return this._valores[i];
        }
    }

    // Classe de métodos de extensão
    public static class Classe07Extensions
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            str.Remove(0, index);
            str.Remove(length, str.Length - length);
            return str;
        }


        public static int Soma(this ListaValores valores)
        {
            int soma = 0;
            foreach (int valor in valores)
            {
                soma += valor;
            }

            return soma;
        }


        public static int Produto(this ListaValores valores)
        {
            int produto = 1;
            foreach (int valor in valores)
            {
                produto *= valor;
            }

            return produto;
        }


        public static int Maximo(this ListaValores valores)
        {
            int maior = valores.First();

            foreach (int valor in valores)
            {
                if (valor > maior)
                {
                    maior = valor;
                }
            }
            return maior;
        }


        public static int Minimo(this ListaValores valores)
        {
            int menor = valores.First();
            foreach (int valor in valores)
            {
                if (valor < menor)
                {
                    menor = valor;
                }
            }
            return menor;
        }


        public static float Media(this ListaValores valores)
        {
            float media = (float)valores.Soma() / valores.Count();
            return media;
        }
    }


    class Classe07
    {
        public void Questao01()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Osmar ");
            sb.Append("de Oliveira ");
            sb.Append("Martins ");
            sb.Append("Filho");

            Console.WriteLine("String: {0}", sb);
            Console.WriteLine("Substring(9, 16): {0}", sb.Substring(9, 16));
            Console.ReadLine();
        }




        public void Questao02()
        {
            var valores = new ListaValores();
            valores.Add(10);
            valores.Add(8);
            valores.Add(12);
            valores.Add(2);
            valores.Add(3);

            Console.WriteLine("Valores");
            foreach (var valor in valores)
            {
                Console.WriteLine(valor);
            }

            Console.WriteLine("Soma: {0}", valores.Soma());
            Console.WriteLine("Produto: {0}", valores.Produto());
            Console.WriteLine("Máximo: {0}", valores.Maximo());
            Console.WriteLine("Minimo: {0}", valores.Minimo());
            Console.WriteLine("Média: {0}", valores.Media());
            Console.ReadLine();


        }

        public void Questao03()
        {
            List<string> estudantes = new List<string>();
            estudantes.Add("Osmar de Oliveira Martins Filho");
            estudantes.Add("Magalli Carmen Memória");
            estudantes.Add("Ticiana Costa Martins");
            estudantes.Add("Osmar de Oliveira Martins Neto");

            Console.WriteLine("Relação de Estudantes");
            Console.WriteLine("=====================");
            foreach (string estudante in estudantes)
            {
                Console.WriteLine(estudante);
            }
            Console.ReadLine();



        }
    }





    // Exercício 08 -  Questão 01
    
    // Classe escola
    public class Pessoa
    {
        private string nome;

        public Pessoa(string nome)
        {
            this.nome = nome;
        }
    }

    public class Escola
    {
        private List<Classe> classes;

        public Escola(List<Classe> classes)
        {
            this.classes = classes;
        }
    }

    public class Classe
    {
        private string idClasse;
        private List<Professor> professores;

        public Classe(string idClasse, List<Professor> professores)
        {
            this.idClasse = idClasse;
            this.professores = professores;
        }
    }

    public class Estudante : Pessoa
    {
        private int idEstudante;

        public Estudante(int idEstudante, string nome):base(nome)
        {
            this.idEstudante = idEstudante;
        }

    }

    public class Professor : Pessoa
    {
        private List<Disciplina> disciplinas;

        public Professor(string nome, List<Disciplina> disciplinas  ):base(nome)
        {
            this.disciplinas = disciplinas;
        }
    }

    public class Disciplina
    {
        private string nome;
        private int numeroAulas;
        private int exercicios;

        public Disciplina(string nome, int numeroAulas, int exercicios)
        {
            this.nome = nome;
            this.numeroAulas = numeroAulas;
            this.exercicios = exercicios;
        }
    }

    // Exercício 08 -  Questão 02
    public abstract class Shape
    {
        private int witdh;
        private int height;

        public int Witdh { get; set; }
        public int Height { get; set; }

       public Shape(int width, int heigth)
        {
            this.witdh = width;
            this.height = heigth;
        }

        public abstract float CalculateSurface();

    }

    public class Triangle : Shape
    {
        public Triangle(int width, int heigth) : base(width, heigth)
        {
            this.Witdh = width;
            this.Height = heigth;
        }

        public override float CalculateSurface()
        {
            return this.Witdh * this.Height/2;
        }
    }

    public class Retangle : Shape
    {
        public Retangle(int width, int heigth) : base(width, heigth)
        {
            this.Witdh = width;
            this.Height = heigth;
        }

        public override float CalculateSurface()
        {
            return this.Witdh * this.Height;
        }
    }

    public class Circle : Shape
    {
        public Circle(int width, int heigth) : base(width, heigth)
        {
            this.Height = width;
            this.Witdh = width;
        }

        public override float CalculateSurface()
        {
            return (float)3.14 * this.Height * this.Height;
        }
    }

    class Classe08
    {
        public void Questao02()
        {
            var shapes = new[] {
                new { width=2, height=3 },
                new { width=5, height=13 },
                new { width=20, height=5 },
                new { width=10, height=7 }
            };

            Triangle triangle;
            Retangle retangle;
            Circle circle;


            foreach (var shape in shapes)
            {
                triangle = new Triangle(shape.width, shape.height);
                retangle = new Retangle(shape.width, shape.height);
                circle = new Circle(shape.width, shape.height);
                    
                Console.WriteLine("Largura: {0}, Altura: {1}", shape.width, shape.height);
                Console.WriteLine("Área Retângulo: {0}", retangle.CalculateSurface());
                Console.WriteLine("Área Triângulo: {0}", triangle.CalculateSurface());

                Console.WriteLine("Raio: {0}", shape.width);
                Console.WriteLine("Área Circunferência: {0}", circle.CalculateSurface());
                Console.WriteLine("");

            }

            Console.ReadLine();
                
        }
    }



}
