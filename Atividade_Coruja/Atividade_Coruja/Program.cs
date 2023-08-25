using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Coruja
{ 
    internal class Program
    {
        static void Main()
        {
            { 
            // Ler um número inteiro, depois imprima seu sucessor e seu antecessor.​​ 

            double d_num1 = 0;

            Console.Write("Digite um número qualquer: ");
            d_num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("O antecessor de {0} é {1} e o sucessor é {2}.", d_num1, d_num1 - 1, d_num1 + 1);
            Console.ReadLine();

            }


            { 

            // Ler nome, endereço e telefone e mostrar na ordem de entrada com os rotulos: Nome: Endereço: Telefone:

            string s_sn, s_end, s_num;

            Console.WriteLine("Nome: ");
            s_sn = Console.ReadLine();

            Console.WriteLine("Endereço: ");
            s_end = Console.ReadLine();

            Console.WriteLine("Número: ");
            s_num = Console.ReadLine();

            }

            {

            // Ler dois números inteiros e mostrar a soma, a subtração e a multiplicação. 

            Console.WriteLine("Digite o primeiro número inteiro:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int soma = num1 + num2;
            int subtracao = num1 - num2;
            int multiplicacao = num1 * num2;

            Console.WriteLine($"A soma é: {soma}");
            Console.WriteLine($"A subtração é: {subtracao}");
            Console.WriteLine($"A multiplicação é: {multiplicacao}");

            Console.ReadLine();

            }

            {

                // MCI


                Console.WriteLine("peso: ");
                Double d_pe = Convert.ToDouble( Console.ReadLine()); 

                Console.WriteLine("Altura: ");
                Double d_al = Convert.ToDouble( Console.ReadLine());

                Double imc1 = d_pe / Math.Pow(d_al, 2);

                Console.WriteLine($"O imc do individuo é: {imc1}");
                Console.ReadLine();

            }
    }
    }
}
