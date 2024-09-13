using Domain.Entities.Customers;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<UserEntity> Users { get; }

        Task<bool> SaveChangeAsync(CancellationToken cancellationToken);
    }
}