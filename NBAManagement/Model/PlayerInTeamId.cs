namespace NBAManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlayerInTeamId")]
    public partial class PlayerInTeamId
    {
        [Key]
        [Column("PlayerInTeamId")]
        [StringLength(50)]
        public string PlayerInTeamId1 { get; set; }

        [Required]
        [StringLength(50)]
        public string PlayerId { get; set; }

        [Required]
        [StringLength(50)]
        public string TeamId { get; set; }

        [Required]
        [StringLength(50)]
        public string SeasonId { get; set; }

        [StringLength(50)]
        public string ShirtNumber { get; set; }

        [StringLength(50)]
        public string Salary { get; set; }

        public int? StarterIndex { get; set; }

        public virtual Player Player { get; set; }

        public virtual Season Season { get; set; }

        public virtual Team Team { get; set; }
    }
}
