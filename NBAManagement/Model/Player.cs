namespace NBAManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Player")]
    public partial class Player
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Player()
        {
            MatchupLog = new HashSet<MatchupLog>();
            PlayerInTeamId = new HashSet<PlayerInTeamId>();
            PlayerStatistics = new HashSet<PlayerStatistics>();
        }

        [StringLength(50)]
        public string PlayerId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string PositionId { get; set; }

        public DateTime? JoinYear { get; set; }

        public int? Height { get; set; }

        public int? Weight { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [StringLength(50)]
        public string College { get; set; }

        [Required]
        [StringLength(50)]
        public string CountryCode { get; set; }

        [Column(TypeName = "image")]
        public byte[] Img { get; set; }

        public bool? IsRetirment { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RetirementTime { get; set; }

        public virtual Country Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchupLog> MatchupLog { get; set; }

        public virtual Position Position { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerInTeamId> PlayerInTeamId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerStatistics> PlayerStatistics { get; set; }
    }
}
