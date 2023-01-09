using AutoMapper;
using Nadas.API.Entities.Concrete;
using Nadas.DTO.DTOs.AnswerDtos;
using Nadas.DTO.DTOs.ContentDtos;
using Nadas.DTO.DTOs.QuestionDtos;
using Nadas.DTO.DTOs.UserDtos;

namespace Nadas.API.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {

            CreateMap<UserListDto, User>().ReverseMap();
            CreateMap<UserAddDto, User>().ReverseMap();
            CreateMap<UserUpdateDto, User>().ReverseMap();

            CreateMap<QuestionListDto, Question>().ReverseMap();
            CreateMap<QuestionAddDto, Question>().ReverseMap();
            CreateMap<QuestionUpdateDto, Question>().ReverseMap();

            CreateMap<AnswerListDto, Answer>().ReverseMap();
            CreateMap<AnswerAddDto, Answer>().ReverseMap();
            CreateMap<AnswerUpdateDto, Answer>().ReverseMap();

            CreateMap<ContentListDto, Content>().ReverseMap();
            CreateMap<ContentAddDto, Content>().ReverseMap();
            CreateMap<ContentUpdateDto, Content>().ReverseMap();
        }
    }
}
