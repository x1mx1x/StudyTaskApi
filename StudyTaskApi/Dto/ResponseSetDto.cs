using System;
using System.Collections.Generic;

namespace StudyTaskApi.Dto
{
    public class ResponseSetDto
    {
        public List<string> Set { get; set; }

        public Dictionary<char, int> Counts { get; set; }

        public TimeSpan Timer { get; set; }
    }
}
