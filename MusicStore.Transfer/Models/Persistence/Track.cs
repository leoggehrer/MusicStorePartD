using System;
using MusicStore.Contracts;

namespace MusicStore.Transfer.Models.Persistence
{
    /// <summary>
    /// Implements the properties and methods of identifiable model.
    /// </summary>
    [Serializable]
    public class Track : TransferObject, Contracts.Persistence.ITrack, ICopyable<Contracts.Persistence.ITrack>
    {
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public string Title { get; set; }
        public string Composer { get; set; }
        public long Milliseconds { get; set; }
        public long Bytes { get; set; }
        public double UnitPrice { get; set; }

        public void CopyProperties(Contracts.Persistence.ITrack other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            Id = other.Id;
            AlbumId = other.AlbumId;
            GenreId = other.GenreId;
            Title = other.Title;
            Composer = other.Composer;
            Milliseconds = other.Milliseconds;
            Bytes = other.Bytes;
            UnitPrice = other.UnitPrice;
        }
    }
}
