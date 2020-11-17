using Microsoft.EntityFrameworkCore;
using OfficeSpaceBooker.Application.Common.Interfaces;
using OfficeSpaceBooker.Domain.Entities;

namespace OfficeSpaceBooker.Infrastructure.Persistence
{
	internal class ApplicationDbContext : DbContext, IApplicationDbContext
	{
		public DbSet<Booking> Bookings { get; set; }
		public DbSet<BookingResource> BookingResources { get; set; }
		public DbSet<Space> Spaces { get; set; }
	}
}
