using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMS.Model
{
    class Expenses
    {
        public int dailyExpense {  get; set; }
        public int DailyGain { get; set; }
        public int Profit {  get; set; }

        public Expenses(int dailyExpense, int dailyGain, int Profit)
        {
            this.dailyExpense = dailyExpense;
            this.DailyGain = dailyGain;
            this.Profit = Profit;
        }
    }
}
