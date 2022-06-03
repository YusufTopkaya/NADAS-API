using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Nadas.API.Business.Interfaces;
using Nadas.API.Entities.Concrete;
using Nadas.DTO.DTOs.AnswerDtos;
using Nadas.DTO.DTOs.QuestionDtos;

namespace Nadas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        private readonly IMapper _mapper;

        public QuestionsController( IQuestionService questionService, IMapper mapper)
        {
            _questionService = questionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var questions = await _questionService.GetAllLoadedAsync();
            return Ok(_mapper.Map<List<QuestionListDto>>(questions).OrderByDescending(I=> I.Id));
        }
        [HttpGet]
        [Route("QuestionCount")]
        public async Task<IActionResult> QuestionCount()
        {
            var questions = await _questionService.GetAllLoadedAsync();
            int count = _mapper.Map<List<QuestionListDto>>(questions).OrderByDescending(I => I.Id).Count();
            return Ok(count);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<QuestionListDto>(await _questionService.FindById(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Create(QuestionAddDto question)
        {
            Question newquestion = await _questionService.AddAsync(_mapper.Map<Question>(question));
            newquestion.CreatedUserId = question.UserId;
            return Created("", newquestion);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id ,QuestionUpdateDto question)
        {
            if (id != question.Id)
                return BadRequest("");
            await _questionService.UpdateAsync(_mapper.Map<Question>(question));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _questionService.RemoveAsync(new Question { Id = id });
            return NoContent();
        }

    }
}
