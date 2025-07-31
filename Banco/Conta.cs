using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        //def dos atributos intesno da classe
        private Int32 Numero;
        private decimal LimiteCredito;
        private decimal Saldo;
        private int contadorConta;


        //criacao das prop da classe
        public Int32 numero {  
            get { return Numero; }
            set {  Numero = value; }
            }
        public decimal limiteCredito
        {
            get { return LimiteCredito;  }
            set { LimiteCredito = value; }
        }

        //criacao dos metodos classe conta
        public decimal saldo
        {
            get { return Saldo; }
            set { Saldo = value; }
        }
        public void Sacar(decimal valor)
        {
            //contadorConta++;
            saldo -= valor;

        }
        public void Depositar(decimal valor)
        {
            //contadorConta++;
            saldo += valor;
        }
        //metodo construtor da classe conta
    }
}
