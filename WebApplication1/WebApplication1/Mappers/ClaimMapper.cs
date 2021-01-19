using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using WebApplication1.Models;


namespace WebApplication1.Mappers
{
    public sealed class ClaimMapper : ClassMap<Claim>
    {

        public ClaimMapper()
        {
            Map(m => m.MemberId).Name("MemberId");
            Map(m => m.ClaimDate).Name("ClaimDate");
            Map(m => m.ClaimAmount).Name("ClaimAmount");
        }
    }
}
