using System.Data.Entity;

namespace FluentAPI.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=dbWorkerEntries")
        {

        }
        public DbSet<Data> Datas { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Courses> Course { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(a => a.Course)
                   .WithRequired(c => c.Author)
                    .HasForeignKey(c => c.Author_Id);
            modelBuilder.Entity<Courses>()
                .HasKey(c=>c.Course_Id)
                .ToTable("tbl_course", "catalog");
            modelBuilder.Entity<Author>()
                .Property(t => t.Author_Name)
                .IsRequired();
            modelBuilder.Entity<Courses>()
                .Property(t => t.Course_Name)
                .IsRequired();
            modelBuilder.Entity<Author>()
                .HasKey(c=>c.Author_Id)
               .Property(t => t.Description)
               .IsOptional()
               .HasMaxLength(2000);
            modelBuilder.Entity<Author>()
             .Property(m => m.Author_Name)
             .HasColumnOrder(3)
             .HasColumnName("Name of the Author");
            modelBuilder.Entity<Tag>()
                .HasKey(m => m.Tag1);
            // modelBuilder.Entity<Courses>()
            // .HasMany<Tag>(a => a.Tags)
            // .WithMany(a => Course)
            //.Map(m => m.ToTable("coursetags"));
            modelBuilder.Entity<Caption>()
                .HasKey(m => m.caption);
                
            modelBuilder.Entity<Courses>()
            .HasOptional(c => c.caption)
            .WithRequired(c => c.course);
         

            base.OnModelCreating(modelBuilder);
        }
    }
}