namespace ChaosEmeraldsOfIncome.Controllers
{
    public interface IEarnedIncomeRepo
    {
        IEnumerable<EarnedIncome> GetEarnedIncome();
    }
}