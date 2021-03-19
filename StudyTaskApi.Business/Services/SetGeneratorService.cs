using StudyTaskApi.Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTaskApi.Business.Services
{
    public class SetGeneratorService : ISetGeneratorService
    {
        public Dictionary<char, int> CountCharacters(List<string> strings) 
        {
            return new Dictionary<char, int>();
        }
    }
}
