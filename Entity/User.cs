namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(2000)]
        public string password { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime creationDate { get; set; }

        public bool resetPassword { get; set; }
    }
}
