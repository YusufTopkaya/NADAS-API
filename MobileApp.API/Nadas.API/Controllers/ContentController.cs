using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nadas.API.Business.Interfaces;
using Nadas.API.Entities.Concrete;
using Nadas.DTO.DTOs.ContentDtos;

namespace Nadas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        private readonly IContentService _contentService;
        private readonly IMapper _mapper;

        public ContentController(IContentService contnetService, IMapper mapper)
        {
            _contentService = contnetService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<List<ContentListDto>>(await _contentService.GetAllAsync()));
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<ContentListDto>(await _contentService.FindById(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Create(ContentAddDto content)
        {
            await _contentService.AddAsync(_mapper.Map<Content>(content));
            return Created("", content);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ContentUpdateDto content)
        {
            if (id != content.Id)
                return BadRequest("");
            await _contentService.UpdateAsync(_mapper.Map<Content>(content));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _contentService.RemoveAsync(new Content { Id = id });
            return NoContent();
        }
    }
}
