namespace NBAManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PostSeason")]
    public partial class PostSeason
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string TeamId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string SeasonId { get; set; }

        [StringLength(50)]
        public string Rank { get; set; }

        public virtual Season Season { get; set; }

        public virtual Team Team { get; set; }
    }
}
