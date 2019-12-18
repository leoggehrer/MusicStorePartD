//@CodeCopy
//MdStart
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Contract = MusicStore.Contracts.Persistence.ITrack;
using Model = MusicStore.Transfer.Models.Persistence.Track;

namespace MusicStore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class TrackController : GenericController<Contract, Model>
    {
		public TrackController(IConfiguration configuration)
			: base(configuration)
		{
		}

		#region Sync-Methods
		[HttpGet("/api/[controller]/Count")]
		public int GetCount()
		{
			return Count();
		}
		// GET: api/Track
		[HttpGet]
        public IEnumerable<Contract> Get()
        {
            return GetAll();
        }

        // GET: api/Track/5
        [HttpGet("{id}")]
        public Contract Get(int id)
        {
            return GetById(id);
        }

        // POST: api/Track
        [HttpPost]
        public void Post([FromBody] Model model)
        {
            Insert(model);
        }

        // PUT: api/Track/5
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
	}
}
//MdEnd
