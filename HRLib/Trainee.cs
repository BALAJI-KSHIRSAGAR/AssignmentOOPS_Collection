using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class Trainee : Employee
    {
        #region Properties
        private int noOfDays;

        public int NoOfDays
        {
            get { return noOfDays; }
            set { noOfDays = value; }
        }

        private double ratePerDay;

        public double RatePerDay
        {
            get { return ratePerDay; }
            set { ratePerDay = value; }
        }



        #endregion

        #region constructor
        public Trainee() : base()
        {
            NoOfDays = 110;
            RatePerDay = 456;
        }

        public Trainee(int _noOfDays, double _ratePerDay, string _name, string _address) : base(_name, _address)
        {
            this.NoOfDays = _noOfDays;

            this.RatePerDay = _ratePerDay;
        }

        #endregion


        public override double CalculateSalary()
        {
            return NoOfDays * RatePerDay;
        }
        public override string ToString()
        {
            return base.ToString() + $", No Of Days : {NoOfDays}, Rate Per Days: {RatePerDay}";
        }
    }
}
