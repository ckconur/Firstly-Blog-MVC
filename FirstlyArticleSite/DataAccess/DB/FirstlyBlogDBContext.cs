using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FirstlyArticleSite.DataAccess.DB
{
    public partial class FirstlyBlogDBContext : DbContext
    {
        public FirstlyBlogDBContext()
        {
        }

        public FirstlyBlogDBContext(DbContextOptions<FirstlyBlogDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<ArticlePicture> ArticlePictures { get; set; }
        public virtual DbSet<Following> Followings { get; set; }
        public virtual DbSet<LikedArticle> LikedArticles { get; set; }
        public virtual DbSet<ProfilePicture> ProfilePictures { get; set; }
        public virtual DbSet<SavedArticle> SavedArticles { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server= DESKTOP-I6NC62C; database = FirstlyBlogDB; uid= sa; pwd=onur123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.HeaderImage)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.Property(e => e.WriterId).HasColumnName("WriterID");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TopicArticle");

                entity.HasOne(d => d.Writer)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.WriterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserArticle");
            });

            modelBuilder.Entity<ArticlePicture>(entity =>
            {
                entity.HasKey(e => e.PictureId)
                    .HasName("PK_ArticlePictureID");

                entity.Property(e => e.PictureId).HasColumnName("PictureID");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.ArticlePictures)
                    .HasForeignKey(d => d.ArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PictureArticle");
            });

            modelBuilder.Entity<Following>(entity =>
            {
                entity.ToTable("Following");

                entity.Property(e => e.FollowingId).HasColumnName("FollowingID");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Followings)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Topic_Follow");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Followings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Follow");
            });

            modelBuilder.Entity<LikedArticle>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.LikedArticles)
                    .HasForeignKey(d => d.ArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LikeArticle");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LikedArticles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LikeUser");
            });

            modelBuilder.Entity<ProfilePicture>(entity =>
            {
                entity.HasKey(e => e.PictureId)
                    .HasName("PK_Picture");

                entity.Property(e => e.PictureId).HasColumnName("PictureID");

                entity.Property(e => e.Picture)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProfilePictures)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProfilePi__UserI__29572725");
            });

            modelBuilder.Entity<SavedArticle>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.SavedArticles)
                    .HasForeignKey(d => d.ArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Article_User");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SavedArticles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Article");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.Property(e => e.TopicName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email, "UQ__Users__A9D10534B268C949")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.AboutMe).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.Property(e => e.LoginGuid).HasMaxLength(40);

                entity.Property(e => e.Url)
                    .HasMaxLength(20)
                    .HasColumnName("URL");

                entity.Property(e => e.UserName).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
