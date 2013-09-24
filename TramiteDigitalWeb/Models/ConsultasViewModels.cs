using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TramiteDigitalWeb.Models
{
    public class ConsultasViewModels
    {
        [Display(Name = "Expedientes", Description = "Lista de expedientes")]
        [Required(AllowEmptyStrings = true)]
        public int ExpedienteSeleccionado { get; set; }

        [Display(Name = "Valor trazable")]
        [Required(ErrorMessage="Debe indicar un valor trazable")]
        public string Valor_Trazable { get; set; }
    }
}
