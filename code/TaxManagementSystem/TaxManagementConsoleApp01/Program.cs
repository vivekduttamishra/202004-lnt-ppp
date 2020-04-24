using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxManagementConsoleApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            var calcProvider = new SmartTaxCalculatorProvider();
            var taxManager = new TaxManager()
            {
                FinanceSource = new DummyFinanceInfoSource(500000, 200000, 100000),
                TaxSubmitter = new ConsoleTaxSubmitter(),
                TaxCalculatorProvider = calcProvider
            };
            

            String pan = "M1234";
            int year = 2018;
           
            taxManager.FileTax(pan, year);
            taxManager.FileTax(pan, 2019);

            taxManager.FileTax("F1234", 2018);
            taxManager.FileTax("F1234", 2019);

            calcProvider.AddCalculator(2020, new TaxCalculator2018()); //same formula as year 2018
            
            taxManager.FileTax("F1234", 2020);
        }
    }
}
