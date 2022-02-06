using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class ContinueQuestion
    {
        public bool  Question()
        {
            int OptionContinueQuestion;
            Boolean ContinueOption = false;
            
                
                Console.WriteLine("Desea continuar? (1 = Si / 2 = No)");
                OptionContinueQuestion = int.Parse(Console.ReadLine());
                if (OptionContinueQuestion == 1)
                {
                    return  true;
                }
                else
                {
                    return  false;
                }


            } 
        }
    }

