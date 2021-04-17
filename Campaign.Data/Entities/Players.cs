using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Campaign.Data.Entities
{
    [Table("tblPlayers")]
    public class Players
    {
        public long PlayerID { get; set; }

        public string PlayerName { get; set; }

        public long? NetworkID { get; set; }

        public string ViewerName { get; set; }

        public int? ResolutionWidth { get; set; }

        public int? ResolutionHeight { get; set; }

        public bool? Status { get; set; }
    }
}
