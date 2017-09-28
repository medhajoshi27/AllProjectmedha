using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEntities.Domain
{
    public class ConfigurationList : BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? TypeId { get; set; }
        public int OrganizationId { get; set; }
    }
    public class ConfigurationTypeList : BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Guid? TenantId { get; set; }

    }
    public class ConfigurationStatusList : BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Guid? TenantId { get; set; }

    }
    public class PlatformList : BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Guid? TenantId { get; set; }

    }
    public class OperatingSystemList : BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Platformid { get; set; }

    }
    public class InterfaceClass
    {
        public string name { get; set; }
        public string ip_address { get; set; }
        public string notes { get; set; }
        public bool primary { get; set; }
    }
}
