using OfficeSpaceBooker.Domain.Enums;

namespace OfficeSpaceBooker.Domain.Entities
{
	public class Space
	{
		public int Id { get; set; }

		public SpaceType SpaceType { get; set; }

		public string Code { get; set; }

		public string Description { get; set; }
	}
}
