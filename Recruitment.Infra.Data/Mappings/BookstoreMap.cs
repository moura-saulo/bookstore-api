using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recruitment.Domain.Entities;

namespace Recruitment.Infra.Data.Mappings
{
    class BookstoreMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(c => c.Title)
            .IsRequired();

            builder.Property(c => c.CopyNumber)
                .IsRequired();
        }
    }
}
