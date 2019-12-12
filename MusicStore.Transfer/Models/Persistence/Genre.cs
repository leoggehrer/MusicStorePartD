using System;
using MusicStore.Contracts;

namespace MusicStore.Transfer.Models.Persistence
{
    /// <summary>
    /// Implements the properties and methods of identifiable model.
    /// </summary>
    public class Genre : TransferObject, Contracts.Persistence.IGenre, ICopyable<Contracts.Persistence.IGenre>
    {
		public Genre()
		{

		}
        public string Name { get; set; }

		public void CopyProperties(Contracts.Persistence.IGenre other)
		{
			if (other == null)
				throw new ArgumentNullException(nameof(other));

			Id = other.Id;
			Name = other.Name;
		}
	}
}
