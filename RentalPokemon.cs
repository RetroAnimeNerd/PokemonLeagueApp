using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class RentalPokemon
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RentalPokemonId { get; set; }
    public string PokemonName {get; set; }
    public string PokemonType {get; set; }
    public List<string> Moves {get; set; }
    public bool isRented {get; set;}
}