using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;
using System.IO;
using CsvHelper.Configuration.Attributes;

namespace PhillyPhridges.Models
{
    public class CSVHelperModel
    {

            [Name("Id")]
            public int Id { get; set; }

            [Name("Address")]
            public string Address { get; set; }

            [Name("Sponsor")]
            public string Sponsor { get; set; }

            [Name("Website")]
            public string Website { get; set; }

            [Name("Instagram")]
            public string Instagram { get; set; }

            [Name("Lat")]
            public float Lat { get; set; }

            [Name("Lng")]
            public float Lng { get; set; }

   

    }
}
