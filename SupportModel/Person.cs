using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel;
using MongoDB.Bson;

namespace SupportModel
{
    public enum TypeOfUser {[Description("Employee")] Employee, [Description("Service desk employee")] ServiceDeskEmployee }

    public class Person
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public TypeOfUser UserType { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public string WorkLocation { get; set; }

        public Person(string firstName, string lastName, string email, DateTime dateOfBirth, int phoneNumber, string workLocation)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            WorkLocation = workLocation;
        }
    }
}