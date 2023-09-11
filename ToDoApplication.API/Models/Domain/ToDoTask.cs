namespace ToDoApplication.API.Models.Domain
{
    public class ToDoTask
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
