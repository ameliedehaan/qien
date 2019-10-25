using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculating
    {
        static List<int> numberSave = new List<int>();
        static List<string> Operator = new List<string>();
        static public int result = 0;


        static public void NumCollection(int NumChoice, string FuncChoice)
        {
            numberSave.Add(NumChoice);
            Operator.Add(FuncChoice);
        }
        
        static public int MakeCalculation(int NumbChoice)
        {
            var r = 0;
            var y = 0;
            numberSave.Add(NumbChoice);
            for (int i = 0; i < (numberSave.Count - 1); i = +2)
            {
                var x = numberSave[i];
                var f = numberSave[i++];
                if (Operator[y] == "/")
                { r = Divide.divided(x, f); }
                else if (Operator[y] == "*")
                { r = Multiply.multiply(x, f); }
                else if (Operator[y] == "+")
                { r = Add.add(x, f); }
                else if (Operator[y] == "-")
                { r = Subtract.subtract(x, f); }
                y++;
            }
            return r;
            }
        }
    }
