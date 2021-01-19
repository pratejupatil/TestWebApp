
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using WebApplication1.Models;

namespace WebApplication1.Mappers
{
    public class MemberMapper : ClassMap<Member>
    {
        public MemberMapper()
        {
            Map(m => m.MemberId).Name("MemberId");
            Map(m => m.EnrollmentDate).Name("EnrollmentDate");
            Map(m => m.FirstName).Name("FirstName");
            Map(m => m.LastName).Name("LastName");
        }
    }
}
