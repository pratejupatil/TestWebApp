using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Interfaces;

namespace WebApplication1.Controllers
{
    [Produces("application/json")]
    [Route("api/MemberClaims")]
    [ApiController]
    public class MemberClaimsController : ControllerBase
    {

        private readonly IMemberData memberData;

        private readonly IClaimData claimData;

        public MemberClaimsController(IMemberData memberData, IClaimData claimData)
        {
            this.memberData = memberData;
            this.claimData = claimData;
        }
        
        [Route("MemberData")]
        [HttpGet]
        [Produces("application/json", Type = typeof(IList<long>))]
        public async Task<IActionResult> GetMemberData()
        {
            string path = "C:\\Users\\ppatil6\\source\\repos\\WebApplication1\\WebApplication1\\Member.csv";
            List<Member> memberobj = new List<Member>();
            memberobj = await memberData.GetMemberData(path);
            return Ok(memberobj);
        }

        [Route("ClaimDtaData")]
        [HttpGet]
        [Produces("application/json", Type = typeof(IList<long>))]
        public async Task<IActionResult> GetClaimData()
        {
            string path = "C:\\Users\\ppatil6\\source\\repos\\WebApplication1\\WebApplication1\\Claim.csv";
            List<Claim> claimobj = new List<Claim>();
            claimobj = await claimData.GetClaimData(path);
            return Ok(claimobj);
        }


    }
}