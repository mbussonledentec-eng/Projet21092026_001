using Newtonsoft.Json;
namespace AtelierCartes.Models;

public class CartePossedee
{
    private string id = "";
    private Carte carte = new Carte();
    private decimal valeurActuelle = 0;

    public CartePossedee(Carte cartes, decimal valeurActuelles)
    {
        carte = cartes;
        valeurActuelle = valeurActuelles;
    }
    [JsonProperty("id")]
    public string Id { get => id; set => id = value; }
    [JsonProperty("card")]
    public Carte Carte { get => carte; set => carte = value; }
    [JsonProperty("currentValue")]
    public decimal ValeurActuelle { get => ValeurActuelle; set => ValeurActuelle = value; }
}