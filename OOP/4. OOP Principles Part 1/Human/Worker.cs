using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Worker :Human
    {
        // Field and his property
        private decimal weekSalary;

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }

        private int workHoursPerDay;

        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }
        
        // Constructor
        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) :base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        // Methods
        public decimal MoneyPerHour(decimal weekSalary, double workHourPerDay)
        {
            decimal earnedMoney = (decimal) weekSalary / (workHoursPerDay * 5);
            return earnedMoney;
        }



    }
}
