using Nadas.API.Entities.Concrete;
using Nadas.DTO.DTOs.ContentDtos;
using Nadas.DTO.DTOs.QuestionDtos;
using Nadas.DTO.DTOs.UserDtos;
using Nadas.DTO.Interfaces;

namespace Nadas.DTO.DTOs.AnswerDtos
{
    public class AnswerListDto : IDto
    {
        public int Id { get; set; }
        public bool IsVerified { get; set; }
        public int UserId { get; set; }
        public UserListDto User { get; set; }
        public int QuestionId { get; set; }
        public ContentListDto Content { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
