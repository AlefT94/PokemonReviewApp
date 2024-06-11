namespace PokemonReviewApp.Dto
{
    public class PokemonCreateDTO
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int OwnerId { get; set; }
        public int CategoryId { get; set; }
    }
}
