using Nadas.DTO.Interfaces;

namespace Nadas.DTO.DTOs.ContentDtos
{
    public class ContentAddDto : IDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
