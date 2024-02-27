namespace IdentityLoginSystem.Data.ToDoDataContext
{
    public class Cpr
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public string CPRNumber { get; set; }
    }
}
