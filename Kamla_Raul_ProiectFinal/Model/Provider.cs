namespace Kamla_Raul_ProiectFinal.Model
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Game>? Game { get; set; } //navigation property
    }
}
