namespace FirstApi.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Pseudo { get; set; } = string.Empty;
        public DateTime DateNaissance { get; set; }

        public Utilisateur(int id, string pseudo, DateTime dateNAissance)
        {
            Id = id;
            Pseudo = pseudo;
            DateNaissance = dateNAissance;
        }
    }
}
