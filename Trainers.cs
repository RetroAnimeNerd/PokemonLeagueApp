using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Trainer
{
    // The feild below is what will generate the SERIAL ID in
    //PostgreSQL
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TrainerID {get; set;}
    public string TrainerFirstName {get; set;}
    public string TrainerLastName {get; set;}
    public string TrainerEmail {get; set;}
    public string TrainerPhoneNumber {get; set;}
    public List<string>? PokemonTeam {get; set;}

}