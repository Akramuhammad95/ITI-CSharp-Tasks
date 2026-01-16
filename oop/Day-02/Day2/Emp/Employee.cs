namespace Day2.Emp
{
    class Employee
    {
        public short ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        public string SSN { get; set; }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{ID} ,  {FirstName} {LastName} , {Title} , {Salary} \n";
        }

    }

   
}