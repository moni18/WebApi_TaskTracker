using ApplicationLayer.Common.Mappings;
using ApplicationLayer.Projects.Commands.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Projects.Queries.ProjectListQuery
{
    public class ProjectListDto: IMapWith<Project>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProjectStatus projectStatus { get; set; }
        public int Priority { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Project, ProjectListDto>()
                .ForMember(prpjDto => prpjDto.Id,
                opt => opt.MapFrom(proj => proj.Id))
                .ForMember(prpjDto => prpjDto.Name,
                opt => opt.MapFrom(proj => proj.Name))
                .ForMember(prpjDto => prpjDto.StartDate,
                opt => opt.MapFrom(proj => proj.StartDate))
                .ForMember(prpjDto => prpjDto.EndDate,
                opt => opt.MapFrom(proj => proj.EndDate))
                .ForMember(prpjDto => prpjDto.projectStatus,
                opt => opt.MapFrom(proj => proj.projectStatus))
                .ForMember(prpjDto => prpjDto.Priority,
                opt => opt.MapFrom(proj => proj.Priority));
        }
    }
}
