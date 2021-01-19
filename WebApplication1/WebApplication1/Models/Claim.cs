using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CsvHelper.Configuration.Attributes;
using Microsoft.AspNetCore.WebSockets.Internal;

namespace WebApplication1.Models
{
    public class Claim
    {
        [Name("MemberId")]
        public int MemberId { get; set; }

        [Name("ClaimDate")]
        public DateTime ClaimDate { get; set; }

        [Name("ClaimAmount")]
        public double ClaimAmount { get; set; }    

    }
}
