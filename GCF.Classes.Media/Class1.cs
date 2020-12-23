using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCF.Classes.Media
{
    public class Media
    {
        public decimal Valor1 { get; set; } //Propriedades valor1 e valor2 da classe Média
        public decimal Valor2 { get; set; }

        public Media()
        {

        } //Contrutor sem argumentos

        public Media(decimal valor1, decimal valor2) //Construtor com dois argumentos da classe Média
        {
            Valor1 = valor1;
            Valor2 = valor2; 
        }

        /// <summary>
        ///  Método para Calcular Media do aluno
        /// </summary>
        /// <returns></returns>
        public decimal CalcularMedia() 
        {
            return (Valor1+Valor2)/2;
        }

        public override string ToString()
        {
            return "(" + this.Valor1.ToString("F2") + " + " + this.Valor2.ToString("F2") + ") = " + this.CalcularMedia().ToString("F2");
        }
    }
}
