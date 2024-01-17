﻿using FluentNHibernate.Mapping;
using YourAcademy.DAL.Entity;
using YourAcademy.DAL.Enums;

namespace YourAcademy.DAL.MappingFiles
{
    public class CourseMap :ClassMap<Course>
    {
        public CourseMap()
        {
            Id(x => x.Id).GeneratedBy.GuidComb();
            Map(x => x.Title);
            Map(x => x.Description);
            Map(x => x.Price);
            Map(x => x.Image);
            Map(x => x.Instructor);
            Map(x => x.Rating);
            //Map(x => x.CategoryId);
            Map(x => x.DifficultyLevel).CustomType<DifficultyLevel>().Column("difficulty").Not.Nullable();
            References(x => x.Category).Column("CategoryId");
            Table("Course");
        }
    }
}
