﻿using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class LessonSubjectConfiguration : IEntityTypeConfiguration<LessonSubject>
    {
        public void Configure(EntityTypeBuilder<LessonSubject> builder)
        {
            builder.ToTable("LessonSubjects").HasKey(c => c.Id);
            builder.HasIndex(indexExpression: c => c.Name, name: "UK_Name").IsUnique();
            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }
}
