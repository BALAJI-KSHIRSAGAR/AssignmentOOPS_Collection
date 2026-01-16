using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class ConfirmEmployee : Employee
    {
        #region properties

        private double basic;

        public double Basic
        {
            get { return basic; }
            set {
                if (value < 5000)
                {
                    throw new MinimumBasicException("Basic is less than minimum threshold.");
                } 
                basic = value; }
        }

        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }


        #endregion

        #region Constructor

        public ConfirmEmployee() : base() 
        {
            Basic = 100;
            Designation = "manager";
        }

        public ConfirmEmployee(double _basic, string _designation, string _name, string _address) : base(_name,_address) 
        {
            this.Basic = _basic;
            this.Designation = _designation;    
        }

        #endregion
        public sealed override double CalculateSalary()
        {
            double hra, conv, pf;
            if (Basic >= 30000)
            {
                hra = Basic * 0.30;
                conv = Basic * 0.30;
                pf = Basic * 0.10;
            } else if (Basic >= 20000)
            {
                hra = Basic * 0.20;
                conv = Basic * 0.20;
                pf = Basic * 0.10;
            }
            else
            {
                hra = Basic * 0.10;
                conv = Basic * 0.10;
                pf = Basic * 0.10;
            }
            return Basic + hra + conv - pf;
        }
        public override string ToString()
        {
            return base.ToString()+$", Basic : {Basic}, Designation: {Designation}";
        }
    }
}
