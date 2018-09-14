namespace NBAManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PlayerStatistics
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string MatchupId { get; set; }

        [Required]
        [StringLength(50)]
        public string TeamId { get; set; }

        [Required]
        [StringLength(50)]
        public string PlayerId { get; set; }

        public bool? IsStarting { get; set; }

        public int? Min { get; set; }

        public int? Point { get; set; }

        public int? Assist { get; set; }

        public int? FieldGoalMade { get; set; }

        public int? FieldGoalMissed { get; set; }

        public int? PointFieldGoalMade { get; set; }

        public int? PointFieldGoalMissed { get; set; }

        public int? FreeThrowMade { get; set; }

        public int? FreeThrowMissed { get; set; }

        public int? Rebound { get; set; }

        public int? OFFR { get; set; }

        public int? DFFR { get; set; }

        public int? Steal { get; set; }

        public int? Block { get; set; }

        public int? Turnover { get; set; }

        public int? Foul { get; set; }

        public virtual Matchup Matchup { get; set; }

        public virtual Player Player { get; set; }

        public virtual Team Team { get; set; }
    }
}
