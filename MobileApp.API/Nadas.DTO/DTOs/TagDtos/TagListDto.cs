using Nadas.DTO.DTOs.QuestionDtos;
using Nadas.DTO.Interfaces;

namespace Nadas.DTO.DTOs.TagDtos
{
    public class TagListDto : IDto
    {
        public string Name { get; set; }
        public List<QuestionListDto> Questions { get; set; }
    }
}
