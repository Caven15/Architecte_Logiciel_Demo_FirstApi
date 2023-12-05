using FirstApi.Models;

namespace FirstApi.Interfaces
{
    public interface IFakeDb
    {
        List<Utilisateur> Utilisateurs { get; set; }
    }
}
