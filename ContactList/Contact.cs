﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    class Contact
    {
        private string firstName;
        private string lastName;
        private string phone;

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
        public string Phone
        {
            get { return phone; }
            set 
            {
                if (value.Length == 8)
                {
                    phone = value;
                }
                else
                {
                    phone = "00000000";
                }
            }
        }

        public Contact()
        {
            FirstName = "John";
            LastName = "Doe";
            Phone = "00000000";
        }

        public Contact(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public override string ToString()
        {
            string output = String.Empty;
            output += String.Format("{0}, {1}", LastName, FirstName);
            output += String.Format(" {0}-{1}-{2}", Phone.Substring(0, 3), Phone.Substring(3, 2), Phone.Substring(5, 3));

            return output;
        }

    } // end of class
} // end of namespace
