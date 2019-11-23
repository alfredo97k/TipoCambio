using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TipoCambio.Models
{
    [DataContract]
    public class Response
    {
        [DataMember(Name = "bmx")]
        public SeriesResponse seriesResponse { get; set; }
    }
}
