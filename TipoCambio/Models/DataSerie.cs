using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TipoCambio.Models
{
    [DataContract]
    public class DataSerie
    {
        [DataMember(Name = "fecha")]
        public string Date { get; set; }

        [DataMember(Name = "dato")]
        public decimal Data { get; set; }

    }
}
