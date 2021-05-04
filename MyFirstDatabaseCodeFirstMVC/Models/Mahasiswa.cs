using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFirstDatabaseCodeFirstMVC.Models
{
    [Table(name: "Mahasiswa")]
    public class Mahasiswa
    {
        [Key]
        public string Nim { get; set; } //Key

        [Required]
        [StringLength(100)]
        public string Nama { get; set; }
        [Display(Name = "Jenis Kelamin")]
        public bool Jk { get; set; }

        [Range(2000, 2030)]
        public int Angkatan { get; set; }
        [Display(Name = "Nomor HP")]
        public string NoHp { get; set; }
        public string Alamat { get; set; }

        public virtual ICollection<Nilai> Nilai { get; set; }
    }
}