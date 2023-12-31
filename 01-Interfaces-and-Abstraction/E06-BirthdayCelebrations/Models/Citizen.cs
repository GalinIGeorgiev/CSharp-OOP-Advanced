﻿namespace E06_BirthdayCelebrations.Models
{
    public class Citizen : SocietyMember, IBirthdate
    {
        private string name;
        private int age;
        private string birthdate;

        public Citizen(string id, string name, int age, string birthdate)
            : base(id)
        {
            this.Name = name;
            this.Age = age;
            this.BirthDate = birthdate;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public string BirthDate
        {
            get { return this.birthdate; }
            private set { this.birthdate = value; }
        }
    }
}
