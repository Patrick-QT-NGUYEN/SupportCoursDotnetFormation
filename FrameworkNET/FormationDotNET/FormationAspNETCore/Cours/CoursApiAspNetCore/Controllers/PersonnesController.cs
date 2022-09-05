using CoursApiAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoursApiAspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnesController : ControllerBase
    {

        // GET: api/<PersonnesController>
        [HttpGet]
        public IEnumerable<Personnes> Get()
        {
            List<Personnes> _personList = new List<Personnes>()
            {
                new Personnes(){ Nom="Di Persio",Prenom="Anthony",Email="anthony@utopios.net", Telephone="+33 6 52 41 52 63" },
                new Personnes(){ Nom="Abadi",Prenom="Ihab" ,Email="ihab@utopios.net", Telephone="+33 6 52 41 52 63" },
                new Personnes(){ Nom="Abadi",Prenom="Marine" ,Email="marine@utopios.net", Telephone="+33 6 52 41 52 63" }
            };
            return _personList;
        }

        // GET api/<PersonnesController>/5
        [HttpGet("{id}")]
        public Personnes Get(int id)
        {
            return new Personnes() { Nom = "Test", Prenom="Test",Email="test@gmail.com",Telephone="+33 6 41 52 63 98"};
        }

        // POST api/<PersonnesController>
        [HttpPost]
        public IActionResult Post([FromBody] Personnes personne)
        {
            //personne.Add();
            // Logique métier
            return Ok(new { message = "Personne Ajoutée", Personne = personne });
        }

        // PUT api/<PersonnesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Personnes personne)
        {
            personne.Id = id;
            return  Ok(new { message = "Personne Modifiée", Personne = personne });  
        }

        // DELETE api/<PersonnesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //return NotFound();
            //return StatusCode(500);
            return Ok(new { message = "Personne Supprimmée", Id = id });
        }
    }
}
