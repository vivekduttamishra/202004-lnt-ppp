namespace TaxManagementConsoleApp01
{
    public class FinancialInfo
    {
        public FinancialInfo()
        {
        }

        public Gender gender { get; set; }
        public Gender Gender { get; internal set; }
        public int Income { get; internal set; }
        public int Expense { get; internal set; }
        public int Investment { get; internal set; }
    }
}