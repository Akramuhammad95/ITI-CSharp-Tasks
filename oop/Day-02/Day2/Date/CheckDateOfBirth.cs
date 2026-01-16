namespace Day2.Date
{
    class CheckDateOfBirth
    {

        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        private int[] Months= new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private bool IsLeapYear(int year)
        {
            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }

        //public DateOfBirth(int year, int month, int day)
        //{
        //    Year = year;
        //    Month = month;
        //    Day = day;
        //}

        public bool IsValidYear()
        {
            return Year >= 1980 && Year <= 2025;
        }
        public bool IsValidMonth()
        {
            return Month >= 1 && Month <= 12;


        }
        public bool IsValidDay()
        {
            int index = Month - 1;
            if (IsLeapYear(Year) && Month == 2)
            {
                return Day >= 1 && Day <= 29;
            }
            return Day >= 1 && Day <= Months[index];
        }

    }


    
    
    
}

