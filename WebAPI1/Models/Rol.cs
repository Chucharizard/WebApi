namespace WebAPI1.Models
{
    public class Rol
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string description { get; set; }

        public bool isDeleted { get; set; }

        public List<User> Users { get; set; }
    }
}
