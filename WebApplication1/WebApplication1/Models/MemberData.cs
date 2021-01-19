using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Interfaces;



namespace WebApplication1.Models
{
    public class MemberData : IMemberData
    {
        public async Task<List<Member>> GetMemberData(string location)
        {
            try
            {
                using (var reader = new StreamReader(location))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var members = csv.GetRecords<Member>().ToList();
                    return members;
                }                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
    }
}
