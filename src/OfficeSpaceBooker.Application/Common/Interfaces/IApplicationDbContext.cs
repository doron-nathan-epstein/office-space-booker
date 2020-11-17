using Microsoft.EntityFrameworkCore;
using OfficeSpaceBooker.Domain.Entities;

namespace OfficeSpaceBooker.Application.Common.Interfaces
{
	public interface IApplicationDbContext
	{
		DbSet<Booking> Bookings { get; set; }
		DbSet<BookingResource> BookingResources { get; set; }
		DbSet<Space> Spaces { get; set; }
	}
}
