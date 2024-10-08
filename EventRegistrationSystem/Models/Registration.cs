namespace EventRegistrationSystem.Models
{
    public class Registration
    {
        public int RegistrationId{ get; set; }
        public string ParticipantName { get; set; }
        public string Email { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }

    }
}
