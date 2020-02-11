using System;
using System.Collections.Generic;
using System.Text;

namespace CA.Domain.Models
{
    class BodyCorporate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SSNumber { get; set; }
        public string LotNumber { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public bool Active { get; set; }
        public DateTime ActiveDate { get; set; }
        public string MunicipalityAccount { get; set; }
    }
}
