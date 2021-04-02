using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyTaskApi.Dto
{
    public class RequestSetDto
    {
        public string Alphabet { get; set; }
        public int Cardinality { get; set; }
        public int Length { get; set; }
        public bool IsSetRequested { get; set; }
    }
}
