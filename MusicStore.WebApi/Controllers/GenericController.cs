//@CodeCopy
//MdStart
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MusicStore.WebApi.Controllers
{
	public abstract partial class GenericController<I, M> : ControllerBase
        where M : Transfer.Models.TransferObject, I, Contracts.ICopyable<I>, new()
        where I : Contracts.IIdentifiable
    {
		protected IConfiguration Configuration { get; private set; }

		public GenericController(IConfiguration configuration)
		{
			Configuration = configuration;

			string persistenceType = configuration["PersistenceType"];
			Logic.Factory.Persistence = (Logic.Factory.PersistenceType)Enum.Parse(typeof(Logic.Factory.PersistenceType), persistenceType);
		}
		protected Contracts.Client.IControllerAccess<I> CreateController()
        {
            return Logic.Factory.Create<I>();
        }

		#region Sync-Methods
		public int Count()
		{
			using var ctrl = CreateController();

			return ctrl.Count();
		}
        public IEnumerable<I> GetAll()
        {
            using var ctrl = CreateController();

            return ctrl.GetAll().ToArray();
        }
        public I GetById(int id)
        {
            using var ctrl = CreateController();

            return ctrl.GetById(id);
        }
        public void Insert([FromBody] M model)
        {
            using var ctrl = CreateController();
            ctrl.Insert(model);
            ctrl.SaveChanges();
        }
        public void Update(int id, [FromBody] M model)
        {
            using var ctrl = CreateController();
            ctrl.Update(model);
            ctrl.SaveChanges();
        }
        public void DeleteById(int id)
        {
            using var ctrl = CreateController();
            ctrl.Delete(id);
            ctrl.SaveChanges();
        }
		#endregion Sync-Methods
	}
}
//MdEnd
