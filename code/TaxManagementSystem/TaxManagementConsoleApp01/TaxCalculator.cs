using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxManagementConsoleApp01
{
    public interface ITaxCalculator
    {
        double CalculateTax(int year, Gender gender, int income, int expense, int investment);
    }

    public class TaxCalculator2018 : ITaxCalculator
    {
        public double CalculateTax(int year,Gender gender, int income, int expense, int investment)
        {
            var taxableIncome = income - expense / 2 - investment;
            
            double tax = taxableIncome * 10 / 100.0;
            if (gender == Gender.Female)
                tax *= 0.9;
            return tax;
        }
    }

    public class TaxCalculator2019 : ITaxCalculator
    {
        public double CalculateTax(int year, Gender gender, int income, int expense, int investment)
        {
            var tax = income / 0.5;
            if (gender == Gender.Female)
                tax *= 0.8;
            return tax;
        }
    }
}
