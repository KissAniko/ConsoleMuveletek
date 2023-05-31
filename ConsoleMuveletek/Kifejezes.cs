﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMuveletek
{
    internal class Kifejezes
    {

        int operandusBal;
        string muvelet;
        int operandusJobb;
        private string sor;

        /*
        public Kifejezes(string csvSor) 
            : this(int.Parse(csvSor.Split()[0]), csvSor.Split()[1], int.Parse(csvSor.Split()[2]))
        {
        }*/

        public Kifejezes(string csvSor)
        {
            var mezok = csvSor.Split();
            this.operandusBal = int.Parse(mezok[0]);
            this.muvelet = mezok[1];
            this.operandusJobb = int.Parse(mezok[2]);
        }

        public Kifejezes(int operandusBal, string muvelet, int operandusJobb)
        {
            this.operandusBal = operandusBal;
            this.muvelet = muvelet;
            this.operandusJobb = operandusJobb;
        }

        public int OperandusBal { get => operandusBal; }
        public string Muvelet { get => muvelet; }
        public int OperandusJobb { get => operandusJobb; }

  /*      public string Eredmeny()
        {
            double? ered = null;
            try
            {
                switch (this.muvelet)
                {
                    case "+":
                        ered = operandusBal + operandusJobb;
                        break;
                    case "-":
                        ered = operandusBal - operandusJobb;
                        break;
                    case "*":
                        ered = operandusBal * operandusJobb;
                        break;
                    case "/":
                        if (operandusJobb == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        ered = (double)operandusBal / operandusJobb;
                        break;
                    case "mod":
                        ered = operandusBal % operandusJobb;
                        break;
                    case "div":
                        ered = operandusBal / operandusJobb;
                        break;
                }
                return $"{operandusBal} {muvelet} {operandusJobb} = {ered == null ? "Hibás operátor!" }";
                    
                   // $" {(ered == null ? "Hibás operátor!" : ered)}";
            }
            catch (Exception)
            {
                return $"{operandusBal} {muvelet} {operandusJobb} = Egyéb hiba!";
            }
        }   */
    }
}
