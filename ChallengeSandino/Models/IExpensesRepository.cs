using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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