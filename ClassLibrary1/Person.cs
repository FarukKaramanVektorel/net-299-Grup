namespace ClassLibrary1
{
    public class Person
    {
        public string  Name { get; set; }
		private double _salary;

        public Person(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public double Salary
		{
			get { return _salary; }
			set { _salary = value; }
		}
        protected double maasHesapla()
        {
            return Salary * 1.2;
        }

        public virtual double maasHesapla2()
        {
            return Salary * 1.2;
        }
        public override string ToString()
        {
            return $"{Name} - {Salary:C2}";
        }
	}
}
