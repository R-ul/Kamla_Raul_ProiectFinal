namespace Kamla_Raul_ProiectFinal.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public ICollection<Game>? Game { get; set; } //navigation propert
    }
}
