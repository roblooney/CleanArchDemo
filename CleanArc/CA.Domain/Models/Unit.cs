using System;
using System.Collections.Generic;
using System.Text;

namespace CA.Domain.Models
{
    class Unit
    {
        public int Id { get; set; }
        public int BcId { get; set; }
        public string Name { get; set; }
        public string WaterMeterNumber { get; set; }
        public string ElectricityMeterNumber { get; set; }
        public string GasMeterNumber { get; set; }
        public string ERFNumber { get; set; }
        public string SectionNumber { get; set; }
        public string DoorNumber { get; set; }
        public string FloorArea { get; set; }
        public string ParticipationQuota { get; set; }
    }
}
