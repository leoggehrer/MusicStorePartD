//@CodeCopy
//MdStart
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Contract = MusicStore.Contracts.Persistence.IAlbum;
using Model = MusicStore.Transfer.Models.Persistence.Album;

namespace MusicStore.WebApi.Controllers
{
	public partial class AlbumController
    {
		#region Async-Methods
		[HttpGet("/api/[controller]/CountAsync")]
		public Task<int> GetCountAsync()
		{
			return CountAsnc();
		}

		// GET: api/Album
		[HttpGet("/api/[controller]/GetAsync")]
		public Task<IEnumerable<Contract>> GetAsync()
		{
			return GetAllAsync();
		}

		// GET: api/Album/5
		[HttpGet("/api/[controller]/GetAsync/{id}")]
		public Task<Contract> GetAsync(int id)
		{
			return GetByIdAsync(id);
		}

		// POST: api/Album
		[HttpPost("/api/[controller]/PostAsync")]
		public Task PostAsync([FromBody] Model model)
		{
			return InsertAsync(model);
		}

		// PUT: api/Album/5
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
