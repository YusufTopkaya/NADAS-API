using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Nadas.API.Business.Interfaces;
using Nadas.API.Entities.Concrete;
using Nadas.DTO.DTOs.AnswerDtos;

namespace Nadas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : ControllerBase
    {
        private readonly IAnswerService _answerService;
        private readonly IMapper _mapper;

        public AnswersController(IAnswerService answerService, IMapper mapper)
        {
            _answerService = answerService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<List<AnswerListDto>>(await _answerService.GetAllLoadedAsync()));
        }
        [HttpGet("GetAllByQuestionId/{id}")]
        public async Task<IActionResult> GetAllByQuestionIdAsync(int id)
        {
            return Ok(_mapper.Map<List<AnswerListDto>>(await _answerService.GetAllByQuestionIdAsync(id)).OrderBy(I=> I.Id));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<AnswerListDto>(await _answerService.FindById(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Create(AnswerAddDto answer)
        {
           
            //await _answerService.AddAsync(_mapper.Map<Answer>(answer));
            var created= await _answerService.AddAnswerAsync(_mapper.Map<Answer>(answer));
            var model = _mapper.Map<AnswerListDto>(created);
            return Created(string.Empty, model);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, AnswerUpdateDto answer)
        {
            if (id != answer.Id)
                return BadRequest("");
            await _answerService.UpdateAsync(_mapper.Map<Answer>(answer));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _answerService.RemoveAsync(new Answer { Id = id });
            return NoContent();
        }
    }
}
