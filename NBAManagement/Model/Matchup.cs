namespace NBAManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Matchup")]
    public partial class Matchup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matchup()
        {
            MatchupDetail = new HashSet<MatchupDetail>();
            MatchupLog = new HashSet<MatchupLog>();
            PlayerStatistics = new HashSet<PlayerStatistics>();
        }

        [StringLength(50)]
        public string MatchupId { get; set; }

        [Required]
        [StringLength(50)]
        public string SeasonId { get; set; }

        [Required]
        [StringLength(50)]
        public string MatchupTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string Team_AwayId { get; set; }

        [Required]
        [StringLength(50)]
        public string Team_HomeId { get; set; }

        public DateTime? Starttime { get; set; }

        public int? Team_Away_Score { get; set; }

        public int? Team_Home_Score { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public int? CurrentQuarter { get; set; }

        public virtual MatchupType MatchupType { get; set; }

        public virtual Season Season { get; set; }

        public virtual Team Team { get; set; }

        public virtual Team Team1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchupDetail> MatchupDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchupLog> MatchupLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerStatistics> PlayerStatistics { get; set; }
    }
}
