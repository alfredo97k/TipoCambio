using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace TipoCambio.Models
{
    class test
    {
        public static Response ReadSerie()
        {
            try
            {
                string url = "https://www.banxico.org.mx/SieAPIRest/service/v1/series/SF61745/datos/2011-08-06/2011-08-06";
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Accept = "application/json";
                request.Headers["Bmx-Token"] = "65b0cc067312678aac34b15e5e0e40fc31971bbb9b53cdc752a74284110b52b1";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception(String.Format(
                    "Server error (HTTP {0}: {1}).",
                    response.StatusCode,
                    response.StatusDescription));
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
                object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                Response jsonResponse = objResponse as Response;
                return jsonResponse;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        static void Main(string[] args)
        {
            Response response = ReadSerie();
            Serie serie = response.seriesResponse.series[0];
            Console.WriteLine("Serie: {0}", serie.Title);
            foreach (DataSerie dataSerie in serie.Data)
            {
                if (dataSerie.Data.Equals("N/E")) continue;
                Console.WriteLine("Fecha: {0}", dataSerie.Date);
                Console.WriteLine("Dato: {0}", dataSerie.Data);
            }
            Console.ReadLine();
        }
    }
}

