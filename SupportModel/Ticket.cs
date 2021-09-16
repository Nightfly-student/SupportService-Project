using System;

namespace SupportModel
{
    public enum TypeOfIncident { Software, Hardware, Service }

    public enum Priority { High, Normal, Low }

    public class Ticket
    {
        public DateTime TimeReported { get; set; }
        public string Subject { get; set; }
        public TypeOfIncident IncidentType { get; set; }
        public Person Person { get; set; }
        public DateTime TimeDueBy { get; set; }
        public string IncidentDescription { get; set; }

        public Ticket(DateTime timeReported, string subject, TypeOfIncident incidentType, Person person, DateTime timeDueBy, string incidentDescription)
        {
            TimeReported = timeReported;
            Subject = subject;
            IncidentType = incidentType;
            Person = person;
            TimeDueBy = timeDueBy;
            IncidentDescription = incidentDescription;
        }
    }
}