namespace NBAManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MatchupDetail")]
    public partial class MatchupDetail
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string MatchupId { get; set; }

        public int? Quarter { get; set; }

        public int? Team_Away_Score { get; set; }

        public int? Team_Home_Score { get; set; }

        public virtual Matchup Matchup { get; set; }
    }
}
