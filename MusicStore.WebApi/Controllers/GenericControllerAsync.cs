//@CodeCopy
//MdStart
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MusicStore.WebApi.Controllers
{
	partial class GenericController<I, M>
    {
		#region Async-Methods
		public async Task<int> CountAsnc()
		{
			using var ctrl = CreateController();

			return await ctrl.CountAsync();
		}
		public async Task<IEnumerable<I>> GetAllAsync()
		{
			using var ctrl = CreateController();

			return await ctrl.GetAllAsync();
		}
		public async Task<I> GetByIdAsync(int id)
		{
			using var ctrl = CreateController();

			return await ctrl.GetByIdAsync(id);
		}
		public async Task InsertAsync([FromBody] M model)
		{
			using var ctrl = CreateController();
			await ctrl.InsertAsync(model);
			await ctrl.SaveChangesAsync();
		}
		public async Task UpdateAsync(int id, [FromBody] M model)
		{
			using var ctrl = CreateController();
			await ctrl.UpdateAsync(model);
			await ctrl.SaveChangesAsync();
		}
		public async Task DeleteByIdAsync(int id)
		{
			using var ctrl = CreateController();
			await ctrl.DeleteAsync(id);
			await ctrl.SaveChangesAsync();
		}
		#endregion Async-Methods
	}
}
//MdEnd
