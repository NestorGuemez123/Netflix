using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoOnDemand.Web.Models
{
    public class PersonaViewModel
    {
        public int? Id { get; set; }
        [Required]
        [MaxLength(25)]
        [DisplayName ("Nombre")]
        public string Name { get; set; }
        [MaxLength(500)]
        [DisplayName ("Descripción")]
        public string Descripcion { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Fecha de nacimiento")]
        public DateTime? FechaNacimiento { get; set; }
        [DisplayName("Estatus")]
        public bool? Status { get; set; }
    }
}