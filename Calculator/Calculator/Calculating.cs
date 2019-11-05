using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculating
    {
        List<double> numberSave = new List<double>();
        List<string> Operator = new List<string>();
        double r = 0;
        int y = 0;
        double temptotal = 0;
        double x = 0;

        public void NumCollection(double NumChoice, string FuncChoice)
        {
            numberSave.Add(NumChoice);
            Operator.Add(FuncChoice);
        }
        public void SecondCollect(double NumChoice)
        {
            numberSave.Add(NumChoice);
        }

        public string clear()
        {
            numberSave.Clear();
            Operator.Clear();
            temptotal = 0;
            return "";     
        }
        public string FuncPlusMin(string r)
        {
            if (r.IndexOf('-') == -1)
            {
                r = ("-" + r);
            }
            else
            {
                
            }
            return r;
        }
        public double SingleCalculation(double NumChoice, string FuncChoice) // single number functions
        {
            numberSave.Add(NumChoice);
            Operator.Add(FuncChoice);
            var i = 0;
            if (temptotal ==0)
            {
                x = numberSave[i];
            }
            else
            {
                x = temptotal;
            }
            if (Operator[y] == "√")
            {
                r = Math.Sqrt(x);
            }
            else if (Operator[y] == "^2")
            {
                r = Math.Pow(x, 2);
            }
            else if (Operator[y] == "^3")
                {
                r = Math.Pow(x, 3);
            }
            i++;
            temptotal = r;
            Operator.Clear();
            return r;

        }
        public double MakeCalculation()
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

