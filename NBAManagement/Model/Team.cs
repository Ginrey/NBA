namespace NBAManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Team")]
    public partial class Team
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Team()
        {
            Matchup = new HashSet<Matchup>();
            Matchup1 = new HashSet<Matchup>();
            PlayerInTeamId = new HashSet<PlayerInTeamId>();
            PlayerStatistics = new HashSet<PlayerStatistics>();
            MatchupLog = new HashSet<MatchupLog>();
            PostSeason = new HashSet<PostSeason>();
        }

        [StringLength(50)]
        public string TeamId { get; set; }

        [StringLength(50)]
        public string TeamName { get; set; }

        [Required]
        [StringLength(50)]
        public string DivisionId { get; set; }

        [StringLength(50)]
        public string Coach { get; set; }

        [StringLength(50)]
        public string Abbr { get; set; }

        [StringLength(50)]
        public string Stadium { get; set; }

        [Column(TypeName = "image")]
        public byte[] Logo { get; set; }

        public virtual Division Division { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matchup> Matchup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matchup> Matchup1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerInTeamId> PlayerInTeamId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerStatistics> PlayerStatistics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchupLog> MatchupLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostSeason> PostSeason { get; set; }
    }
}
