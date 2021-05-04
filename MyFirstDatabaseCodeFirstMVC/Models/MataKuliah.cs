using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFirstDatabaseCodeFirstMVC.Models
{
    [Table(name: "MataKuliah")]
    public class MataKuliah
    {
        [Key]
        public string KodeMk { get; set; } //Key
        [Required]
        [Display(Name = "Nama Mata Kuliah")]
        public string NamaMk { get; set; }
        [Range(0, 5)]
        [Display(Name = "Jumlah SKS")]
        public int JumlahSks { get; set; }

        public virtual ICollection<Nilai> Nilai { get; set; }
    }
}