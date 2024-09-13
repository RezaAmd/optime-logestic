using Application.Common.Interfaces;
using Domain.Entities.Customers;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Apply all fluent api configuration. (/data/configurations/)
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #region Tables

        public DbSet<UserEntity> Users => Set<UserEntity>();

        #endregion

        public async Task<bool> SaveChangeAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return Convert.ToBoolean(await SaveChangesAsync(cancellationToken));
        }

    }
}