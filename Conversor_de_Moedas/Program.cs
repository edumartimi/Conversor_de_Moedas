using System;

namespace Conversor_de_Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando variaveis
            string valordolar;
            string qtddolar;
            string stgiof;

            float qtdolar;
            float dolar;
            float IOF;
            float valoraserpago;
            float valortotal;


            //pegando a cotação do dolar com o usuario e atribuindo as variaveis
            Console.WriteLine("Qual é a cotação do dolar?");
            valordolar = Console.ReadLine();
            dolar = float.Parse(valordolar);

            // pegando a qtd de dolares a ser comprada
            Console.WriteLine("Quantos dolares voce ira comprar?");
            qtddolar = Console.ReadLine();
            qtdolar = float.Parse(qtddolar);



            //pegando o valor do IOF
            Console.WriteLine("Qual o valor do IOF");
            stgiof = Console.ReadLine();
            IOF = float.Parse(stgiof);
            IOF = IOF / 100;


            valoraserpago = qtdolar * dolar;
            valortotal = (valoraserpago * IOF)+valoraserpago;

            Console.WriteLine("VALOR A SER PAGO EM REAIS = "+valoraserpago);
            Console.WriteLine("VALOR TOTAL DA COMPRA COM IOF = " + valortotal);
            Console.ReadKey();


        }
    }
}
