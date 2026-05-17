using SecondTask.Model;
using SecondTask.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask.Utility
{
    internal class SuitcaseMethods
    {
        public void Execute()
        { 
            Suitcase suitcase = new Suitcase("Red", "What", 30.0, 5);

            SuitcaseService suitcaseService = new SuitcaseService();

            suitcase.SuitcaseChanged += InformationPrinter.OnSuitcaseChangedListener;

            try
            {
                for (int i = 0; i < suitcase.items.Length; i++)
                { 
                    Item randomItem = MakeData.GetRandomItem();

                    suitcase.Add(suitcase, randomItem);
                }
            }
            catch (Exception ex)
            {
                InformationPrinter.PrintException(ex.Message);
            }

            Console.WriteLine("\nSuitcase now:");
            InformationPrinter.PrintSuitcaseState(suitcase, suitcaseService);

        }
    }
}
    

