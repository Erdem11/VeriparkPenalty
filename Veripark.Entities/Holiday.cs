using System;

namespace Veripark.Entities
{
    public class Holiday
    {
        public Guid Id { get; set; }
        public Guid CountryId { get; set; }
        public DateTime HolidayDate { get; set; }
    }
}