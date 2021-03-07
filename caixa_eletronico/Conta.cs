using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace caixa_eletronico
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public Conta(int numero, string nome, double valor)
        {
            Numero = numero;
            Nome = nome;
            Valor = valor;
        }


        //public Conta(int numero, string nome)
        //{
        //    Numero = numero;
        //    Nome = nome;
            
        //}

        //public Conta (int numero, string nome, double valor) : this(numero, nome)
        //{
        //    Valor = valor;
        //    deposito(valor);
        //}

        public void Deposito(double valor)
        {
            Valor += valor;
        }

        public void Debito(double valor)
        {
            //Valor -= valor + 5;

            Valor = (Valor - valor) - 5;
        }


        public override string ToString()
        {
            return "Conta " + Numero
                + ", " + "Titular : " + Nome + ", " + "Saldo : $ "
                + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }




    }
}
