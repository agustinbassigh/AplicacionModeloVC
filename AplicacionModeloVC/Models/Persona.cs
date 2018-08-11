using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AplicacionModeloVC.Models
{
    [Table("Persona")]
    public class Persona
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("Nombre")]
        public string Nombre { get; set; }

        [Column("DNI")]
        public int DNI { get; set; }

        [Column("Promedio")]
        public decimal Promedio { get; set; }

        [Column("Activo")]
        public bool Activo { get; set; }
    }
}