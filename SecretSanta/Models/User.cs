namespace SecretSanta.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual int GroupId { get; set; }
        public List<Gift> Gifts { get; set; }
    }
}
