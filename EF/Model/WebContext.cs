using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1.Model
{
    public class WebContext : DbContext
    {
        
        // Tạo ILoggerFactory 
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => {
            builder
                   .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Warning)
                   .AddFilter(DbLoggerCategory.Query.Name, LogLevel.Debug)
                   .AddConsole();
        }
        );

        protected string connection = @"Data Source=localhost,1433;
                                         Initial Catalog=webdb;
                                         User ID=SA;Password=Password123;TrustServerCertificate=True;";
        public DbSet<Article> Articles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ArticleTags> ArticleTags { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connection);
            optionsBuilder.UseLoggerFactory(loggerFactory);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ArticleTags>(entity => {

                entity.HasIndex(ArticleTags =>
                new
                {
                    ArticleTags.ArticleId,
                    ArticleTags.TagId
                }
                ).IsUnique();
                });
        }




    }
}
