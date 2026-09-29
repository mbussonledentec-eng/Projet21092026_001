using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Collections.ObjectModel;
namespace Jeux.Models;

public class Carte
{
    #region Attributs
    private string id = "";
    private string marque = "";
    private string modele = "";
    private string variante = "";
    #endregion

    #region Constructeurs
    public Carte() { }

    public Carte(string marque, string modele, string variante)
    {
        Marque = marque;
        Modele = modele;
        Variante = variante;
    }
    #endregion

    #region Proprietes
    [JsonProperty("id")]
    public string Id { get => id; set => id = value; }

    [JsonProperty("brand")]
    public string Marque { get => marque; set => marque = value; }

    [JsonProperty("modele")]
    public string Modele { get => modele; set => modele = value; }

    [JsonProperty("variant")]
    public string Variante { get => variante; set => variante = value; }
    #endregion

}