namespace TaskManager.Core.Models.Domains
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public DateTime? Term { get; set; }
        public string UserId { get; set; }

        public Category Category { get; set; }
        public ApplicationUser User { get; set; }  

    }
}
