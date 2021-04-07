using Microsoft.AspNetCore.Mvc;
using StudyTaskApi.Business.Services.Interfaces;
using StudyTaskApi.Dto;
using System;
using System.Diagnostics;

namespace StudyTaskApi.Controllers
{
    [Route("api/sets")]
    [ApiController]
    public class SetGeneratorController : ControllerBase
    {
        private readonly ISetGeneratorService _setGeneratorService;
        private readonly ICountService _countService;
        public SetGeneratorController(ISetGeneratorService setGeneratorService, ICountService countService) 
        {
            _setGeneratorService = setGeneratorService;
            _countService = countService;
        }

        [Route("body")]
        public ResponseSetDto GenerateSetFromBody([FromBody]RequestSetDto setDto)
        {
            Stopwatch myStopwatch = new Stopwatch();
            myStopwatch.Start(); 
            var set = _setGeneratorService.GenerateSet(setDto.Cardinality, setDto.Length, setDto.Alphabet);
            var counts = _countService.CountCharacters(set, setDto.Alphabet);
            myStopwatch.Stop();
            TimeSpan timer = TimeSpan.FromMilliseconds(myStopwatch.ElapsedMilliseconds);
            return new ResponseSetDto{ Set = set, Counts = counts,Timer = timer};
        }

    }
}
