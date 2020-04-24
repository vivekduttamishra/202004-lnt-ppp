using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxManagementConsoleApp01
{

    public interface ITaxSubmitter
    {
        void SubmitTax(string pan, int year, double tax);
    }
    public class ConsoleTaxSubmitter : ITaxSubmitter
    {
        public void SubmitTax(string pan, int year, double tax)
        {
            Console.WriteLine("Tax Filed for {0} for year {1} : Rs{2}", pan, year, tax);
        }
    }
}
