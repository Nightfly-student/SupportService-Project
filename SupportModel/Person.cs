using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel;
using MongoDB.Bson;

namespace SupportModel
{
    public enum UserType { User, ServiceDesk}
    public class Person
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserType { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public string WorkLocation { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Person(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public Person(string firstName, string lastName, string email, DateTime dateOfBirth, int phoneNumber, string workLocation, string userType, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
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
    }
}