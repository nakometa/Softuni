using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            this.FamilyList = new List<Person>();
        }
        public List<Person> FamilyList { get; set; }

        public void AddMember(Person currentPerson)
        {
            this.FamilyList.Add(currentPerson);
        }

        public Person GetOldestMember()
        {
            Person oldest = FamilyList.OrderByDescending(p => p.Age).FirstOrDefault();
            return oldest;
        }
    }
}
