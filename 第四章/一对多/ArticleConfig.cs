﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace 一对多
{
     class ArticleConfig : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("T_Articles");
            builder.Property(a=>a.Content).IsRequired().IsUnicode();
            builder.Property(a => a.Title).IsRequired().IsUnicode().HasMaxLength(255);
        }
    }
}
