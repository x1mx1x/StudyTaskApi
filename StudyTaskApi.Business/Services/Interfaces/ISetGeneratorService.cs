using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTaskApi.Business.Services.Interfaces
{
    public interface ISetGeneratorService
    {
        Dictionary<char, int> CountCharacters(List<string> strings);
    }
}
