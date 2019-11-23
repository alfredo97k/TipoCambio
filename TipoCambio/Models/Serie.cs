using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TipoCambio.Models
{
    [DataContract]
    public class Serie
    {
        [DataMember(Name = "titulo")]
        public string Title { get; set; }

        [DataMember(Name = "idSerie")]
        public string IdSerie { get; set; }

        [DataMember(Name = "datos")]
        public DataSerie[] Data { get; set; }

    }
}
