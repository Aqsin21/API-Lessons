using Academy.BusinessLogicLayer.Dtos;
using Academy.DataAccessLayer.DataContext.Entities;
using AutoMapper;


namespace Academy.BusinessLogicLayer.AutoMapping;

public class MappingProfile :Profile
{
    public MappingProfile()
    {
        CreateMap<Student, StudentDto>()
            .ForMember(dest => dest.GroupName, opt => opt.MapFrom(src => src.Group.Name))
            .ReverseMap();
        CreateMap<StudentCreateDto, Student>().ReverseMap();
        CreateMap<StudentUpdateDto, Student>().ReverseMap();


        CreateMap<Group, GroupDto>()
            .ForMember(dest => dest.Students, opt => opt.MapFrom(src => src.Students.Select(s => s.Id)))
            .ReverseMap();
        CreateMap<GroupCreateDto, Group>().ReverseMap();
        CreateMap<GroupUpdateDto, Group>().ReverseMap();
    }
            
}
