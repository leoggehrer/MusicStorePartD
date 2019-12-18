//@CodeCopy
//MdStart
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Contract = MusicStore.Contracts.Persistence.IGenre;
using Model = MusicStore.Transfer.Models.Persistence.Genre;

namespace MusicStore.WebApi.Controllers
{
	partial class GenreController
	{
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
//MdEnd
