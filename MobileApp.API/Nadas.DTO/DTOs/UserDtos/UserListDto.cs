using Nadas.DTO.Interfaces;

namespace Nadas.DTO.DTOs.UserDtos
{
    public class UserListDto : IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
    }
}
