using Domain.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Repositories.Configurations
{
    public class ContatoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable(nameof(Aluno));
            builder.HasKey(c => c.Id);
            builder.Property(p => p.Id).HasColumnType("int");
            builder.Property(p => p.Nome).HasMaxLength(100);
        }
    }
}