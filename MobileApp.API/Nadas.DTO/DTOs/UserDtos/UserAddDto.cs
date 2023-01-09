using Nadas.DTO.Interfaces;

namespace Nadas.DTO.DTOs.UserDtos
{
    public class UserAddDto : IDto
    {
        public string FireBaseId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
