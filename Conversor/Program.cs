using System;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Perguntando a cotação do dólar atual + salvando em "ValorDolar".
            Console.Write("Qual a cotação do dólar atual? $");
            double ValorDolar = double.Parse(Console.ReadLine());
            //Perguntando a quantidade de dólares que o usuário irá comprar + salvando em "QuantidadeDolar".
            Console.Write("\nQuantos dólares você irá comprar? $");
            double QuantidadeDolar = double.Parse(Console.ReadLine());
            //Instanciando um novo conversor, junto de suas variáveis necessárias.
            Conversor convertor = new Conversor(ValorDolar, QuantidadeDolar);
            //Executando método comversão sem taxa e conversão com taxa.
            convertor.ConversaoSemTaxa();
            convertor.ConversaoComTaxa();
            //Mostrando os resultados na tela.
            Console.WriteLine(convertor.ToString());
        }
    }
}
