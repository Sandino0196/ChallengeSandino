using System.Collections.Generic;

namespace ChallengeSandino.Models
{
    public class MockHome_ExpensesRepository : IHome_ExpensesRepository
    {
        private readonly FinancesChallengeDBEntities1 finances;

        public MockHome_ExpensesRepository(FinancesChallengeDBEntities1 finances)
        {
            this.finances = finances;
        }

        public Home_Expenses Add(Home_Expenses expenses)
        {
            finances.Home_Expenses.Add(expenses);
            finances.SaveChanges();
            return expenses;
        }

        public Home_Expenses Delete(int ID)
        {
            Home_Expenses expenses = finances.Home_Expenses.Find(ID);
            if (expenses != null)
            {
                finances.Home_Expenses.Remove(expenses);
                finances.SaveChanges();
            }
            return expenses;
        }

        public IEnumerable<Home_Expenses> GetAllExpenses()
        {
            return finances.Home_Expenses;
        }

        public Home_Expenses GetExpenses(int ID)
        {
            return finances.Home_Expenses.Find(ID);
        }

        public Home_Expenses Update(Home_Expenses expensesChanges)
        {
            var temp = finances.Home_Expenses.Attach(expensesChanges);
            temp.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            finances.SaveChanges();
            return expensesChanges;
        }
    }
}