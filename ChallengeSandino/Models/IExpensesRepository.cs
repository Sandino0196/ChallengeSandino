using System.Collections.Generic;

namespace ChallengeSandino.Models
{
    public interface IExpensesRepository
    {
        Expenses GetExpenses(int ID);
        IEnumerable<Expenses> GetAllExpenses();
        Expenses Add(Expenses expenses);
        Expenses Update(Expenses expensesChanges);
        Expenses Delete(int ID);
    }
}