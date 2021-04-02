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
            Guid guid = Guid.NewGuid();
            Random rand = new Random(guid.GetHashCode());
            List<string> strings = new List<string>();
            for (int i = 0; i < cardinality; i++) 
            {
                string str = "";
                for (int j = 0; j < length; j++) 
                {
                    str += alphabet[rand.Next()%alphabet.Length];
                }
                strings.Add(str);
            }
            return strings;
        }
    }
}
