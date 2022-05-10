using Nadas.DTO.DTOs.AnswerDtos;
using Nadas.DTO.DTOs.ContentDtos;
using Nadas.DTO.DTOs.UserDtos;
using Nadas.DTO.Interfaces;

namespace Nadas.DTO.DTOs.QuestionDtos
{
    public class QuestionListDto : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ViewCount { get; set; }
        public int Rate { get; set; }
        public int UserId { get; set; }
        public DateTime CreationDate { get; set; }
        public UserListDto User { get; set; }
        public List<AnswerListDto> Answers { get; set; }
        public ContentListDto Content { get; set; }
        
    }
}
