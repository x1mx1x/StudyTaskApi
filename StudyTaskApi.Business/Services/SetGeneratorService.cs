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
            Random rand = new Random();
            List<string> strings = new List<string>(cardinality);

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
