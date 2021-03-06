﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TramiteDigitalWeb.Models
{
    public class ConsultasViewModels
    {
        [Display(   Name = "Nodos", 
                    Description = "Lista de nodos")]
        [Required(  AllowEmptyStrings = false, 
                    ErrorMessage="Debe seleccionar un nodo")]
        [Range(1,1000, ErrorMessage="Debe seleccionar un nodo")]
        public int NodoSeleccionado { get; set; }

        [Display(   Name = "Expedientes",
                    Description = "Lista de expedientes")]
        [Required(  AllowEmptyStrings = false, 
                    ErrorMessage="Debe seleccionar un expediente")]
        [Range(1, 1000, ErrorMessage = "Debe seleccionar un expediente")]
        public int ExpedienteSeleccionado { get; set; }

        [Display(   Name = "Valor trazable Principal",
                    Description = "Por valor trazable principal")]
        public Boolean Valor_Trazable_Principal { get; set; }

        [Display(Name = "Valor trazable del expediente",
                    Description = "Por valores trazables del expediente")]
        public Boolean Valor_Trazable_Expediente { get; set; }

        [Display(Name = "Valor trazable del documento",
                    Description = "Por valores trazables de los documentos")]
        public Boolean Valor_Trazable_Documento { get; set; }

        [Display(   Name = "Valor trazable",
                    Description = "Valor único identificable")]
        [Required(  AllowEmptyStrings=false, 
                    ErrorMessage="Debe indicar un valor trazable")]
        public string Valor_Trazable { get; set; }
    }
}
