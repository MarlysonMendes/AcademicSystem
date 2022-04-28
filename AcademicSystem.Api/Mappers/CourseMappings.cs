using AcademicSystem.Api.Dtos.CourseDtos;
using AcademicSystem.Domain.Models;
using AutoMapper;

namespace AcademicSystem.Api.Mappers
{
    public class CourseMappings : Profile
    {
        public CourseMappings()
        {
            CreateMap<Course,CourseGetDto>();
            CreateMap<CourseGetDto,Course>();

            CreateMap<Course,CoursePostPutDto>();
            CreateMap<CoursePostPutDto, Course>();
        }
    }
}
