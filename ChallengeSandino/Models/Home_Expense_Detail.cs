//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChallengeSandino.Models
{
    using System;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    public partial class Home_Expense_Detail
    {
        internal EntityState State;

        public int ID_Home_Expense { get; set; }
        public string ID_User { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Spent_Money { get; set; }
    
        public virtual Home_Expenses Home_Expenses { get; set; }
    }
}
