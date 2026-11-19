using Microsoft.Maui.Graphics.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Class1
    {
        int pont = 0;

        public void adicionar()
        {
            pont++;
        }

        public Boolean checar(int questao, int resposta)
        {
            if (questao == 1) { if(resposta == 3) { return true; } else { return false; } }
            else if (questao == 2) { if (resposta == 4) { return true; } else { return false; } }
            else if (questao == 3) { if (resposta == 2) { return true; } else { return false; } }
            else if (questao == 4) { if (resposta == 4) { return true; } else { return false; } }
            else if (questao == 5) { if (resposta == 2) { return true; } else { return false; } }
            else if (questao == 6) { if (resposta == 1) { return true; } else { return false; } }
            else if (questao == 7) { if (resposta == 1) { return true; } else { return false; } }
            else if (questao == 8) { if (resposta == 4) { return true; } else { return false; } }
            else if (questao == 9) { if (resposta == 2) { return true; } else { return false; } }
            else if (questao == 10) { if (resposta == 1) { return true; } else { return false; } }
            else
            {
                return false;
            }
        }


        public void formatar(Boolean isCorrect, RadioButton[] rbs, Label lblResultado, int resposta)
        {
            if (isCorrect)
            {
                adicionar();
                for (int i = 0; i < rbs.Length; i++)
                {
                    rbs[i].TextColor = Colors.Red; 
                }
                rbs[resposta - 1].TextColor = Colors.Green;
                
                lblResultado.Text = "Correta!";
                lblResultado.TextColor = Colors.Green;

                for (int i = 0; i < rbs.Length; i++)
                {
                    rbs[i].IsEnabled = false;
                }
                
            }
            else
            {
                for (int i = 0; i < rbs.Length; i++)
                {
                    rbs[i].TextColor = Colors.LightGray;
                }

                lblResultado.Text = "Errada!";
                lblResultado.TextColor = Colors.Red;

                for (int i = 0; i < rbs.Length; i++)
                {
                    rbs[i].IsEnabled = false;
                }
            }
        }
    }
}
