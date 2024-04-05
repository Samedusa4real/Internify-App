using FluentValidation.AspNetCore;
using FluentValidation;
using Forage.Core.Repositories;
using Forage.Data.Repositories;
using Forage.Service.Profiles.Companys;
using Forage.Service.Services.Implementations;
using Forage.Service.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Forage.Service.Validations.Questions;
using Forage.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Forage.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace Forage.Service
{
	public static class ServiceRegister
	{
        public static void AddScope(this IServiceCollection services, IConfiguration configuration)
        {
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();
			services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
			services.AddControllers()?.AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssemblyContaining<QuestionPostDtoValidation>());
			services.AddAutoMapper(typeof(CompanyProfile));
			services.AddDbContext<ForageAppDbContext>(opt =>
			{
				opt.UseSqlServer(configuration.GetConnectionString("Default"));
			});
			services.AddControllers().AddJsonOptions(x =>
							x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
			services.AddIdentity<AppUser, IdentityRole>()
					.AddDefaultTokenProviders()
						   .AddEntityFrameworkStores<ForageAppDbContext>();
			services.Configure<IdentityOptions>(options =>
			{
				// Default Lockout Settings.
				options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
				options.Lockout.MaxFailedAccessAttempts = 3;
				options.Lockout.AllowedForNewUsers = true;
				options.Password.RequireNonAlphanumeric = true;
				options.Password.RequireDigit = true;
				//options.SignIn.RequireConfirmedEmail = true;
				options.User.RequireUniqueEmail = true;
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 -";
                options.Password.RequiredLength = 6;
			});
			#region AddScoped

			services.AddScoped<ISubscribeRepository, SubscribeRepository>();
            services.AddScoped<ISubscribeService, SubscribeService>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IIdentityUserService, IdentityUserService>();
            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped<ISkillService, SkillService>();
            services.AddScoped<IInternRepository, InternRepository>();
            services.AddScoped<IInternService, InternService>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IMailService, MailService>();
            services.AddScoped<ITokenHandler, TokenHandler>();
            services.AddScoped<ICourseLessonRepository, CourseLessonRepository>();
            services.AddScoped<ICourseLessonService, CourseLessonService>();
            services.AddScoped<ICourseLessonActivityRepository, CourseLessonActivityRepository>();
            services.AddScoped<ICourseLessonActivityService, CourseLessonActivityService>();
            services.AddScoped<ICourseLessonLevelRepository, CourseLessonLevelRepository>();
            services.AddScoped<ICourseLessonLevelService, CourseLessonLevelService>();
            services.AddScoped<ICourseSkillRepository, CourseSkillRepository>();
            services.AddScoped<ICompanyIndustryFieldService, CompanyIndustryFieldService>();
            services.AddScoped<ICompanyIndustryFieldRepository, CompanyIndustryFieldRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<ICourseLevelRepository, CourseLevelRepository>();
            services.AddScoped<ICourseLevelService, CourseLevelService>();
            services.AddScoped<ICourseCategoryRepository, CourseCategoryRepository>();
            services.AddScoped<ICourseCategoryService, CourseCategoryService>();
            services.AddScoped<IHelpMessageTypeService, HelpMessageTypeService>();
            services.AddScoped<IHelpMessageTypeRepository, HelpMessageTypeRepository>();
            services.AddScoped<IHelpMessageService, HelpMessageService>();
            services.AddScoped<IHelpMessageRepository, HelpMessageRepository>();
            services.AddScoped<IPartnerRepository, PartnerRepository>();
            services.AddScoped<IPartnerService, PartnerService>();
			services.AddScoped<ISettingRepository, SettingRepository>();
			services.AddScoped<ISettingService, SettingService>();
            services.AddScoped<IPrivacyNoticeRepository, PrivacyNoticeRepository>();
            services.AddScoped<IPrivacyNoticeService, PrivacyNoticeService>();
            services.AddScoped<IInternCourseRepository, InternCourseRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IAboutUsRepository, AboutUsRepository>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IAboutLanguageRepository, AboutLanguageRepository>();
            services.AddScoped<IAboutLanguageService, AboutLanguageService>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();
            services.AddScoped<ILanguageService, LangService>();

            #endregion
        }
    }
}
