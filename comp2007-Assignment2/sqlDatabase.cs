namespace comp2007_Assignment2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class sqlDatabaseDBEntities : DbContext
    {
        public sqlDatabaseDBEntities()
            : base("name=sqlDatabase")
        {
        }

        public virtual DbSet<itemsMenu> itemsMenus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<itemsMenu>()
                .Property(e => e.Item_name)
                .IsFixedLength();

            modelBuilder.Entity<itemsMenu>()
                .Property(e => e.Item_group)
                .IsFixedLength();

            modelBuilder.Entity<itemsMenu>()
                .Property(e => e.whatIs)
                .IsFixedLength();
        }
    }
}
