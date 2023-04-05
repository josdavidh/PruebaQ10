using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PruebaQ10.Models;

public partial class Tarea
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    [DisplayName( "Fecha de creación" )]
    public DateTime? FechaCreacion { get; set; }

    public bool Completada { get; set; }
}
