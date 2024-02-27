namespace IdentityLoginSystem.Data.ToDoDataContext
{
    public class Todolist
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public string ToDo { get; set; }
    }
}
