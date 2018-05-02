using Helium.Data.Entity.File.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Helium.Data.EntityMappingConfigurations.File
{
    public class AccessUnitMapper : IEntityTypeConfiguration<AccessUnit>
    {
        public void Configure(EntityTypeBuilder<AccessUnit> builder)
        {
            builder.HasOne(m => m.AccessUnitDetail).WithOne(d => d.AccessUnit);
        }
    }
    public class AccessUnitDetailMapper : IEntityTypeConfiguration<AccessUnitDetail>
    {
        public void Configure(EntityTypeBuilder<AccessUnitDetail> builder)
        {
            builder.HasOne(m => m.AccessUnit).WithOne(d => d.AccessUnitDetail);
        }
    }

    public class ContactLevelMapper : IEntityTypeConfiguration<ContactLevel>
    {
        public void Configure(EntityTypeBuilder<ContactLevel> builder)
        {
            builder.HasMany(m => m.Contacts).WithOne(d => d.ContactLevel);
        }
    }

    public class ContactMapper : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasOne(m => m.AccessUnit).WithMany(d => d.Contacts);
        }
    }

    public class FireContorlLevelMapper : IEntityTypeConfiguration<FireContorlLevel>
    {
        public void Configure(EntityTypeBuilder<FireContorlLevel> builder)
        {
            builder.HasMany(m => m.AccessUnits).WithOne(d => d.AccessUnitDetail.FireContorlLevel);
        }
    }

    public class PurposeMapper : IEntityTypeConfiguration<Purpose>
    {
        public void Configure(EntityTypeBuilder<Purpose> builder)
        {
            builder.HasMany(m => m.AccessUnits).WithOne(d => d.AccessUnitDetail.Purpose);
        }
    }

    public class StructurecsMapper : IEntityTypeConfiguration<Structurecs>
    {
        public void Configure(EntityTypeBuilder<Structurecs> builder)
        {
            builder.HasMany(m => m.AccessUnits).WithOne(d => d.AccessUnitDetail.Structurecs);
        }
    }


}
