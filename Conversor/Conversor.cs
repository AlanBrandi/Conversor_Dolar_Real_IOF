using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Conversor
{
    class Conversor
    {
        //Variáveis utilizadas dentro da classe conversor
        private double TotalemReais;
        private double TotalComTaxa;
        private double ValorTaxa;
        //Cotação IOF (Hard Code)
        //https://agenciabrasil.ebc.com.br/economia/noticia/2021-09/comecam-a-valer-hoje-novas-aliquotas-do-IOF
        public double IOF = 0.0408;

        //Encapsulamento Cotação e Quantidade de dólares.
        public double CotacaoDolar { get; set; }
        public double QuantidadeDolar { get; set; }

        //Construtor personalizado.
        public Conversor(double cotacaoDolar, double quantidaDolar)
        {
            CotacaoDolar = cotacaoDolar;
            QuantidadeDolar = quantidaDolar;
        }
        //Método conversão sem taxa.
        public void ConversaoSemTaxa()
        {
            TotalemReais = CotacaoDolar * QuantidadeDolar;
        }
        //Método conversão com taxa.
        public void ConversaoComTaxa()
        {
            ValorTaxa = (TotalemReais * IOF);
            TotalComTaxa = ValorTaxa + TotalemReais;
        }
        //Override ToString.
        public override string ToString()
        {
            return "Valor a ser pago em reais = " + TotalemReais.ToString("C2") + "\nValor a ser pago de IOF = " + ValorTaxa.ToString("C2") + "(4,08%) " + "\nValor total da compra com IOF = " + TotalComTaxa.ToString("C2");
        }
    }
}
