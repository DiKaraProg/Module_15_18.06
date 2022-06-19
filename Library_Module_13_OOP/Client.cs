﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOdule13_OOP
{
    public class Client
    {
        private List<Account> listaccount = new List<Account>();
        private int id;
        private string firstName;
        private string lastName;
        private string fatherName;
        private string phoneNumber;
        private string passport;
        private string email;
        
        
        
        public int Id { get { return id; } set { id = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }   
        public string FatherName { get { return fatherName; } set { fatherName = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string Passport { get { return passport; } set { passport = value; } }
        public string Email { get { return email; } set { email = value; } }
        

        public List<Account> Listaccount { get { return listaccount; } set { listaccount = value; } }


        public  Client(int Id, string FirstName, string LastName, string FatherName, string Phonenumber,
            string Passport, string Email)
        {
            this.id = Id;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.fatherName = FatherName;
            this.phoneNumber = Phonenumber;
            this.passport = Passport;
            this.email = Email;
        

        }
        

    }

    
}
