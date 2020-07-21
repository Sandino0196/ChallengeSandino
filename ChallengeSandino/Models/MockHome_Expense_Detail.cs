using System.Collections.Generic;

namespace ChallengeSandino.Models
{
    public class MockHome_Expense_Detail : IHome_Expenses_DetailRepository
    {
        private readonly FinancesChallengeDBEntities1 finances;

        public MockHome_Expense_Detail(FinancesChallengeDBEntities1 finances)
        {
            this.finances = finances;
        }

        public Home_Expense_Detail Add(Home_Expense_Detail expenses)
        {
            finances.Home_Expense_Detail.Add(expenses);
            finances.SaveChanges();
            return expenses;
        }

        public Home_Expense_Detail Delete(int ID)
        {
            Home_Expense_Detail expenses = finances.Home_Expense_Detail.Find(ID);
            if (expenses != null)
            {
                finances.Home_Expense_Detail.Remove(expenses);
                finances.SaveChanges();
            }
            return expenses;
        }

        public IEnumerable<Home_Expense_Detail> GetAllExpenses()
        {
            return finances.Home_Expense_Detail;
        }

        public Home_Expense_Detail GetExpenses(int ID)
        {
            return finances.Home_Expense_Detail.Find(ID);
        }

        public Home_Expense_Detail Update(Home_Expense_Detail expensesChanges)
        {
            var temp = finances.Home_Expense_Detail.Attach(expensesChanges);
            temp.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            finances.SaveChanges();
            return expensesChanges;
        }
    }
}