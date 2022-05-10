using Nadas.DTO.Interfaces;

namespace Nadas.DTO.DTOs.ContentDtos
{
    public class ContentUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
