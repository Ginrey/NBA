namespace NBAManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MatchupLog")]
    public partial class MatchupLog
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MatchupId { get; set; }

        public int? Quarter { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OccurTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string TeamId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string PlayerId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string ActionTypeId { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        public virtual ActionType ActionType { get; set; }

        public virtual Matchup Matchup { get; set; }

        public virtual Player Player { get; set; }

        public virtual Team Team { get; set; }
    }
}
