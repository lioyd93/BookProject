namespace CoolBooksProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reviews
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        [Required]
        [StringLength(128)]
        public string UserId { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(4000)]
        public string Text { get; set; }

        public byte? Rating { get; set; }

        public DateTime Created { get; set; }

        public bool IsDeleted { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }

        public virtual Books Books { get; set; }
    }
}
