using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxManagementConsoleApp01
{
    public interface ITaxCalculatorProvider
    {
        ITaxCalculator ForYear(int year);
    }

    public class SimpleTaxCalculatorProvider : ITaxCalculatorProvider
    {
        public ITaxCalculator ForYear(int year)
        {
            if (year == 2018)
                return new TaxCalculator2018();
            else if (year == 2019)
                return new TaxCalculator2019();
            else
                throw new Exception("No Tax calculator for year " + year);
        }
    }

    public class SmartTaxCalculatorProvider : ITaxCalculatorProvider
    {
        Dictionary<int, ITaxCalculator> calculators = new Dictionary<int, ITaxCalculator>();
        public SmartTaxCalculatorProvider()
        {
            AddCalculator(2018, new TaxCalculator2018());
            AddCalculator(2019, new TaxCalculator2019());
        }
        public void AddCalculator(int year, ITaxCalculator calc)
        {
            calculators[year] = calc;
        }

        public ITaxCalculator ForYear(int year)
        {
            if (calculators.ContainsKey(year))
                return calculators[year];
            else
                throw new Exception("No calculator for year " + year);
        }
    }


}
