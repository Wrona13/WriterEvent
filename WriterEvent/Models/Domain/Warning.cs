namespace WriterEvent.Models.Domain
{
    public class Warning
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid StoryId { get; set; }
    }
}
