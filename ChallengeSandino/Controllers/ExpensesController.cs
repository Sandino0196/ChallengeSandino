using FinancesDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChallengeSandino.Controllers
{
    //[Authorize]
    public class ExpensesController : ApiController
    {
        public IEnumerable<Expenses> Get()
        {
            using (FinancesChallengeDBEntities finances = new FinancesChallengeDBEntities())
            {
                return finances.Expenses.ToList();
            }
        }
    }
}
