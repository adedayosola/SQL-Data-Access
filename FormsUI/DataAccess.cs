﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {

                /*var output = connection.Query<Person>($"select * from People where LastName= '{lastName}'").ToList();*/
                var output = connection.Query<Person>(
                    "dbo.People_GetByLastName @LastName",
                    new { LastName = lastName }).ToList();
                return output;
            }
        }

        public void insertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                /*Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber };
                List<Person> people = new List<Person>();
                people.Add(newPerson);*/

                Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber };
                List<Person> people = new List<Person>();
                people.Add(new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber });
                connection.Execute("dbo.People_insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);
            }
        }
    }
}
