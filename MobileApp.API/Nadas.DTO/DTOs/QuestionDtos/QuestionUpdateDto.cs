using Nadas.API.Entities.Concrete;
using Nadas.DTO.DTOs.ContentDtos;
using Nadas.DTO.DTOs.UserDtos;
using Nadas.DTO.Interfaces;

namespace Nadas.DTO.DTOs.QuestionDtos
{
    public class QuestionUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ViewCount { get; set; }
        public int Rate { get; set; }
        public ContentListDto Content { get; set; }
        public int UserId { get; set; }
    }
}
