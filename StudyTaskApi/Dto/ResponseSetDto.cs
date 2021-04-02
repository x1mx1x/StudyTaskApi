using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyTaskApi.Dto
{
    public class ResponseSetDto
    {
        public List<string> Set { get; set; }
        public Dictionary<char, int> Counts { get; set; }
        public int Time { get; set; }
    }
}
