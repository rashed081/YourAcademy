﻿using YourAcademy.DAL.Enums;

namespace YourAcademy.DAL.Entity
{
    public class Course:IEntity<Guid>
    {
        public virtual Guid Id { get; set; }
        public virtual string? Title { get; set; }
        public virtual string? Description { get; set; }
        public virtual float Price { get; set; }
        public virtual string? Instructor { get; set; }
        public virtual string? Image { get; set; }
        public virtual decimal Rating { get; set; }
        public virtual DifficultyLevel DifficultyLevel { get; set; }
        public virtual string CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
