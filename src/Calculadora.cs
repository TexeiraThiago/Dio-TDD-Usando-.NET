using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src
{
    public class Calculadora
    {   private List<string> listaHistorico;

    public Calculadora()
    {
        listaHistorico = new List<string>();
    }
        public int Somar(int num1, int num2)
        {   
            listaHistorico.Insert(0,$"Resultado {num1+num2}" );
            return num1 + num2;   
        }

        public int Subtrair(int num1, int num2)
        {
            listaHistorico.Insert(0,$"Resultado {num1-num2}" );
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            listaHistorico.Insert(0,$"Resultado {num1*num2}" );
            return num1 * num2;
        }
        
        public int Dividir(int num1, int num2)
        {
            listaHistorico.Insert(0,$"Resultado {num1/num2}");
            return num1 / num2;
        }


        public List<string> Historico()
        {   
            var size = listaHistorico.Count - 3;
            listaHistorico.RemoveRange(3,size);
            return listaHistorico;
        }
    }
}