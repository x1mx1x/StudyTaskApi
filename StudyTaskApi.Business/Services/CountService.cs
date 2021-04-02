using StudyTaskApi.Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTaskApi.Business.Services
{
    public class CountService : ICountService
    {
        public Dictionary<char, int> CountCharacters(List<string> strings, string alphabet)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            int count;

            foreach (char ch in alphabet)
            {
                count = 0;
                foreach (var str in strings)
                {
                    for (int i = 0; i < str.Length; i++) 
                    {
                        if (str[i] == ch) 
                        {
                            count++;
                        }
                    }
                }
                counts.Add(ch, count);
            }
            return counts;
        }
    }
}
