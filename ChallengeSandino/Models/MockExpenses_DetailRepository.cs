using System.Collections.Generic;

namespace ChallengeSandino.Models
{
    public class MockExpenses_DetailRepository : IExpense_DetailRepository
    {
        private readonly FinancesChallengeDBEntities1 finances;

        public MockExpenses_DetailRepository(FinancesChallengeDBEntities1 finances)
        {
            this.finances = finances;
        }

        public Expense_Detail Add(Expense_Detail expenses)
        {
            finances.Expense_Detail.Add(expenses);
            finances.SaveChanges();
            return expenses;
        }

        public Expense_Detail Delete(int ID)
        {
            Expense_Detail expenses = finances.Expense_Detail.Find(ID);
            if (expenses != null)
            {
                finances.Expense_Detail.Remove(expenses);
                finances.SaveChanges();
            }
            return expenses;
        }

        public IEnumerable<Expense_Detail> GetAllExpenses()
        {
            return finances.Expense_Detail;
        }

        public Expense_Detail GetExpenses(int ID)
        {
            return finances.Expense_Detail.Find(ID);
        }

        public Expense_Detail Update(Expense_Detail expensesChanges)
        {
            var temp = finances.Expense_Detail.Attach(expensesChanges);
            temp.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            finances.SaveChanges();
            return expensesChanges;
        }
    }
}