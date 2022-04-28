using AcademicSystem.Api.Dtos.DisciplineDtos;
using AcademicSystem.Domain.Models;
using AutoMapper;

namespace AcademicSystem.Api.Mappers
{
    public class DisciplineMapping : Profile
    {
        public DisciplineMapping()
        {
            CreateMap<Discipline, DisciplineGetDto>();
            CreateMap<DisciplineGetDto, Course>();

            CreateMap<Discipline, DisciplinePostPutDto>();
            CreateMap<DisciplinePostPutDto, Discipline>();
        }
    }
}
