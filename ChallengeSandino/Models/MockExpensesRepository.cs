using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChallengeSandino.Models
{
    public class MockExpensesRepository : IExpensesRepository
    {
        private readonly FinancesChallengeDBEntities1 finances;

        public MockExpensesRepository(FinancesChallengeDBEntities1 finances)
        {
            this.finances = finances;
        }

        public Expenses Add(Expenses expenses)
        {
            finances.Expenses.Add(expenses);
            finances.SaveChanges();
            return expenses;
        }

        public Expenses Delete(int ID)
        {
            Expenses expenses = finances.Expenses.Find(ID);
            if(expenses != null)
            {
                finances.Expenses.Remove(expenses);
                finances.SaveChanges();
            }
            return expenses;
        }

        public IEnumerable<Expenses> GetAllExpenses()
        {
            return finances.Expenses;
        }

        public Expenses GetExpenses(int ID)
        {
            return finances.Expenses.Find(ID);
        }

        public Expenses Update(Expenses expensesChanges)
        {
            var temp = finances.Expenses.Attach(expensesChanges);
            temp.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            finances.SaveChanges();
            return expensesChanges;
        }
    }
}