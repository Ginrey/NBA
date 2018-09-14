namespace NBAManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pictures
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Column(TypeName = "image")]
        public byte[] Img { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public int? NumberOfLike { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
