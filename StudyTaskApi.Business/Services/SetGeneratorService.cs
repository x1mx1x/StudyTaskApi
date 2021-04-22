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
            StringBuilder sb = new StringBuilder();
            Random rand = new Random();
            List<string> strings = new List<string>(cardinality);

            for (int i = 0; i < cardinality; i++) 
            {
                sb.Clear();
                for (int j = 0; j < length; j++) 
                {
                    sb.Append(alphabet[rand.Next()%alphabet.Length]);
                }

                strings.Add(sb.ToString());
            }

            return strings;
        }
    }
}
