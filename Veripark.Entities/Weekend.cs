using System;

namespace Veripark.Entities
{
    public class Weekend
    {
        public Guid Id { get; set; }

        public Guid CountryId { get; set; }
        public int DayOfWeek { get; set; }
    }
}