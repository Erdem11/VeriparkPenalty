using System;
using System.Collections.Generic;

namespace Veripark.Entities
{
    public class Country
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Weekend> Weekends { get; set; }

        public List<Holiday> Holidays { get; set; }
    }
}