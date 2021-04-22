using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTaskApi.Business.Services.Interfaces
{
    public interface ICountService
    {
        Dictionary<char, int> CountCharacters(List<string> strings, string alphabet);
    }
}
