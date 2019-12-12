using System;
using MusicStore.Contracts;

namespace MusicStore.Transfer.Models.Persistence
{
    /// <summary>
    /// Implements the properties and methods of identifiable model.
    /// </summary>
    public partial class Artist : TransferObject, Contracts.Persistence.IArtist, ICopyable<Contracts.Persistence.IArtist>
    {
        public string Name { get; set; }

		public void CopyProperties(Contracts.Persistence.IArtist other)
		{
			if (other == null)
				throw new ArgumentNullException(nameof(other));

			Id = other.Id;
			Name = other.Name;
		}
	}
}