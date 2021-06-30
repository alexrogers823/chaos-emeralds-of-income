namespace ChaosEmeraldsOfIncome.Controllers
{
    public interface IRentalIncomeRepo
    {
        IEnumerable<RentalIncome> GetAllRentalProperties();
        void AddRentalProperty();
        void EditRentalProperty();
    }
}
