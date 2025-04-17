namespace BloodDonar1.Models
{
    public class Bloods
    {
        public int Id { get; set; }

        
        public required string Name { get; set; }
        public string BloodType { get; set; }

        public required string Phone { get; set; }
    }
}
