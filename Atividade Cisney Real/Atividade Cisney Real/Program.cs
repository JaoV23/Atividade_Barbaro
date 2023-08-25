using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Cisney_Real
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ler dois números inteiros e imprimir a soma. Antes do resultado, deverá aparecer a mensagem: “Soma: “ e depois na mesma linha o resultado. 

            Console.WriteLine("Digite o primeiro número inteiro:");
            int numero1 = int.Parse(Console.ReadLine()); //Int por ser um número inteiro

            Console.WriteLine("Digite o segundo número inteiro:");
            int numero2 = int.Parse(Console.ReadLine());

            int soma = numero1 + numero2;

            Console.WriteLine("Soma:");
            Console.WriteLine(soma);
            Console.ReadLine();

            // Ler um número real (número com vírgula) e imprimir a terça parte deste número

            Console.WriteLine("Digite um número real:");
            double numeroReal = double.Parse(Console.ReadLine());

            double tercaParte = numeroReal / 3;

            Console.WriteLine("A terça parte do número é:");
            Console.WriteLine(tercaParte);
            Console.ReadLine();

            // Entrar com dois números reais e imprimir a média aritmética. Antes do resultado, deverá aparecer a mensagem: “Média: “e depois na mesma linha o resultado. ​ 

            Console.WriteLine("Digite o primeiro número real:");
            double numero3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número real:");
            double numero4 = double.Parse(Console.ReadLine());

            double media = (numero3 + numero4) / 2;

            Console.Write("Média: ");
            Console.WriteLine(media);
            Console.ReadLine();

            // Fazer um programa que possa entrar com o saldo de uma aplicação e imprima o novo saldo, considerando o reajuste de 1% no saldo

            Console.WriteLine("Digite o saldo da aplicação:");
            double saldo = double.Parse(Console.ReadLine());

            double reajuste = saldo * 0.01; // 1% de reajuste
            double novoSaldo = saldo + reajuste;

            Console.WriteLine("Novo saldo após reajuste: " + novoSaldo);
            Console.ReadLine();

            // Entrar com as notas da NOTA_PROVA1, NOTA_PROVA2, NOTA_PROVA3 e NOTA_PROVA4 e imprimir a média final.  

            Console.WriteLine("Digite a nota da PROVA 1:");
            double notaProva1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da PROVA 2:");
            double notaProva2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da PROVA 3:");
            double notaProva3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da PROVA 4:");
            double notaProva4 = double.Parse(Console.ReadLine());

            double media1 = (notaProva1 + notaProva2 + notaProva3 + notaProva4) / 4;

            Console.WriteLine("Média Final: " + media1);
            Console.ReadLine();

        }
    }
}
