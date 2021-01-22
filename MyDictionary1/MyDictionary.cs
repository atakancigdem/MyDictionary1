using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary1
{
    class MyDictionary<TFirst , TLast, TAge>
    {
        TFirst[] FirstName;
        TLast[] LastName;
        TAge[] Age;
        public MyDictionary()
        {
            FirstName = new TFirst[0];
            LastName = new TLast[0];
            Age = new TAge[0];
        }
        public void Add(TFirst firstName, TLast lastName, TAge age)
        {
            TFirst[] tempFirstName = FirstName;
            TLast[] tempLastName = LastName;
            TAge[] tempAge = Age;
                        
            FirstName = new TFirst[FirstName.Length + 1];
            LastName = new TLast[LastName.Length + 1];
            Age = new TAge[Age.Length + 1];

            for (int i = 0; i < tempFirstName.Length; i++)
            {
                FirstName[i] = tempFirstName[i];
                LastName[i] = tempLastName[i];
                Age[i] = tempAge[i];
            }

            FirstName[FirstName.Length - 1] = firstName;
            LastName[LastName.Length - 1] = lastName;
            Age[Age.Length - 1] = age;
        }

        public int Length
        {
            get { return FirstName.Length; }
        }

        public TFirst[] Tfirsts
        {
            get { return FirstName; }
        }

        public TLast[] Tlast
        {
            get { return LastName; }
        }
        
        public TAge[] Tage
        {
            get { return Age;}
        }
    }
}
