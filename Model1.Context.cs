//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Danilov_stadium
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class danilov_stadiumEntities : DbContext
    {
        public danilov_stadiumEntities()
            : base("name=danilov_stadiumEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<event_types> event_types { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<staff> staff { get; set; }
        public virtual DbSet<event_statuses> event_statuses { get; set; }
        public virtual DbSet<statuses> statuses { get; set; }
        public virtual DbSet<teams> teams { get; set; }
        public virtual DbSet<events> events { get; set; }
        public virtual DbSet<staff_sets> staff_sets { get; set; }
    
        public virtual ObjectResult<Nullable<long>> GetNextSequenceValue()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("GetNextSequenceValue");
        }
    }
}
