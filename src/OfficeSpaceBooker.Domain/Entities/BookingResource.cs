namespace OfficeSpaceBooker.Domain.Entities
{
	public class BookingResource
	{
		public long Id { get; set; }

		public Booking Booking { get; set; }
		public long BookingId { get; set; }

		public Space Space { get; set; }
		public int SpaceId { get; set; }
	}
}
