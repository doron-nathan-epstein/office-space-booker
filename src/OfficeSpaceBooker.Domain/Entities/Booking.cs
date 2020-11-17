using System;
using System.Collections.Generic;

namespace OfficeSpaceBooker.Domain.Entities
{
	public class Booking
	{
		public long Id { get; set; }
		public DateTime Start { get; set; }
		public DateTime End { get; set; }

		public IEnumerable<BookingResource>	Resources { get; set; } = new List<BookingResource>();

		public bool IsCancelled { get; set; }
	}
}
