using System;

namespace TaxManagementConsoleApp01
{
    public class TaxManagerV1
    {
        

        public void FileTax(string pan, int year)
        {
            //step-1 get financial details
            Gender gender = pan.StartsWith("M") ? Gender.Male : Gender.Female;
            int income = 500000;
            int expense = 200000;
            int investment = 100000;

            //step-2 calcualte the tax
            var taxableIncome = income - expense / 2 - investment;
            var rate = year < 2018 ? 15 : 10;
            double tax = taxableIncome * rate / 100.0;
            if (gender == Gender.Female)
                tax *= 0.9;


            //step-3 file the tax
            Console.WriteLine("Tax Filed for {0} for year {1} : Rs{2}",pan,year,tax);
        }
    }
}