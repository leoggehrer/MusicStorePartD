using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Contract = MusicStore.Contracts.Persistence.IArtist;
using Model = MusicStore.Transfer.Models.Persistence.Artist;

namespace MusicStore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : GenericController<Contract, Model>
    {
        public ArtistController(IConfiguration configuration)
            : base(configuration)
        {
        }

        #region Sync-Methods
        [HttpGet("/api/[controller]/Count")]
        public int GetCount()
        {
            return Count();
        }

        // GET: api/Artist
        [HttpGet]
        public IEnumerable<Contract> Get()
        {
            return GetAll();
        }

        // GET: api/Artist/5
        [HttpGet("{id}")]
        public Contract Get(int id)
        {
            return GetById(id);
        }

        // POST: api/Artist
        [HttpPost]
        public void Post([FromBody] Model model)
        {
            Insert(model);
        }

        // PUT: api/Artist/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Model model)
        {
            Update(id, model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DeleteById(id);
        }
        #endregion Sync-Methods

        #region Async-Methods
        [HttpGet("/api/[controller]/CountAsync")]
        public Task<int> GetCountAsync()
        {
            return CountAsnc();
        }

        // GET: api/Genre
        [HttpGet("/api/[controller]/GetAsync")]
        public Task<IEnumerable<Contract>> GetAsync()
        {
            return GetAllAsync();
        }

        // GET: api/Genre/5
        [HttpGet("/api/[controller]/GetAsync/{id}")]
        public Task<Contract> GetAsync(int id)
        {
            return GetByIdAsync(id);
        }

        // POST: api/Genre
        [HttpPost("/api/[controller]/PostAsync")]
        public Task PostAsync([FromBody] Model model)
        {
            return InsertAsync(model);
        }

        // PUT: api/Genre/5
        [HttpPut("/api/[controller]/PutAsync/{id}")]
        public Task PutAsync(int id, [FromBody] Model model)
        {
            return UpdateAsync(id, model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("/api/[controller]/DeleteAsync/{id}")]
        public Task DeleteAsync(int id)
        {
            return DeleteByIdAsync(id);
        }
        #endregion Async-Methods
    }
}
