using System.Collections.Generic;

namespace ChallengeSandino.Models
{
    public interface IExpense_DetailRepository
    {
        Expense_Detail GetExpenses(int ID);
        IEnumerable<Expense_Detail> GetAllExpenses();
        Expense_Detail Add(Expense_Detail expenses);
        Expense_Detail Update(Expense_Detail expensesChanges);
        Expense_Detail Delete(int ID);
    }
}