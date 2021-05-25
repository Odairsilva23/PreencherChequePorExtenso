using System;
using System.Collections.Generic;


namespace PreencherChequePorExtenso.consoleApp
{
    public class Separador 
    {
        public string SeparadordeMilhoeseBilhoes(string extensoFinal, int i, int valorDoPedaço, string separador)
        {
            switch (i)
            {

                case 0:
                    if (valorDoPedaço == 1)
                        extensoFinal += " Bilhão" + separador;
                    else if (valorDoPedaço > 1)
                        extensoFinal += " Bilhões" + separador;
                    break;

                case 3:
                    if (valorDoPedaço == 1)
                        extensoFinal += " Milhão" + separador;
                    else if (valorDoPedaço > 1)
                        extensoFinal += " Milhões" + separador;
                    break;

                case 6:
                    if (valorDoPedaço > 0)
                        extensoFinal += " Mil" + separador;
                    break;

                default:
                    break;
            }

            return extensoFinal;
        }

        public void ContruirSeparador_e_E(string valorExtenso, int i, out int valorDoPedaço, out string separador)
        {
            valorDoPedaço = -1;
            separador = "";
            if (i < 9)
            {
                valorDoPedaço = Convert.ToInt32(valorExtenso.Substring(i, 3));
                if (Convert.ToDouble(valorExtenso.Substring(i + 3, 10 - i)) > 0)
                {
                    separador = " e ";
                }
            }
        }

        public double Contrutor(double valor, out string montagem, out string strValor, out int primeiroNumero, out int segundoNumero, out int terceiroNumero)
        {
            montagem = "";
            if (valor > 0 & valor < 1)
            {
                valor *= 100;
            }

            strValor = valor.ToString("000");
            primeiroNumero = Convert.ToInt32(strValor.Substring(0, 1));
            segundoNumero = Convert.ToInt32(strValor.Substring(1, 1));
            terceiroNumero = Convert.ToInt32(strValor.Substring(2, 1));
            return valor;
        }

        public string Centenas(string montagem, int primeiroNumero, int segundoNumero, int terceiroNumero)
        {
            string[] centenas = { "Cento", "Duzentos", "Trezentos", "Quatrocentos", "Quinhentos", "Seiscentos", "Setecentos", "Oitocentos", "Novecentos" };
            if (primeiroNumero == 1) montagem += (segundoNumero + terceiroNumero == 0) ? "Cem" : "Cento";
            else if (primeiroNumero > 0) montagem += centenas[primeiroNumero - 1];
            return montagem;
        }

        public static string Dezenas(string montagem, string strValor, int primeiroNumero, int segundoNumero, int terceiroNumero)
        {
            string[] dezenas = { "Dez", "Vinte", "Trinta", "Quarenta", "Cinquenta", "Sessenta", "Setenta", "Oitenta", "Noventa" };
            if (segundoNumero == 1)
            {
                string[] apartirDeDez = { "Dez", "Onze", "Doze", "Treze", "Quatorze", "Dezesseis", "Dezessete", "Dezoito", "Dezenove" };
                montagem += ((primeiroNumero > 0) ? " e " : string.Empty) + apartirDeDez[terceiroNumero];
            }
            else if (segundoNumero > 0) montagem += ((primeiroNumero > 0) ? " e " : string.Empty) + dezenas[segundoNumero - 1];

            if (strValor.Substring(1, 1) != "1" & terceiroNumero != 0 & montagem != string.Empty) montagem += " e ";
            return montagem;
        }

        public static string Unitario(string montagem, int terceiroNumero)
        {
            string[] unidades = { "Um", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove" };
            if (terceiroNumero > 0)
            {
                montagem += unidades[terceiroNumero - 1];
            }

            return montagem;
        }

        public string ExtencaoEscritaMontada(ref double valor)
        {
            if (valor <= 0)
                return "";
            else
            {
                string montagem, strValor;
                int primeiroNumero, segundoNumero, terceiroNumero;
                valor = Contrutor(valor, out montagem, out strValor, out primeiroNumero, out segundoNumero, out terceiroNumero);
                montagem = Centenas(montagem, primeiroNumero, segundoNumero, terceiroNumero);
                montagem = Dezenas(montagem, strValor, primeiroNumero, segundoNumero, terceiroNumero);
                montagem = Unitario(montagem, terceiroNumero);

                return montagem;
            }
        }

        public static string MetodoCentavoECentavos(string extensoFinal, string valorExtenso, int i)
        {
            if (i == 12)
            {

                int valorDoPedaço = Convert.ToInt32(valorExtenso.Substring(13, 2));
                if (valorDoPedaço == 1)
                {
                    extensoFinal += " Centavo";
                }
                else if (Convert.ToInt32(valorExtenso.Substring(13, 2)) > 1)
                {
                    extensoFinal += " Centavos";
                }
            }

            return extensoFinal;
        }

        public static string MetodoRealEReais(string extensoFinal, string valorExtenso, int i)
        {
            if (i == 9)
            {
                if (Convert.ToInt64(valorExtenso.Substring(0, 12)) == 1)
                    extensoFinal += " Real";
                else if (Convert.ToInt64(valorExtenso.Substring(0, 12)) > 1)
                    extensoFinal += " Reais";

                if (Convert.ToInt32(valorExtenso.Substring(13, 2)) > 0 && extensoFinal != string.Empty)
                    extensoFinal += " e ";
            }

            return extensoFinal;
        }


    }
}
