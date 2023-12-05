using FirstApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly FakeDb _FDB = new FakeDb();

        // GetAll
        [HttpGet(nameof(GetAll))]
        public IEnumerable<Utilisateur> GetAll()
        {
            return _FDB.Utilisateurs;
        }


        // GetById
        [HttpGet("{id}")]
        public ActionResult<Utilisateur> GetByID(int id)
        {
            Utilisateur user = _FDB.Utilisateurs.Find(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // Update

        // Delete
    }
}
