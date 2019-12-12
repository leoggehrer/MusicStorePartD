using System;
using MusicStore.Contracts;

namespace MusicStore.Transfer.Models.Persistence
{
    /// <summary>
    /// Implements the properties and methods of identifiable model.
    /// </summary>
    public class Album : TransferObject, Contracts.Persistence.IAlbum, ICopyable<Contracts.Persistence.IAlbum>
    {
        public int ArtistId { get; set; }
        public string Title { get; set; }

        public void CopyProperties(Contracts.Persistence.IAlbum other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            Id = other.Id;
            ArtistId = other.ArtistId;
            Title = other.Title;
        }
    }
}
