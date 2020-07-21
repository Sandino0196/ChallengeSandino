using System.Collections.Generic;

namespace ChallengeSandino.Models
{
    public interface IHome_Expenses_DetailRepository
    {
        Home_Expense_Detail GetExpenses(int ID);
        IEnumerable<Home_Expense_Detail> GetAllExpenses();
        Home_Expense_Detail Add(Home_Expense_Detail expenses);
        Home_Expense_Detail Update(Home_Expense_Detail expensesChanges);
        Home_Expense_Detail Delete(int ID);
    }
}