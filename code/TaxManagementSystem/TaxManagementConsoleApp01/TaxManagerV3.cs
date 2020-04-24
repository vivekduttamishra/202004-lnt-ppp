using System;

namespace TaxManagementConsoleApp01
{
    public class TaxManagerV3
    {
       

        public void FileTax(string pan, int year)
        {
            //step-1 get financial details
            DummyFinanceInfoSource source = new DummyFinanceInfoSource(50000,20000,10000);
            FinancialInfo info = source.FetchFinanceInfo(pan, year);


            //step-2 calcualte the tax
            TaxCalculator2018 calculator = new TaxCalculator2018();
            double tax = calculator.CalculateTax(year,info.Gender, info.Income, info.Expense, info.Investment);

            //step-3 file tax
            ConsoleTaxSubmitter submitter = new ConsoleTaxSubmitter();
            submitter.SubmitTax(pan, year, tax);
        }

        

        

        
    }
}