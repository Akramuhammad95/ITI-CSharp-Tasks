namespace Day2.Date
{
    class CalculateYearsMonthsDays
    {
        DateTime today = DateTime.Today;

        private int currentYear = DateTime.Now.Year;
        private int currentMonth = DateTime.Now.Month;
        public int currentDay = DateTime.Now.Day;

        private int _year;
        private int _month;
        private int _day;

        public CalculateYearsMonthsDays(int year, int month, int day)
        {
            _year = year;
            _month = month;
            _day = day;


        }
        public int calculateYear()
        {
            int Age = currentYear - _year;

            if (currentMonth < _month || currentMonth == _month && currentDay < _day)
            {
                Age--;
            }
            return Age;


        }
        public int calculateMonthsFromLastBD()
        {
            int month = currentMonth - _month;
            if (currentDay < _day)
            {
                month--;
            }
            if (month < 0)
            {
                month += 12;
            }
            return month;
        }

        public int calculateDaysFromLastBirthday()
        {
            if (currentDay < _day)
                return currentDay + 30 - _day;
            else if (_day < currentDay)
                return  currentDay- _day;
            else return 0;
        }


        public override string ToString()
        {
            return $"your age is {calculateYear()} years , {calculateMonthsFromLastBD()} months and {calculateDaysFromLastBirthday()} days ";
        }

    }


    
    
    
}

