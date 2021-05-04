using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFirstDatabaseCodeFirstMVC.Models
{
    [Table(name: "Nilai")]
    public class Nilai
    {
    
        [Key]
        [Column(Order = 0)]
        public string Nim { get; set; } //Key-1
        [ForeignKey("Nim")]
        public virtual Mahasiswa Mahasiswa { get; set; }
        [Key]
        [Column(Order = 1)]
        public string KodeMk { get; set; } //Key-2
        [ForeignKey("KodeMk")]
        public virtual MataKuliah MataKuliah { get; set; }
        [Key]
        [Column(Order = 2)]
        public string KodeSemester { get; set; } //Key-3
        [ForeignKey("KodeSemester")]
        public virtual Semester Semester { get; set; }
        [Display(Name = "Nilai Angka")]
        public double NilaiAngka { get; set; }
        [Display(Name = "Nilai Huruf")]
        public string NilaiHuruf { get; set; }
    }
}