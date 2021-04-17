using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;


namespace Campaign.Data.Entities
{
    [Table("tblNetwork")]
    public class Network
    {
        public long NetworkId { get; set; }
        public HierarchyId Level { get; set; }
        public string NetworkName { get; set; }


    }
}
