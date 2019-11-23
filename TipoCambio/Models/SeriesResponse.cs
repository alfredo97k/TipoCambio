using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TipoCambio.Models
{
    [DataContract]
    public class SeriesResponse
    {
        [DataMember(Name = "series")]
        public Serie[] series { get; set; }
    }
}
