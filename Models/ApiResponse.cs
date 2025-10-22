using System.Reflection;
using System.Text.Json.Serialization;

namespace RetoTecnicoDiegoNoblecilla.Models
{
    public class ApiResponse
    {
        [JsonPropertyName("results")]
        public List<User> Results { get; set; }
    }
    public class User
    {
        [JsonPropertyName("gender")]
        public string Genero { get; set; }

        [JsonPropertyName("name")]
        public Name Identificacion { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("location")]
        public Location Ubicacion { get; set; }

        [JsonPropertyName("picture")]
        public Picture Foto { get; set; }

        [JsonPropertyName("dob")]
        public Dob Dob { get; set; }

        public string GeneroSpan => Genero.ToLower() switch
        {
            "male" => "Hombre",
            "female" => "Mujer",
            _ => "Otro"
        };
    }

    public class Name
    {
        [JsonPropertyName("title")]
        public string Titulo { get; set; }
        [JsonPropertyName("first")]
        public string Nombre { get; set; }
        [JsonPropertyName("last")]
        public string Apellido { get; set; }
    }

    public class Dob
    {
        [JsonPropertyName("date")]
        public DateTime FechaNac { get; set; }

        public string FecNacFormat => FechaNac.ToShortDateString();
    }

    public class Location
    {
        [JsonPropertyName("city")]
        public string Ciudad { get; set; }
        [JsonPropertyName("state")]
        public string Estado { get; set; }
        [JsonPropertyName("country")]
        public string Pais { get; set; }
    }

    public class Picture
    {
        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; }
    }
}
