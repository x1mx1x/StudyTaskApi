using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTaskApi.Business.Services.Interfaces
{
    public interface ISetGeneratorService
    {
        List<string> GenerateSet(int cardinality,int length,string alphabet);
    }
}
