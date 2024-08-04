using FMSApp.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSApp.DAL.Configuration
{
    internal class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.Property(x => x.WeekNumber).HasMaxLength(40);
            builder.HasOne(x => x.HomeTeam).WithMany().HasForeignKey(
                x => x.HomeTeamId
                ).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.GuestTeam).WithMany().HasForeignKey(
                x => x.GuestTeamId
                ).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
