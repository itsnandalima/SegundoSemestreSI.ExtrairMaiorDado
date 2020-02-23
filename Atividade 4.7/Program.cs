using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4._7
{
    class Program
    {
        struct dados
        {
            public string nome;
            public string sexo;
            public int idade;
            public double altura;
        }
        static void Main(string[] args)
        {
            dados[] pessoas = new dados[50];
            int N;
            Console.Write("digite um numero de pessoas");
            N = int.Parse(Console.ReadLine());
            Valida(ref N, 50);
            Entrada(pessoas, N);
            nova(pessoas, N);
            alturaA(pessoas, N);
            Console.Write("\nmedia da altura{0}", media(pessoas, N));
            Console.Write("\npessoas com mais de 20 anos{0}", Msuperior(pessoas, N));
            Console.ReadKey();
        }
        static void Valida(ref int N, int max)
        {
            while (N < 1 || N > max)
            {
                Console.Write("Digite outro numero: ");
                N = int.Parse(Console.ReadLine());

            }

        }
        static void Entrada(dados[] X, int N)
        {
            for (int i = 0; i < N; i = i + 1)
            {
                Console.Write("Digite o nome: ");
                X[i].nome = Console.ReadLine();
                Console.WriteLine("\nDigite a idade: ");
                X[i].idade = int.Parse (Console.ReadLine());
                Console.WriteLine("\nDigite o sexo: ");
                X[i].sexo = Console.ReadLine();
                Console.WriteLine("\nDigite a altura: ");
                X[i].altura = double.Parse(Console.ReadLine());

            }

        }
        static void alturaA (dados[] x, int N)
        {
            double v;
            v = x[1].altura;
            for (int i = 1; i < N; i = i + 1)
            {
                if (v> x[i].altura)
                {
                    v = x[i].altura;
                }
            }
            Console.Write("\nmaior altura:{0}", v);
        }
        static void nova (dados[] x, int N)
        {
            double v;
            v = x[1].idade;
            int p;
            p = 1;
            for (int i = 1; i < N; i = i + 1)
            {
                if (v>x[i].idade)
                {
                    v = x[i].idade;
                    p = i;
                }
            }
            Console.Write("\nmaior idade:{0}", v);
            Console.Write("\nnome:{0}", x[p].nome);
            Console.Write("\nsexo:{0}", x[p].sexo);
        }
        static double media (dados [] x, int N)
        {
            double v;
            v = 0;           
                for (int i = 0; i < N; i = i + 1)
                {
                    if(x[i].altura<=1.58 )
                    {
                        v = v + x[i].altura;
                    }
                }
            double m;
            m = v / N;
            return m;
        }
        static int Msuperior (dados[] x, int N)
        {
            int v;
            v = 0;
            for (int i = 0; i < N; i = i + 1)
            {
                if (x[i].idade>=20)
                {
                    v = v + 1;
                }
            }
            //return v;
        }
    }
}
