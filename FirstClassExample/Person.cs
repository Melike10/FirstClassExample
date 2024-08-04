namespace FirstClassExample
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private DateOnly birthOfDate;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }

        }
        public DateOnly BirthOfDate
        {
            get { return birthOfDate; }
            set { birthOfDate = value; }
        }

    }
}
