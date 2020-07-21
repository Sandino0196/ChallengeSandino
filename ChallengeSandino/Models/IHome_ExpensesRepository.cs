using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSandino.Models
{
    public interface IHome_ExpensesRepository
    {
        Home_Expenses GetExpenses(int ID);
        IEnumerable<Home_Expenses> GetAllExpenses();
        Home_Expenses Add(Home_Expenses expenses);
        Home_Expenses Update(Home_Expenses expensesChanges);
        Home_Expenses Delete(int ID);
    }
}