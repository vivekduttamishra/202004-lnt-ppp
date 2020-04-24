using System;

namespace TaxManagementConsoleApp01
{
    public class TaxManager
    {
        public IFinanceInfoSource FinanceSource { get; set; }
        //public ITaxCalculator TaxCalculator { get; set; }
        public ITaxCalculatorProvider TaxCalculatorProvider { get; set; }
        public ITaxSubmitter TaxSubmitter { get; set; }

        

        public void FileTax(string pan, int year)
        {
            //step-1 get financial details            
            FinancialInfo info = FinanceSource.FetchFinanceInfo(pan, year);


            //step-2 calcualte the tax   
            var calculator = TaxCalculatorProvider.ForYear(year);
            double tax = calculator.CalculateTax(year,info.Gender, info.Income, info.Expense, info.Investment);

            //step-3 file tax            
            TaxSubmitter.SubmitTax(pan, year, tax);
        }

        

        

        
    }
}