using System;
using MongoDB.Bson;

namespace SupportModel
{
    public class Ticket
    {
        public ObjectId Id { get; set; }
        public Status Status { get; set; }
        public DateTime TimeReported { get; set; }
        public string Subject { get; set; }
        public TypeOfIncident IncidentType { get; set; }
        public ObjectId MadeBy { get; set; }
        public ObjectId AssignedTo { get; set; }
        public Priority Priority { get; set; }
        public DateTime TimeDueBy { get; set; }
        public string IncidentDescription { get; set; }

        public Ticket(DateTime timeReported, string subject, TypeOfIncident incidentType, ObjectId person, ObjectId assignedTo, Priority priority, DateTime timeDueBy, string incidentDescription)
        {
            TimeReported = timeReported;
            Subject = subject;
            IncidentType = incidentType;
            MadeBy = person;
            AssignedTo = assignedTo;
            Priority = priority;
            TimeDueBy = timeDueBy;
            IncidentDescription = incidentDescription;
            Status = Status.Assigned;
        }

        public Ticket(DateTime timeReported, string subject, TypeOfIncident incidentType, ObjectId person, Priority priority, DateTime timeDueBy, string incidentDescription)
        {
            TimeReported = timeReported;
            Subject = subject;
            IncidentType = incidentType;
            MadeBy = person;
            Priority = priority;
            TimeDueBy = timeDueBy;
            IncidentDescription = incidentDescription;
            Status = Status.Unassigned;
        }
        public Ticket(){}
    }
}