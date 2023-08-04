using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using mvc_api.logger;
using Serilog;

namespace mvc_api.Models
{
    public class Seed
    {

        public static void SeedUsersData(BlogContext context) {
            if (context.Users.Any()) return;
            var Users_data = new List<User>() {
                new User {
                    id = Guid.NewGuid(),
                    UserName = "Bob",
                },
                new User {
                    id = Guid.NewGuid(),
                    UserName = "Tom",
                },
                new User {
                    id = Guid.NewGuid(),
                    UserName = "Curis",
                }
            };
            context.Users.AddRange(Users_data);
            context.SaveChanges();
        }

        public static void SeedArticlesData(Serilog.ILogger log,BlogContext context) {
            //Article article = context.Articles.First(c => c.id==8);

            //context.Entry(article).Reference(c => c.User).Load();
            log.Information(1.ToString());

            if (context.Articles.Any()) return;
        
            var Article_data = new List<Article>
            {
                new Article{ 
                    Title="Article 1",
                    Content="xxx",
                    ArticleRead=true,
                    UserId=new Guid("4937B014-3321-45E3-9C3E-AF4E09DE4719")
                },

                new Article{ 
                    Title="Article 2",
                    Content="xxx",
                    ArticleRead=false,
                    UserId=new Guid("8EAA0EB5-2E86-405B-9471-BFDB4A5E21C0")
                },
                new Article{ 
                    Title="Article 3",
                    Content="yyy",
                    ArticleRead=true,
                    UserId= new Guid("F7FFDA0D-E9F2-4D26-BD91-EECB4466A4B8")
                },
                new Article{ 
                    Title="Article 4",
                    Content="yyyx",
                    ArticleRead=false,
                    UserId= new Guid("F7FFDA0D-E9F2-4D26-BD91-EECB4466A4B8")
                },
                new Article{ 
                    Title="Article 5",
                    Content="yyyxx",
                    ArticleRead=false,
                    UserId=new Guid("4937B014-3321-45E3-9C3E-AF4E09DE4719")
                },
            };
            context.Articles.AddRange(Article_data);
            context.SaveChanges();
        }
    }
}
