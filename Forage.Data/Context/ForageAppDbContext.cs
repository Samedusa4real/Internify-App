﻿using Forage.Core.Entities;
using Forage.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Forage.Core;

namespace Forage.Data.Context
{
    public class ForageAppDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<HelpMessageType> HelpMessageTypes { get; set; }
        public DbSet<HelpMessage> HelpMessages { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<CourseLevel> CourseLevels { get; set; }
        public DbSet<CompanyIndustryField> CompanyIndustryFields { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<CourseSkill> CourseSkills { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseLesson> CourseLessons { get; set; }
        public DbSet<Intern> Interns { get; set; }
        public DbSet<CourseLessonActivity> CourseLessonActivities { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<PrivacyNotice> PrivacyNotices { get; set; }
        public DbSet<CourseIntern> CourseInterns { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactLanguage> ContactLanguages { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<AboutLanguage> AboutLanguages { get; set; }
        public DbSet<QuestionLanguage> QuestionLanguages { get; set; }
        public DbSet<InternCourseTest> InternCourseTests { get; set; }

        public ForageAppDbContext(DbContextOptions<ForageAppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new HelpMessageConfiguration());
            modelBuilder.ApplyConfiguration(new HelpMessageTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CourseCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CourseLevelConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyIndustryFieldConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new SkillConfiguration());
            modelBuilder.ApplyConfiguration(new CourseLessonConfiguration());
            modelBuilder.ApplyConfiguration(new InternConfiguration());
            modelBuilder.ApplyConfiguration(new CourseLessonActivityConfiguration());
            modelBuilder.ApplyConfiguration(new SubscribeConfiguration());
            modelBuilder.ApplyConfiguration(new SettingConfiguration());
			modelBuilder.ApplyConfiguration(new PartnerConfiguration());
            modelBuilder.ApplyConfiguration(new PrivacyNoticeConfiguration());
            modelBuilder.ApplyConfiguration(new CourseInternConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new AboutConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new AboutLanguageConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
