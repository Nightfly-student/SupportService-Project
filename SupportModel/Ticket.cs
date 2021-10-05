using System;
using MongoDB.Bson;

namespace SupportModel
{
    public enum TypeOfIncident { Software, Hardware, Service }

    public enum Priority { High, Normal, Low }

    public class Ticket
    {
        public ObjectId Id { get; set; }
        public DateTime TimeReported { get; set; }
        public string Subject { get; set; }
        public TypeOfIncident IncidentType { get; set; }
        public Person MadeBy { get; set; }
        public Person AssignedTo { get; set; }
        public Priority Priority { get; set; }
        public DateTime TimeDueBy { get; set; }
        public string IncidentDescription { get; set; }

        public Ticket(DateTime timeReported, string subject, TypeOfIncident incidentType, Person person, Priority priority, DateTime timeDueBy, string incidentDescription)
        {
            TimeReported = timeReported;
            Subject = subject;
            IncidentType = incidentType;
            MadeBy = person;
            Priority = priority;
            TimeDueBy = timeDueBy;
            IncidentDescription = incidentDescription;
        }

        public Ticket(){}

    }
}