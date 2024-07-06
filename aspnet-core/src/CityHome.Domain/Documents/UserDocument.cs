using CityHome.PgMembers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace CityHome.Documents
{
    public class UserDocument : FullAuditedAggregateRoot<Guid>
    {
        public string DocumentType { get; set; }
        public string DocumentPath { get; set; }

        public Guid PgMemberId { get; set; }
        public PgMember PgMember { get; set; }
    }
}
