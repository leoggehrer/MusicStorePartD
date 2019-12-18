//@CodeCopy
//MdStart
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Contract = MusicStore.Contracts.Persistence.ITrack;
using Model = MusicStore.Transfer.Models.Persistence.Track;

namespace MusicStore.WebApi.Controllers
{
    partial class TrackController
    {
		#region Async-Methods
		[HttpGet("/api/[controller]/CountAsync")]
		public Task<int> GetCountAsync()
		{
			return CountAsnc();
		}

		// GET: api/Track
		[HttpGet("/api/[controller]/GetAsync")]
		public Task<IEnumerable<Contract>> GetAsync()
		{
			return GetAllAsync();
		}

		// GET: api/Track/5
		[HttpGet("/api/[controller]/GetAsync/{id}")]
		public Task<Contract> GetAsync(int id)
		{
			return GetByIdAsync(id);
		}

		// POST: api/Track
		[HttpPost("/api/[controller]/PostAsync")]
		public Task PostAsync([FromBody] Model model)
		{
			return InsertAsync(model);
		}

		// PUT: api/Track/5
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
//MdEnd
