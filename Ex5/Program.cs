using System;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 0;

            Console.WriteLine("Digite a altura da pessoa: ");
            double altura = Convert.ToDouble(Console.ReadLine());       
            Console.WriteLine("Digite o peso da pessoa: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o sexo da pessoa: [ M / F ]");
            char sexo = Convert.ToChar(Console.ReadLine());
            

            if( (sexo == 'M') || (sexo == 'm') )
            {
                result = (72.7 * altura) - 58;
                Console.WriteLine("O peso ideal é: {0}", result);
            }
            else if( (sexo == 'F') || (sexo == 'f') )
            {
                result = (62.1 * altura) - 44.7;
                Console.WriteLine("O peso ideal é: {0}", result);
            }
            else
            {
                Console.WriteLine("Sexo inválido");
            }
            Console.ReadLine();

        }
    }
}
