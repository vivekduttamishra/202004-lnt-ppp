using System;

namespace TaxManagementConsoleApp01
{
    public class TaxManagerV2
    {
        

        public void FileTax(string pan, int year)
        {
            //step-1 get financial details
            FinancialInfo info = FetchFinanceInfo(pan, year);

           
            //step-2 calcualte the tax
            double tax = CalculateTax(year,info.Gender, info.Income, info.Expense, info.Investment);

            //step-3 file tax
            FileTax(pan, year, tax);
        }

        private static void FileTax(string pan, int year, double tax)
        {
            Console.WriteLine("Tax Filed for {0} for year {1} : Rs{2}", pan, year, tax);
        }

        private static double CalculateTax(int year,Gender gender, int income, int expense, int investment)
        {
            var taxableIncome = income - expense / 2 - investment;
            var rate = year < 2018 ? 15 : 10;
            double tax = taxableIncome * rate / 100.0;
            if (gender == Gender.Female)
                tax *= 0.9;
            return tax;
        }

        private static FinancialInfo FetchFinanceInfo(string pan, int year)
        {
            var income = (int)(500000 *(1 + .1 * (year - 2015)));
            return new FinancialInfo()
            {
                Gender = pan.StartsWith("M") ? Gender.Male : Gender.Female,
                Income = income,
                Expense = 200000,
                Investment = 100000
            };
        }
    }
}