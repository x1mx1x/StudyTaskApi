using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudyTaskApi.Business.Services.Interfaces;
using StudyTaskApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            long timer = DateTime.Now.Ticks;

            var set = _setGeneratorService.GenerateSet(setDto.Cardinality, setDto.Length, setDto.Alphabet);
            var counts = _countService.CountCharacters(set, setDto.Alphabet);
            timer = (DateTime.Now.Ticks - timer)/10;

            return new ResponseSetDto{ Set = set, Counts = counts,TimeSec = timer};
        }

    }
}
