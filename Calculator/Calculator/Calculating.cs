using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculating
    {
        List<int> numberSave = new List<int>();
        List<string> Operator = new List<string>();
        int r = 0;
        int y = 0;
        int temptotal = 0;
        int x = 0;

        public void NumCollection(int NumChoice, string FuncChoice)
        {
            numberSave.Add(NumChoice);
            Operator.Add(FuncChoice);
        }
        public void SecondCollect(int NumChoice)
        {
            numberSave.Add(NumChoice);
        }

        public string clear()
        {
            numberSave.Clear();
            Operator.Clear();
            return "";
        }


        public int MakeCalculation()
        {
            for (int i = 0; i < (numberSave.Count - 1); i++)
            {
                if (temptotal == 0)
                {
                    x = numberSave[i];
                }
                else
                { x = temptotal; }
                var f = numberSave[i+1];
                if (Operator[y] == "/")
                { r = Divide.divided(x, f); }
                else if (Operator[y] == "*")
                { r = Multiply.multiply(x, f); }
                else if (Operator[y] == "+")
                { r = Add.add(x, f); }
                else if (Operator[y] == "-")
                { r = Subtract.subtract(x, f); }
                y++;
                temptotal = r;
            }

            numberSave.Clear();
            Operator.Clear();
            y = 0;
            temptotal = 0;

            return r;
            }
        }
    }

