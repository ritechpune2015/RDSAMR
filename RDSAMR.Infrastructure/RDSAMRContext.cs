using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using RDSAMR.Domain.Entities;
using System;

namespace RDSAMR.Infrastructure
{
    public class RDSAMRContext:DbContext
    {


        public RDSAMRContext(DbContextOptions<RDSAMRContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
           .HasData(
               new Role
               {
                   RoleID=1,
                   RoleName = "SuperAdmin"
               },
               new Role
               {
                   RoleID=2,
                   RoleName = "Admin",
               },
               new Role
               {
                   RoleID=3,
                   RoleName = "Staff",
               },
               new Role
               {
                   RoleID=4,
                   RoleName = "Consumer",
               }
           );

           modelBuilder.Entity<User>()
           .HasData(
               new User
               {
                   UserID=1,
                   Address="Akurdi",
                   EmailID= "superadmin@gmail.com",
                   FirstName="Achyut",
                   LastName="Kendre",
                   MobileNo="89894545898",
                   PasswordHash="admin"
               }
           );

            modelBuilder.Entity<UserRole>()
           .HasData(
               new UserRole
               {
                 RoleID=1,
                 UserID=1,
                 UserRoleID=1
               }
           );
        }
        private IDbContextTransaction _transaction;

        public void BeginTransaction()
        {
            _transaction = Database.BeginTransaction();
        }

        public void Commit(Int64 ByID)
        {
            BeginTransaction();
            try
            {
                foreach (var entry in ChangeTracker.Entries<BaseEntity>())
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            entry.Entity.CreationDate = DateTime.Now;
                            entry.Entity.CreatedByID = ByID;
                            entry.Entity.IsDeleted = false;
                            break;
                        case EntityState.Modified:
                            entry.Entity.UpdationDate = DateTime.Now;
                            entry.Entity.UpdatedByID = ByID;
                            entry.Entity.IsDeleted = false;
                            break;
                        case EntityState.Deleted:
                            entry.State = EntityState.Unchanged;
                            entry.Entity.DeletionDate = DateTime.Now;
                            entry.Entity.DeletedByID = ByID;
                            entry.Entity.IsDeleted = true;
                            break;
                    }
                }
                SaveChanges();
                _transaction.Commit();
            }
            catch (Exception)
            {
                _transaction.Rollback();
            }
            finally
            {
                _transaction.Dispose();
            }
        }

        public void Rollback()
        {
            _transaction.Rollback();
            _transaction.Dispose();
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        

    }
}
