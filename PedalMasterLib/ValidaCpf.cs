using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PedalMasterLib
{
    public class ValidaCpf
    {
        public string? Numero { get; set; }

        public static bool Validar(string cpf)
        {
            bool cpfValido = true;
           

            //Verificar se o CPF tem 11 digitos 
            if (cpf.Length != 11)
            {
                cpfValido = false;
            }
                

            if (cpfValido)
            {
                for (byte i = 0; i < 10; i++)
                {
                    var temp = new string(Convert.ToChar(i), 11);
                    if(cpf == temp)
                    {
                        cpfValido = false;
                        break;
                    }
                }
            }
            //verificar digito de controle de cpf
            if (cpfValido)
            {
                var j = 0;
                var d1 = 0;
                var d2 = 0;

                //Validar o primeiro numerio do digito de controle 
                for (int i = 10; i > 1; i--)
                {
                    d1 += Convert.ToInt32(cpf.Substring(j, 1)) * i;
                    j++;
                }

                //resto da divisão 
                d1 = (d1 * 10) % 11;
                if (d1 == 10)
                    d1 = 0;

                //Verificar se o primeiro numero bateu ------- posição 9 (penultima)
                if (d1 != Convert.ToInt32(cpf.Substring(9, 1)))
                    cpfValido = false;

                //validar o segundo numero (digito do controle)
                if (cpfValido)
                {
                    j = 0;
                    for (int i = 11; i > 1; i--)
                    {
                        d2 += Convert.ToInt32(cpf.Substring(j, 1)) * i;
                        j++;
                    }

                    //resto da divisao 
                    d2 = (d2 * 10) % 11;
                    if (d2 == 10)
                        d2 = 0;

                    //verificar se o segundo digito bateu -- posição 10 (ultimo)
                    if (d2 != Convert.ToInt32(cpf.Substring(10, 1)))
                        cpfValido = false;

                    if (TodosIguais(double.Parse(cpf)))
                    {
                        cpfValido = false;
                    }

                    
                }
                //MessageBox.Show(d1.ToString() + d2.ToString());
            }

            return cpfValido;
        }

        public static bool TodosIguais(double num)
        {
            char comparar = num.ToString()[0];
            foreach (var n in num.ToString())
            {
                if (comparar != n) { return false; }
            }
            return true;
        }
    }
}
