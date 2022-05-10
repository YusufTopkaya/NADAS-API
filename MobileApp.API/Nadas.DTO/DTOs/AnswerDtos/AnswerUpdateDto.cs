using Nadas.DTO.DTOs.ContentDtos;
using Nadas.DTO.Interfaces;

namespace Nadas.DTO.DTOs.AnswerDtos
{
    public class AnswerUpdateDto : IDto
    {
        public int Id { get; set; }
        public bool IsVerified { get; set; }
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public ContentListDto Content { get; set; }
    }
}
