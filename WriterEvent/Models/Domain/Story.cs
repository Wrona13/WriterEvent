namespace WriterEvent.Tables.Domain
{
    public class Story
    {
        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Username { get; set; }
        public string Warnings { get; set; }
        public string Characters { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public bool Age { get; set; }
        public bool Visible { get; set; }
    }
}
