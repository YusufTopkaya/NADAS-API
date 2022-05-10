using Nadas.DTO.DTOs.ContentDtos;
using Nadas.DTO.DTOs.UserDtos;
using Nadas.DTO.Interfaces;

namespace Nadas.DTO.DTOs.QuestionDtos
{
    public class QuestionAddDto : IDto
    {
        public string Title { get; set; }
        public ContentListDto Content { get; set; }
        public int UserId { get; set; }
    }
}
