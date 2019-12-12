namespace MusicStore.Transfer.Models
{
	public abstract class TransferObject : Contracts.IIdentifiable
    {
        public int Id { get; set; }
    }
}
