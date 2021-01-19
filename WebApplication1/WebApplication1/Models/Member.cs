
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;
using Microsoft.AspNetCore.WebSockets.Internal;

namespace WebApplication1.Models
{
    public class Member
    {
        [Name("MemberId")]
        public int MemberId { get; set; }

        [Name("EnrollmentDate")]
        public DateTime EnrollmentDate { get; set; }

        [Name("FirstName")]
        public string FirstName { get; set; }

        [Name("LastName")]
        public string LastName { get; set; }


    }


}
