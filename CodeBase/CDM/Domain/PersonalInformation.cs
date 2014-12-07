using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoNise.Domain;
using AutoNise.Mapping;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace CDM.Domain
{
    public partial class PersonalInformation : BaseEntity<long>
    {
        public virtual int? UserGroupId { get; set; }

        public virtual Guid UserId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string UserRole { get; set; }
        public virtual string Email { get; set; }
        public virtual bool EmailVerified { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string FullName
        {
            get
            {
                return this.LastName + ", " + this.FirstName;

            }
        }

        public virtual Organization Organization { get; set; }
        public virtual int? OrganizationId { get; set; }
        public virtual bool MarkAsDeleted { get; set; }
    }

    class PersonalInformationMap : BaseEntityMap<PersonalInformation, long>
    {
        public PersonalInformationMap()
        {
            this.Table("PersonalInformations"); this.Lazy(true);
            this.Id<long>(x => x.Id, mp => { mp.Column("Id"); mp.Generator(Generators.Native); mp.UnsavedValue(0); });
            this.Property<Guid>(x => x.UserId, mp => { mp.NotNullable(true); mp.Column("UserId"); });
            this.Property<string>(x => x.FirstName, mp => { mp.NotNullable(true); mp.Column("FirstName"); });
            this.Property<string>(x => x.FirstName, mp => { mp.NotNullable(true); mp.Column("FirstName"); });
            this.Property<string>(x => x.LastName, mp => { mp.NotNullable(true); mp.Column("LastName"); });
            this.Property<string>(x => x.UserRole, mp => { mp.NotNullable(true); mp.Column("UserRole"); });
            this.Property<string>(x => x.Email, mp => { mp.NotNullable(true); mp.Column("Email"); });
            this.Property<bool>(x => x.EmailVerified, mp => { mp.NotNullable(true); mp.Column("EmailVerified"); });
            this.Property<string>(x => x.PhoneNumber, mp => { mp.Column("PhoneNumber"); });
       

            this.Property<int?>(x => x.UserGroupId, mp => { mp.Column("UserGroupId"); });

            this.Property<int?>(x => x.OrganizationId, mp => { mp.Column("OrganizationId"); });

            this.ManyToOne<Organization>(x => x.Organization, mp => { mp.Lazy(LazyRelation.Proxy); mp.Update(false); mp.Insert(false); mp.Column("OrganizationId"); });
            this.Property<bool>(x => x.MarkAsDeleted, mp => { mp.Column("MarkAsDeleted"); });
        }
    }

}
