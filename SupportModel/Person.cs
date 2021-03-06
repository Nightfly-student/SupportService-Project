using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel;
using MongoDB.Bson;

namespace SupportModel
{

    public class Person
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType UserType { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string WorkLocation { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Person(string firstName, string lastName, string email, int phoneNumber, string workLocation, UserType userType, string username, string password) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            WorkLocation = workLocation;
            UserType = userType;
            Username = username;
            Password = BCrypt.Net.BCrypt.HashPassword(password, GetRandomSalt());
        }

        public Person(){}

        private static string GetRandomSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt(12);
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public ObjectId GetID ()
        {
            return Id;
        }
    }
}