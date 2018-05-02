using Helium.Tools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;

namespace Helium.Service
{
    public class HContext : DbContext
    {
        public HContext(DbContextOptions<HContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var entityTypes = Assembly.Load(new AssemblyName("Helium.Data.Entity")).GetTypes()
                .Where(type => !string.IsNullOrWhiteSpace(type.Namespace))
                .Where(type => type.GetTypeInfo().IsClass)
                .Where(type => type.GetTypeInfo().BaseType != null)
                .Where(type => typeof(EntityBaseClass<>).IsAssignableFrom(type)).ToList();

            foreach (var entityType in entityTypes)
            {
                //  防止重复附加模型，否则会在生成指令中报错
                if (builder.Model.FindEntityType(entityType) != null)
                    continue;
                builder.Model.AddEntityType(entityType);
            }            


            var typesToRegister = Assembly.GetExecutingAssembly()
                .GetTypes().Where(q => q.GetInterface(typeof(IEntityTypeConfiguration<>).FullName) != null);
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                builder.ApplyConfiguration(configurationInstance);
            }

            base.OnModelCreating(builder);
        }
    }
}
