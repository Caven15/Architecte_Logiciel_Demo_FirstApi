using FirstApi.Interfaces;

namespace FirstApi.Models
{
    public class FakeDb : IFakeDb
    {
        #region Attributs

        private List<Utilisateur> _Utilisateurs;

        #endregion

        #region Prop's

        public List<Utilisateur> Utilisateurs
        {
            get
            {
                return _Utilisateurs;
            }
            set
            {
                _Utilisateurs = value;
            }
        }
        #endregion

        #region Constructeur

        public FakeDb()
        {
            _Utilisateurs = new List<Utilisateur>()
            {
                new Utilisateur(1, "Jean", new DateTime(1995,05,09)),
                new Utilisateur(2, "Paul", new DateTime(1975,08,10)),
                new Utilisateur(3, "Docteur hanibal canibal pizza", new DateTime(1995,05,15)),
                new Utilisateur(4, "Alex", new DateTime(1991,05,15)),
                new Utilisateur(5, "Benoit", new DateTime(1655,08,12)),
                new Utilisateur(6, "François", new DateTime(1495,11,20))
            };
        }

        #endregion
    }
}
