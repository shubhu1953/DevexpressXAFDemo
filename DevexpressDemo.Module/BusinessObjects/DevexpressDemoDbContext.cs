using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;

namespace DevexpressDemo.Module.BusinessObjects {
	public class DevexpressDemoDbContext : DbContext {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Task> AssignedTasks { get; set; }
        public DevexpressDemoDbContext(String connectionString)
			: base(connectionString) {
		}
		public DevexpressDemoDbContext(DbConnection connection)
			: base(connection, false) {
		}
		public DevexpressDemoDbContext()
			: base("name=ConnectionString") {
		}
		public DbSet<ModuleInfo> ModulesInfo { get; set; }
	}
}