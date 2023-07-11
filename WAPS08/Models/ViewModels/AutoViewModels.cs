using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WAPS08.Models.ViewModels
{
    public class AutoTableViewModel
    {
        public int _Idauto { get; set; }
        public string _Marca { get; set; }    
        public string _Modelo { get; set; }
        public string _Anio { get; set; }
        public string _Imagen { get; set; }
    }

    public class AddAutoViewModels
    {
        [Required]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Required]
        [Display(Name = "Modelo Del Vehiculo")]
        public string Modelo { get; set; }

        [Required]
        [Display(Name = "Ano Del Vehiculo")]
        public string Anio { get; set; }

        [Required]
        [Display(Name = "Ruta de la Imagen")]
        public string Imagen { get; set; }
    }

    public class EditAutoViewModels
    {
        public int IdAuto { get; set; }

        [Required]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Required]
        [Display(Name = "Modelo Del Vehiculo")]
        public string Modelo { get; set; }

        [Required]
        [Display(Name = "Ano Del Vehiculo")]
        public string Anio { get; set; }

        [Required]
        [Display(Name = "Ruta de la Imagen")]
        public string Imagen { get; set; }
    }
}