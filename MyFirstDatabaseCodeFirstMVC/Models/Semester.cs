using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFirstDatabaseCodeFirstMVC.Models
{
    [Table(name: "Semester")]
    public class Semester
    {
        [Key]
        public string KodeSemester { get; set; } //Key
        [Required]
        [Display(Name = "Nama Semester")]
        public string NamaSemester { get; set; }
        [Display(Name = "Tahun Ajaran")]
        [Range(2000, 2030)]
        public int TahunAjaran { get; set; }
        public virtual ICollection<Nilai> Nilai { get; set; }
        
    }
}