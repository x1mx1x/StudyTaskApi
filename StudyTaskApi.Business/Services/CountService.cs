using StudyTaskApi.Business.Services.Interfaces;
using System.Collections.Generic;

namespace StudyTaskApi.Business.Services
{
    public class CountService : ICountService
    {
        public Dictionary<char, int> CountCharacters(List<string> strings, string alphabet)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (var str in strings)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (!counts.ContainsKey(str[i])) 
                    {
                        counts.Add(str[i],0);
                    }
                    counts[str[i]]++;
                }
            }

            return counts;
        }
    }
}
