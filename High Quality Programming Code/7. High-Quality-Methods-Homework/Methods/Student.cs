using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = getBirthDate();
            DateTime secondDate = getBirthDate();
            bool isFirstStudentOlder = (firstDate > secondDate);
            return isFirstStudentOlder;
        }

        private DateTime getBirthDate()
        {
            DateTime date = DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            if (date == new DateTime())
            {
                throw new ArgumentException("Invalid date! Date must be formatted like this: 03.11.1993");
            }
            return date;
        }

    }
}
