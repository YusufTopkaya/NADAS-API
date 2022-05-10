using Nadas.DTO.DTOs.ContentDtos;
using Nadas.DTO.Interfaces;

namespace Nadas.DTO.DTOs.AnswerDtos
{
    public class AnswerAddDto : IDto
    {
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public ContentListDto Content { get; set; }
    }
}
