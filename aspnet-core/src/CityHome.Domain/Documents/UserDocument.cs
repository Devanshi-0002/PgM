using CityHome.PgMembers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace CityHome.Documents
{
    public class UserDocument : AuditedAggregateRoot<Guid>
    {
        public Guid UserId { get; set; }
        public PgMember User { get; set; }
        public string AdharCardNumber { get; set; }
        public byte[] AdharCardFile { get; set; }
        public byte[] PassportSizePhoto { get; set; }
    }
}
