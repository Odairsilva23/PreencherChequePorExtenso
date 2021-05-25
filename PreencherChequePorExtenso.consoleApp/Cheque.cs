using System.Collections.Generic;
using System;

namespace PreencherChequePorExtenso.consoleApp
{
    public class Cheque : Separador
    {
        public string ChequePorExtenso(double valor)
        {
            string extensoFinal = "";
            string valorExtenso = valor.ToString("000000000000.00");

            return CriandoValorPorExtenso(valor, ref extensoFinal, valorExtenso);

        }

        public string CriandoValorPorExtenso(double valor, ref string extensoFinal, string valorExtenso)
        {
            return ValorPorExtenso(valor, ref extensoFinal, valorExtenso);
        }

        public string ValorPorExtenso(double valor, ref string extensoFinal, string valorExtenso)
        {
            if (valor <= 1000000000000 && valor > 0)
            {

                for (int i = 0; i <= 12; i += 3)
                {
                    extensoFinal = MetedoExtensoFinal(extensoFinal, valorExtenso, i);

                    extensoFinal = MetodoRealEReais(extensoFinal, valorExtenso, i);

                    extensoFinal = MetodoCentavoECentavos(extensoFinal, valorExtenso, i);
                }
                return extensoFinal;
            }
            else
            {
                return "Valor inválido!";
            }
        }

        public string MetedoExtensoFinal(string extensoFinal, string valorExtenso, int i)
        {
            extensoFinal += Escrevendo(Convert.ToDouble(valorExtenso.Substring(i, 3)));

            if (extensoFinal != "")
            {
                int valorDoPedaço;
                string separador;
                ContruirSeparador_e_E(valorExtenso, i, out valorDoPedaço, out separador);

                extensoFinal = SeparadordeMilhoeseBilhoes(extensoFinal, i, valorDoPedaço, separador);
            }

            return extensoFinal;
        }

        public string Escrevendo(double valor)
        {
            return ExtencaoEscritaMontada(ref valor);

        }

    }
}
