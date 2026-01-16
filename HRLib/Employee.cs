namespace HRLib
{
    public abstract class Employee
    {
        #region Properties

        // Static member to keep track of employee count and to check github status while learning git
        private static int count = 100;
        private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string address;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}

        private int empno;

        public int Empno
        {
            get { return empno; }
            private set { empno = value; }
        }



        #endregion


        #region Constructor
        public Employee()
        {
            Name = "Balaji";
            Address = "Latur";
            Empno = count++;
        }

        public Employee(string _name, string _address) : this()
        {
            this.Name = _name;
            this.Address = _address;
            
        }
        #endregion

        #region Methods

        public abstract double CalculateSalary();

        public override string ToString()
        {
            return $"Name : {Name}, Address: {Address}, EmpNo: {Empno}";
        }

        #endregion

    }
}
