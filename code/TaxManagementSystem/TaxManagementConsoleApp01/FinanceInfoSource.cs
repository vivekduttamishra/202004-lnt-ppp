using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxManagementConsoleApp01
{
    public interface IFinanceInfoSource
    {
        FinancialInfo FetchFinanceInfo(string pan, int year);
    }

    public class DummyFinanceInfoSource : IFinanceInfoSource
    {
        int income, expense, investment;
        public DummyFinanceInfoSource(int income,int expenese,int investment)
        {
            this.income = income;
            this.expense = expenese;
            this.investment = investment;
        }
        
        public  FinancialInfo FetchFinanceInfo(string pan, int year)
        {
            
            return new FinancialInfo()
            {
                Gender = pan.StartsWith("M") ? Gender.Male : Gender.Female,
                Income = income,
                Expense = expense,
                Investment = investment
            };
        }
    }
}
