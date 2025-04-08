namespace FOLYFOOD.Entitys
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Subject { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool answered { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
