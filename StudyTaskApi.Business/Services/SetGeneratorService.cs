using StudyTaskApi.Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTaskApi.Business.Services
{
    public class SetGeneratorService : ISetGeneratorService
    {
        public List<string> GenerateSet(int cardinality, int length, string alphabet) 
        {
            return new List<string>();
        }
    }
}
