using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nadas.API.Business.Concrete;
using Nadas.API.Business.Interfaces;
using Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using Nadas.API.DataAccess.Interfaces;
using Refit;

namespace Nadas.API.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<NadasContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Remote"), opt =>
                    opt.MigrationsAssembly("Nadas.API")
                ),ServiceLifetime.Transient,ServiceLifetime.Transient
            );

            services
                .AddRefitClient<INotificationApi>()
                .ConfigureHttpClient(c=>c.BaseAddress=new Uri(configuration.GetSection("FirebaseNotificationBaseUrl").Value));

            services.AddScoped(typeof(IGenericDal<>),typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>),typeof(GenericManager<>));

            services.AddScoped(typeof(IQuestionService), typeof(QuestionManager));
            services.AddScoped(typeof(IQuestionDal), typeof(EfQuestionRepository));

            services.AddScoped(typeof(IAnswerService), typeof(AnswerManager));
            services.AddScoped(typeof(IAnswerDal), typeof(EfAnswerRepository));

            services.AddScoped(typeof(IUserService), typeof(UserManager));
            services.AddScoped(typeof(IUserDal), typeof(EfUserRepository));

            services.AddScoped(typeof(IContentService), typeof(ContentManager));
            services.AddScoped(typeof(IContentDal), typeof(EfContentRepository));

            services.AddScoped(typeof(ITagService), typeof(TagManager));
            services.AddScoped(typeof(ITagDal), typeof(EfTagRepository));

            services.AddTransient<IFirestoreService, FirestoreManager>();
            services.AddTransient<INotificationService, NotificationManager>();

            services.AddTransient<IBlogService, BlogManager>();
            services.AddScoped(typeof(IBlogDal), typeof(EfBlogRepository));

        }
    }
}
